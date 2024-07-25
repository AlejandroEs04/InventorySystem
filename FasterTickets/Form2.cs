using FasterTickets.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FasterTickets
{
    public partial class Form2 : Form
    {
        private List<Product> products;
        private List<Product> productsFiltered;
        private List<ProductSelected> productsSelected;

        private bool isSelecting = false;
        private bool suppressSelectedIndexChanged = false;

        public Form2()
        {
            InitializeComponent();
            LoadProducts();
            ControllSettings();
        }

        private void LoadProducts()
        {
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";
            products = [];

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ProductView"; // Ajusta la consulta según tu tabla y columnas
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
            decimal iva = 0;
            decimal total = 0;

            foreach (DataGridViewRow row in productsSelectedGrid.Rows)
            {
                if (row.IsNewRow) continue;

                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                subtotal += price * quantity;
            }

            iva = subtotal * 0.16m; // IVA del 16%
            total = subtotal + iva;

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
                    .Where(p => p.Name.ToLower().Contains(searchText))
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
            int maxHeight = 150; // Máximo alto deseado
            int itemHeight = 20; // Alto de cada ítem, ajustar según necesario
            int height = Math.Min(maxHeight, productsFiltered.Count * itemHeight);

            searchPanel.Height = height;
            searchPanel.Width = tableLayoutPanel1.Width;
            searchPanel.Left = textBoxSearch.Left; // Alinear el Panel al TextBox
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

            Product productsSelected = products
                .Where(p => p.Name.ToLower().Contains(searchText))
                .FirstOrDefault();

            if (productsSelected == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            foreach (DataGridViewRow row in productsSelectedGrid.Rows)
            {
                // Asegurarse de no estar iterando sobre la fila nueva
                if (row.IsNewRow) continue;

                // Verificar que la celda "Name" no sea nula
                var nameCell = row.Cells["Name"];
                if (nameCell?.Value != null && nameCell.Value.ToString() == productsSelected.Name)
                {
                    // Verificar que la celda "Quantity" no sea nula
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
            productsSelectedGrid.DataSource = null;
            UpdateTotals();
        }
    }
}
