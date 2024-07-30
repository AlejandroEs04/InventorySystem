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
    public partial class Products : Form
    {
        private List<ProductForm> products;

        public Products()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";
            products = new List<ProductForm>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ProductView"; // Ajusta la consulta según tu tabla y columnas
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductForm product = new ProductForm
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Stock = reader.GetInt32("stock"),
                            Price = reader.GetDecimal("price"),
                            Cost = reader.GetDecimal("cost"),
                            Iva = reader.GetDecimal("iva")
                        };
                        products.Add(product);
                    }
                }
            }

            dataGridViewProducts.DataSource = products;
        }

        private void DataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductForm selectedProduct = products[e.RowIndex];
                ProductEditForm editForm = new ProductEditForm(selectedProduct);
                editForm.FormClosed += (s, args) => LoadProducts();
                editForm.Show();
            }
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm newProduct = new ProductForm();
            ProductEditForm editForm = new ProductEditForm(newProduct, true);
            editForm.FormClosed += (s, args) => LoadProducts(); // Recargar productos al cerrar el formulario
            editForm.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();

            List<ProductForm> productsFiltered = products.Where(p => p.Name.ToLower().Contains(searchText)).ToList();

            dataGridViewProducts.DataSource = productsFiltered;
        }
    }
}
