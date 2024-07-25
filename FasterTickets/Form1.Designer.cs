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
            components = new System.ComponentModel.Container();
            menuTab = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            CreateTicketButtonMenu = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuTab.SuspendLayout();
            SuspendLayout();
            // 
            // menuTab
            // 
            menuTab.BackColor = SystemColors.ControlDarkDark;
            menuTab.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, CreateTicketButtonMenu, productosToolStripMenuItem });
            menuTab.Location = new Point(0, 0);
            menuTab.Name = "menuTab";
            menuTab.Size = new Size(998, 24);
            menuTab.TabIndex = 15;
            menuTab.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inicioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(49, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // CreateTicketButtonMenu
            // 
            CreateTicketButtonMenu.ForeColor = SystemColors.ControlLightLight;
            CreateTicketButtonMenu.Name = "CreateTicketButtonMenu";
            CreateTicketButtonMenu.Size = new Size(81, 20);
            CreateTicketButtonMenu.Text = "Crear Ticket";
            CreateTicketButtonMenu.Click += CreateTicketButtonMenu_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(998, 551);
            Controls.Add(menuTab);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuTab;
            Name = "Form1";
            Text = "Form1";
            menuTab.ResumeLayout(false);
            menuTab.PerformLayout();
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
        private MenuStrip menuTab;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem CreateTicketButtonMenu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
    }
}
