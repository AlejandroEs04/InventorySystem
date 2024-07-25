using FasterTickets.Models;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FasterTickets
{
    public partial class ProductEditForm : Form
    {
        private ProductForm product;
        private bool isNewProduct;

        public ProductEditForm(ProductForm product, bool isNewProduct = false)
        {
            InitializeComponent();
            this.product = product;
            this.isNewProduct = isNewProduct;
            LoadProductData();
        }
        private void LoadProductData()
        {
            if (!isNewProduct)
            {
                textBoxName.Text = product.Name;
                numericUpDownStock.Value = product.Stock;
                numericUpDownPrice.Value = product.Price;
                numericUpDownCost.Value = product.Cost;
            }
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            product.Name = textBoxName.Text;
            product.Stock = (int)numericUpDownStock.Value;
            product.Price = numericUpDownPrice.Value;
            product.Cost = numericUpDownCost.Value;

            string connectionString = "Server=localhost;Database=Faster;User ID=root;Password=Alejandroe2004ms*;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command;

                if (isNewProduct)
                {
                    string query = "INSERT INTO Product (name, stock, cost, price, iva) VALUES (@name, @stock, @cost, @price, @iva)";
                    command = new MySqlCommand(query, connection);
                }
                else
                {
                    string query = "UPDATE Product SET name=@name, stock=@stock, cost=@cost, price=@price, iva=@iva WHERE id=@id";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", product.Id);
                }

                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@stock", product.Stock);
                command.Parameters.AddWithValue("@cost", product.Cost);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@iva", product.Iva);

                command.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
