namespace FasterTickets
{
    partial class Form2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            addButton = new Button();
            textBoxSearch = new TextBox();
            panel1 = new Panel();
            searchPanel = new Panel();
            productsSearchBox = new ListBox();
            productsSelectedGrid = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            subtotalLabel = new Label();
            ivaLabel = new Label();
            totalLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            printButton = new Button();
            resetButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsSelectedGrid).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(addButton, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(872, 501);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(755, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(114, 29);
            addButton.TabIndex = 1;
            addButton.TabStop = false;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Segoe UI", 11F);
            textBoxSearch.Location = new Point(3, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(746, 27);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.Click += textBoxSearch_Click;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(searchPanel);
            panel1.Controls.Add(productsSelectedGrid);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 340);
            panel1.TabIndex = 5;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(productsSearchBox);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(0, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.RightToLeft = RightToLeft.Yes;
            searchPanel.Size = new Size(866, 113);
            searchPanel.TabIndex = 4;
            // 
            // productsSearchBox
            // 
            productsSearchBox.Cursor = Cursors.Hand;
            productsSearchBox.Dock = DockStyle.Fill;
            productsSearchBox.FormattingEnabled = true;
            productsSearchBox.IntegralHeight = false;
            productsSearchBox.ItemHeight = 15;
            productsSearchBox.Location = new Point(0, 0);
            productsSearchBox.Name = "productsSearchBox";
            productsSearchBox.RightToLeft = RightToLeft.No;
            productsSearchBox.Size = new Size(866, 113);
            productsSearchBox.TabIndex = 3;
            productsSearchBox.SelectedIndexChanged += ProductsSearchBox_SelectedIndexChanged;
            // 
            // productsSelectedGrid
            // 
            productsSelectedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsSelectedGrid.BackgroundColor = SystemColors.ControlLight;
            productsSelectedGrid.BorderStyle = BorderStyle.Fixed3D;
            productsSelectedGrid.Dock = DockStyle.Fill;
            productsSelectedGrid.Location = new Point(0, 0);
            productsSelectedGrid.Name = "productsSelectedGrid";
            productsSelectedGrid.Size = new Size(866, 340);
            productsSelectedGrid.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.46626F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.53374F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(subtotalLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(ivaLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(totalLabel, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 384);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(326, 114);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 34);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(152, 34);
            label2.TabIndex = 1;
            label2.Text = "IVA:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(152, 46);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Dock = DockStyle.Fill;
            subtotalLabel.Font = new Font("Segoe UI", 12F);
            subtotalLabel.Location = new Point(161, 0);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(162, 34);
            subtotalLabel.TabIndex = 3;
            subtotalLabel.Text = "label4";
            subtotalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // ivaLabel
            // 
            ivaLabel.AutoSize = true;
            ivaLabel.Dock = DockStyle.Bottom;
            ivaLabel.Font = new Font("Segoe UI", 12F);
            ivaLabel.Location = new Point(161, 47);
            ivaLabel.Name = "ivaLabel";
            ivaLabel.Size = new Size(162, 21);
            ivaLabel.TabIndex = 4;
            ivaLabel.Text = "label5";
            ivaLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Dock = DockStyle.Fill;
            totalLabel.Font = new Font("Segoe UI", 14F);
            totalLabel.Location = new Point(161, 68);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(162, 46);
            totalLabel.TabIndex = 5;
            totalLabel.Text = "label6";
            totalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(printButton);
            flowLayoutPanel1.Controls.Add(resetButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(755, 384);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(114, 114);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // printButton
            // 
            printButton.AutoSize = true;
            printButton.Location = new Point(3, 3);
            printButton.Name = "printButton";
            printButton.Size = new Size(111, 25);
            printButton.TabIndex = 0;
            printButton.Text = "Imprimir";
            printButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(3, 34);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(111, 23);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reiniciar";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 521);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Padding = new Padding(10);
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsSelectedGrid).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxSearch;
        private Button addButton;
        private DataGridView productsSelectedGrid;
        private Panel searchPanel;
        private ListBox productsSearchBox;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label subtotalLabel;
        private Label ivaLabel;
        private Label totalLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button printButton;
        private Button resetButton;
    }
}