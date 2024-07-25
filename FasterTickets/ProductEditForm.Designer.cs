namespace FasterTickets
{
    partial class ProductEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            label1 = new Label();
            numericUpDownStock = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numericUpDownCost = new NumericUpDown();
            label4 = new Label();
            numericUpDownPrice = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            saveProductButton = new Button();
            removeProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(9, 102);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(646, 29);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 78);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Font = new Font("Segoe UI", 12F);
            numericUpDownStock.Location = new Point(9, 158);
            numericUpDownStock.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(646, 29);
            numericUpDownStock.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 134);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 3;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 190);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 5;
            label3.Text = "Costo";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.Font = new Font("Segoe UI", 12F);
            numericUpDownCost.Location = new Point(9, 214);
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(646, 29);
            numericUpDownCost.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 246);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("Segoe UI", 12F);
            numericUpDownPrice.Location = new Point(9, 270);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(646, 29);
            numericUpDownPrice.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.625F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDownPrice);
            panel1.Controls.Add(numericUpDownStock);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDownCost);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 444);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(9, 12);
            label5.Name = "label5";
            label5.Size = new Size(278, 30);
            label5.TabIndex = 8;
            label5.Text = "Informacion del producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(9, 42);
            label6.Name = "label6";
            label6.Size = new Size(488, 19);
            label6.TabIndex = 9;
            label6.Text = "Ingresa la informacion que se te pide para agregar la informacion del producto";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(saveProductButton);
            flowLayoutPanel1.Controls.Add(removeProductButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(678, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(119, 444);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // saveProductButton
            // 
            saveProductButton.AutoSize = true;
            saveProductButton.Location = new Point(3, 3);
            saveProductButton.Name = "saveProductButton";
            saveProductButton.Size = new Size(116, 25);
            saveProductButton.TabIndex = 0;
            saveProductButton.Text = "Guardar Producto";
            saveProductButton.UseVisualStyleBackColor = true;
            saveProductButton.Click += saveProductButton_Click;
            // 
            // removeProductButton
            // 
            removeProductButton.Location = new Point(3, 34);
            removeProductButton.Name = "removeProductButton";
            removeProductButton.Size = new Size(116, 23);
            removeProductButton.TabIndex = 1;
            removeProductButton.Text = "Eliminar Producto";
            removeProductButton.UseVisualStyleBackColor = true;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductEditForm";
            Text = "ProductEditForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private NumericUpDown numericUpDownStock;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownCost;
        private Label label4;
        private NumericUpDown numericUpDownPrice;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveProductButton;
        private Button removeProductButton;
    }
}