namespace FasterTickets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            searchTextBox = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            printButton = new Button();
            selectedProductsDataGridView = new DataGridView();
            label1 = new Label();
            subtotalLabel = new Label();
            ivaLabel = new Label();
            label3 = new Label();
            totalLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(893, 64);
            dataGridView1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(893, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(911, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(911, 41);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            printButton.Location = new Point(911, 111);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 4;
            printButton.Text = "Imprimir";
            printButton.UseVisualStyleBackColor = true;
            // 
            // selectedProductsDataGridView
            // 
            selectedProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selectedProductsDataGridView.BackgroundColor = SystemColors.Menu;
            selectedProductsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            selectedProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedProductsDataGridView.Location = new Point(12, 111);
            selectedProductsDataGridView.Name = "selectedProductsDataGridView";
            selectedProductsDataGridView.Size = new Size(893, 300);
            selectedProductsDataGridView.TabIndex = 5;
            selectedProductsDataGridView.CellContentClick += selectedProductsDataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 420);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 8;
            label1.Text = "Subtotal:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Font = new Font("Segoe UI", 15F);
            subtotalLabel.Location = new Point(109, 420);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(23, 28);
            subtotalLabel.TabIndex = 10;
            subtotalLabel.Text = "0";
            // 
            // ivaLabel
            // 
            ivaLabel.AutoSize = true;
            ivaLabel.Font = new Font("Segoe UI", 15F);
            ivaLabel.Location = new Point(109, 448);
            ivaLabel.Name = "ivaLabel";
            ivaLabel.Size = new Size(23, 28);
            ivaLabel.TabIndex = 12;
            ivaLabel.Text = "0";
            ivaLabel.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 448);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 11;
            label3.Text = "IVA:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 15F);
            totalLabel.Location = new Point(109, 476);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(23, 28);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(12, 476);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 13;
            label5.Text = "Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 551);
            Controls.Add(totalLabel);
            Controls.Add(label5);
            Controls.Add(ivaLabel);
            Controls.Add(label3);
            Controls.Add(subtotalLabel);
            Controls.Add(label1);
            Controls.Add(selectedProductsDataGridView);
            Controls.Add(printButton);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button addButton;
        private Button printButton;
        private DataGridView selectedProductsDataGridView;
        private Label label1;
        private Label subtotalLabel;
        private Label ivaLabel;
        private Label label3;
        private Label totalLabel;
        private Label label5;
    }
}
