using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Recipe_Manager
{
    partial class Recipe_Box : Control
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(string recipe, int recipeid)
        {
            Queries query = new Queries("localhost\\SQLEXPRESS", "Recipe Management");
            components = new System.ComponentModel.Container();
            

            GroupBox grpRecipeBox = new GroupBox();
            Label lblRecipe = new Label();
            PictureBox pictureBox1 = new PictureBox();
            StatusStrip statusStrip1 = new StatusStrip();
            ToolStripStatusLabel toolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripProgressBar tstripDifficulty = new ToolStripProgressBar();
            Label label1 = new Label();

            
            grpRecipeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            
            // grpRecipeBox
            // 
            grpRecipeBox.BackColor = Color.White;
            grpRecipeBox.Controls.Add(lblRecipe);
            grpRecipeBox.Controls.Add(pictureBox1);
            grpRecipeBox.Controls.Add(statusStrip1);
            grpRecipeBox.FlatStyle = FlatStyle.Flat;
            grpRecipeBox.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            grpRecipeBox.Location = new Point(7, 7);
            grpRecipeBox.Margin = new Padding(5);
            grpRecipeBox.Name = "grpRecipeBox" + recipeid;
            grpRecipeBox.Size = new Size(242, 240);
            grpRecipeBox.TabIndex = 0;
            grpRecipeBox.TabStop = false;
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.Location = new Point(93, 203);
            lblRecipe.Name = "lblRecipe" + recipeid;
            lblRecipe.Size = new Size(66, 22);
            lblRecipe.TabIndex = 1;
            lblRecipe.Text = $"{recipe}";
            // 
            // pictureBox1
            // 
            string grabimage = $"SELECT Image FROM Recipes WHERE Recipe_ID = {recipeid}";
            DataTable recipetable = query.ExecuteQuery(grabimage);
            byte[] imgData = (byte[])recipetable.Rows[0]["Image"];
            MemoryStream ms = new MemoryStream(imgData);
            Image recipeimg = Image.FromStream(ms);

            pictureBox1.Image = recipeimg;
            pictureBox1.Location = new Point(6, 40);
            pictureBox1.Name = "pictureBoxR" + recipeid;
            pictureBox1.Size = new Size(230, 147);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tstripDifficulty });
            statusStrip1.Location = new Point(13, 11);
            statusStrip1.Name = "statusStripR" + recipeid;
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(203, 24);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "Difficulty";

            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabelR" + recipeid;
            toolStripStatusLabel1.Size = new Size(84, 18);
            toolStripStatusLabel1.Text = "Difficulty: ";
            toolStripStatusLabel1.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // tstripDifficulty
            // 
            tstripDifficulty.BackColor = SystemColors.ControlLightLight;
            tstripDifficulty.Name = "tstripDifficultyR" + recipeid;
            tstripDifficulty.Size = new Size(100, 16);
            // 
        }

        #endregion
    }
}
