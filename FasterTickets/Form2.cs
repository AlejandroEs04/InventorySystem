using FasterTickets.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using Font = iTextSharp.text.Font;
using Rectangle = iTextSharp.text.Rectangle;

namespace FasterTickets
{
    public partial class Form2 : Form
    {
        private List<Product> products;
        private List<Product> productsFiltered;
        private Decimal totalSale;
        private bool suppressSelectedIndexChanged = false;

        public Form2()
        {
            InitializeComponent();
            LoadProducts();
            ControllSettings();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            productsSelectedGrid.Rows.Clear();
            UpdateTotals();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            long saleId = SaveSale();
            SaveProductSale(saleId);

            GeneratePdf();
            productsSelectedGrid.Rows.Clear();
        }

        private void LoadProducts()
        {
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";
            products = [];

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ProductView";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Stock = reader.GetInt32("stock"),
                            Price = reader.GetDecimal("price"),
                            Iva = reader.GetDecimal("iva")
                        };
                        products.Add(product);
                    }
                }
            }

            productsFiltered = new List<Product>(products);
        }

        private void ControllSettings()
        {
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;

            productsSelectedGrid.Columns.Add("Id", "id");
            productsSelectedGrid.Columns.Add("Name", "Nombre");
            productsSelectedGrid.Columns.Add("Stock", "Inventario");
            productsSelectedGrid.Columns.Add("Quantity", "Cantidad");
            productsSelectedGrid.Columns.Add("Price", "Precio");

            productsSelectedGrid.Columns["Name"].ReadOnly = true;
            productsSelectedGrid.Columns["Price"].ReadOnly = true;
            productsSelectedGrid.Columns["Stock"].ReadOnly = true;

            subtotalLabel.Text = $"{0:C}";
            ivaLabel.Text = $"{0:C}";
            totalLabel.Text = $"{0:C}";


            productsSearchBox.SelectedIndexChanged += ProductsSearchBox_SelectedIndexChanged;

            suppressSelectedIndexChanged = true;

            productsSearchBox.DataSource = null;
            productsSearchBox.DataSource = productsFiltered;
            productsSearchBox.DisplayMember = "Name";

            suppressSelectedIndexChanged = false;
            searchPanel.Visible = false;
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;
            decimal iva;
            decimal total;

            foreach (DataGridViewRow row in productsSelectedGrid.Rows)
            {
                if (row.IsNewRow) continue;

                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                subtotal += price * quantity;
            }

            iva = subtotal * 0.16m;
            total = subtotal + iva;

            totalSale = total;

            subtotalLabel.Text = $"{subtotal:C}";
            ivaLabel.Text = $"{iva:C}";
            totalLabel.Text = $"{total:C}";
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (suppressSelectedIndexChanged)
                return;

            suppressSelectedIndexChanged = true;

            string searchText = textBoxSearch.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                productsFiltered = new List<Product>(products);
            }
            else
            {
                productsFiltered = products
                    .Where(p => p.Name.ToLower().Contains(searchText) || p.Id.ToString().Contains(searchText))
                    .ToList();
            }

            productsSearchBox.DataSource = null;
            productsSearchBox.DataSource = productsFiltered;
            productsSearchBox.DisplayMember = "Name";

            AdjustSearchPanelHeight();
            searchPanel.Visible = productsFiltered.Count > 0;

            suppressSelectedIndexChanged = false;
        }

        private void AdjustSearchPanelHeight()
        {
            int maxHeight = 150;
            int itemHeight = 20;
            int height = Math.Min(maxHeight, productsFiltered.Count * itemHeight);

            searchPanel.Height = height;
            searchPanel.Width = tableLayoutPanel1.Width;
            searchPanel.Left = textBoxSearch.Left;
            searchPanel.Top = textBoxSearch.Bottom;
        }

        private void ProductsSearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressSelectedIndexChanged || productsSearchBox.SelectedItem == null)
                return;

            suppressSelectedIndexChanged = true;

            suppressSelectedIndexChanged = true;
            Product selectedProduct = (Product)productsSearchBox.SelectedItem;
            textBoxSearch.Text = selectedProduct.Name;
            textBoxSearch.SelectionStart = textBoxSearch.Text.Length;
            textBoxSearch.SelectionLength = 0;

            searchPanel.Visible = false;

            suppressSelectedIndexChanged = false;
        }

        private void AddProduct()
        {
            string searchText = textBoxSearch.Text.ToLower();

            if (searchText.Length == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            Product? productsSelected = products
                .Where(p => p.Name.ToLower().Contains(searchText))
                .FirstOrDefault();

            if (productsSelected == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            foreach (DataGridViewRow row in productsSelectedGrid.Rows)
            {
                if (row.IsNewRow) continue;

                var nameCell = row.Cells["Name"];
                if (nameCell?.Value != null && nameCell.Value.ToString() == productsSelected.Name)
                {
                    var quantityCell = row.Cells["Quantity"];
                    if (quantityCell?.Value != null)
                    {
                        quantityCell.Value = Convert.ToInt32(quantityCell.Value) + 1;
                    }

                    UpdateTotals();

                    return;
                }
            }

            productsSelectedGrid.Rows.Add(productsSelected.Id, productsSelected.Name, productsSelected.Stock, 1, productsSelected.Price);

            UpdateTotals();
        }

        private long SaveSale()
        {
            long ventaId = 0;

            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySale = @"
                    INSERT INTO Sale (total, sale_date)
                        VALUES (@total, NOW());
                    SELECT LAST_INSERT_ID();";
                    MySqlCommand command = new MySqlCommand(querySale, connection);

                    using (MySqlCommand cmd = new MySqlCommand(querySale, connection))
                    {
                        cmd.Parameters.AddWithValue("@total", totalSale);

                        cmd.ExecuteNonQuery();
                        ventaId = cmd.LastInsertedId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la venta: " + ex.Message);
                }
            }

            return ventaId;
        }

        private void SaveProductSale(long saleId)
        {
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryProduct = @"
                        INSERT INTO SaleProduct (sale_id, product_id, quantity, price_unit)
                        VALUES (@sale_id, @product_id, @quantity, @price_unit)";

                    using(MySqlCommand cmd = new MySqlCommand(queryProduct, connection))
                    {
                        cmd.Parameters.Add("@sale_id", MySqlDbType.Int64);
                        cmd.Parameters.Add("@product_id", MySqlDbType.Int32);
                        cmd.Parameters.Add("@quantity", MySqlDbType.Int32);
                        cmd.Parameters.Add("@price_unit", MySqlDbType.Decimal);

                        foreach (DataGridViewRow row in productsSelectedGrid.Rows)
                        {
                            if (row.IsNewRow) continue;

                            var nameCell = row.Cells["Name"];
                            if (nameCell?.Value != null)
                            {
                                cmd.Parameters["@sale_id"].Value = saleId;
                                cmd.Parameters["@product_id"].Value = row.Cells["Id"].Value.ToString();
                                cmd.Parameters["@price_unit"].Value = Convert.ToDecimal(row.Cells["Price"].Value);
                                cmd.Parameters["@quantity"].Value = Convert.ToInt32(row.Cells["Quantity"].Value);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el producto: " + ex.Message);
                }
            }
        }

        private void GeneratePdf()
        {
            string filePath = "Ticket.pdf";

            Document doc = new Document(PageSize.A7, 10, 10, 10, 10);
            PdfWriter.GetInstance(doc, new FileStream("Ticket.pdf", FileMode.Create));
            doc.Open();
            Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA, 5);
            Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 6);
            Font footerBoldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 4);
            Font footerLittleFont = FontFactory.GetFont(FontFactory.HELVETICA, 4);
            Font cellHeaderFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 5);
            Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 5);

            doc.Add(new Paragraph("Faster Deposito Dental", headerFont));
            doc.Add(new Paragraph("Carlos Alejandro Estrada Martinez", headerFont));
            doc.Add(new Paragraph("RFC. EAMC-800717-BT9", headerFont));
            doc.Add(new Paragraph("Tel. 8112882028", headerFont));
            doc.Add(new Paragraph("Web. www.fasterdepot.com", headerFont));
            doc.Add(new Paragraph("No. 1", headerFont));

            doc.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;

            float[] columnWidths = { 2f, 1f, 1f };
            table.SetWidths(columnWidths);


            PdfPCell cell = new PdfPCell(new Phrase("Producto", cellHeaderFont));
            cell.Border = Rectangle.NO_BORDER;
            cell.Padding = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Cantidad", cellHeaderFont));
            cell.Border = Rectangle.NO_BORDER;
            cell.Padding = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Importe", cellHeaderFont));
            cell.Border = Rectangle.NO_BORDER;
            cell.Padding = 0;
            table.AddCell(cell);

            foreach (DataGridViewRow row in productsSelectedGrid.Rows)
            {
                if (row.IsNewRow) continue;

                var nameCell = row.Cells["Name"];
                if (nameCell?.Value != null)
                {
                    decimal subtotalProduct = Convert.ToInt32(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal totalProduct = subtotalProduct + (subtotalProduct * 0.16m);

                    cell = new PdfPCell(new Phrase(row.Cells["Name"].Value.ToString(), bodyFont));
                    cell.Border = Rectangle.NO_BORDER;
                    cell.Padding = 0;
                    cell.PaddingTop = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(row.Cells["Quantity"].Value.ToString(), bodyFont));
                    cell.Border = Rectangle.NO_BORDER;
                    cell.Padding = 0;
                    cell.PaddingTop = 5;
                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase(totalProduct.ToString(), bodyFont));
                    cell.Border = Rectangle.NO_BORDER;
                    cell.Padding = 0;
                    cell.PaddingTop = 5;
                    table.AddCell(cell);
                }
                
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph($"Subtotal: {subtotalLabel.Text:C}", footerFont));
            doc.Add(new Paragraph($"IVA: {ivaLabel.Text:C}", footerFont));
            doc.Add(new Paragraph($"Total: {totalLabel.Text:C}", footerFont));

            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph(DateTime.Now.ToString(), footerLittleFont));
            doc.Add(new Paragraph("Muchas gracias por su compra, vuelva pronto", footerBoldFont));

            doc.Close();

            OpenPDF(filePath);
        }

        private void OpenPDF(string filePath)
        {
            try
            {
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo abrir el archivo PDF. Detalles: " + ex.Message);
            }
        }
    }
}
