namespace Recipe_Manager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            tstripCategories = new ToolStripMenuItem();
            favoritesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dataRecipes = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            viewIngredientsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataRecipes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, tstripCategories, favoritesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(896, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.AutoSize = false;
            adminToolStripMenuItem.BackColor = Color.White;
            adminToolStripMenuItem.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            adminToolStripMenuItem.Margin = new Padding(3);
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(102, 26);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // tstripCategories
            // 
            tstripCategories.BackColor = Color.White;
            tstripCategories.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tstripCategories.Margin = new Padding(3);
            tstripCategories.Name = "tstripCategories";
            tstripCategories.Size = new Size(116, 26);
            tstripCategories.Text = "Categories";
            // 
            // favoritesToolStripMenuItem
            // 
            favoritesToolStripMenuItem.BackColor = Color.White;
            favoritesToolStripMenuItem.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            favoritesToolStripMenuItem.Margin = new Padding(3);
            favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            favoritesToolStripMenuItem.Size = new Size(102, 26);
            favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 46);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 2;
            label1.Text = "Recipes";
            // 
            // dataRecipes
            // 
            dataRecipes.AllowUserToAddRows = false;
            dataRecipes.AllowUserToDeleteRows = false;
            dataRecipes.BackgroundColor = Color.White;
            dataRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRecipes.Location = new Point(45, 100);
            dataRecipes.Name = "dataRecipes";
            dataRecipes.ReadOnly = true;
            dataRecipes.RowHeadersWidth = 51;
            dataRecipes.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            dataRecipes.RowTemplate.Height = 29;
            dataRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataRecipes.Size = new Size(799, 338);
            dataRecipes.TabIndex = 3;
            dataRecipes.CellMouseDown += dataRecipes_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, viewIngredientsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(189, 52);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(188, 24);
            toolStripMenuItem1.Text = "View Recipe";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // viewIngredientsToolStripMenuItem
            // 
            viewIngredientsToolStripMenuItem.Name = "viewIngredientsToolStripMenuItem";
            viewIngredientsToolStripMenuItem.Size = new Size(188, 24);
            viewIngredientsToolStripMenuItem.Text = "View Ingredients";
            viewIngredientsToolStripMenuItem.Click += viewIngredientsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(896, 450);
            Controls.Add(dataRecipes);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataRecipes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem tstripCategories;
        private ToolStripMenuItem favoritesToolStripMenuItem;
        private Label label1;
        private DataGridView dataRecipes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem viewIngredientsToolStripMenuItem;
    }
}