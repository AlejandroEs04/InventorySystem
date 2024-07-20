using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FasterTickets
{
    public partial class Form1 : Form
    {
        private List<DataRow> selectedProducts = new List<DataRow>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            searchButton.Click += new EventHandler(SearchButton_Click);
            addButton.Click += new EventHandler(AddButton_Click);
            printButton.Click += new EventHandler(PrintButton_Click);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }
        private void LoadAllProducts()
        {
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM Products WHERE name LIKE @searchText";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DataRow dataRow = ((DataRowView)selectedRow.DataBoundItem).Row;
                selectedProducts.Add(dataRow);

                UpdateSelectedProductsGrid();
                UpdateTotals();
            }
            else
            {
                MessageBox.Show("Seleccione un producto.");
            }
        }

        private void UpdateSelectedProductsGrid()
        {
            DataTable selectedProductsTable = new DataTable();

            if (selectedProducts.Count > 0)
            {
                selectedProductsTable = selectedProducts[0].Table.Clone();
                int total = 0;
                foreach (var row in selectedProducts)
                {
                    selectedProductsTable.ImportRow(row);
                }
            }

            selectedProductsDataGridView.DataSource = selectedProductsTable;
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;
            decimal iva = 0;
            decimal total = 0;

            foreach (var row in selectedProducts)
            {
                decimal price = Convert.ToDecimal(row["public_price"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                subtotal += price * quantity;
            }

            iva = subtotal * 0.16m; // IVA del 16%
            total = subtotal + iva;

            subtotalLabel.Text = $"{subtotal:C}";
            ivaLabel.Text = $"{iva:C}";
            totalLabel.Text = $"{total:C}";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string ticketPath = Path.Combine(downloadsPath, "ticket.pdf");

            if (selectedProducts.Count > 0)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(ticketPath, FileMode.Create));
                document.Open();

                document.Add(new Paragraph("Ticket de Compra"));
                foreach (var row in selectedProducts)
                {
                    string nombre = row["name"].ToString();
                    decimal precio = Convert.ToDecimal(row["public_price"]);
                    int cantidad = Convert.ToInt32(row["quantity"]);

                    document.Add(new Paragraph($"Nombre: {nombre}"));
                    document.Add(new Paragraph($"Precio: {precio:C}"));
                    document.Add(new Paragraph($"Cantidad: {cantidad}"));
                    document.Add(new Paragraph("------------"));
                }

                document.Close();
                MessageBox.Show("Ticket generado con éxito.");
                selectedProducts.Clear();
                UpdateSelectedProductsGrid();
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito.");
            }
        }

        private void selectedProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
