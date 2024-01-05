namespace Recipe_Manager
{
    partial class AddRecipe
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            pbRecipePic = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbRecipePic).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(56, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 38);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 1;
            label1.Text = "Recipe Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 141);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(56, 278);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 235);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 5;
            label3.Text = "Difficulty";
            // 
            // pbRecipePic
            // 
            pbRecipePic.Location = new Point(56, 334);
            pbRecipePic.Name = "pbRecipePic";
            pbRecipePic.Size = new Size(151, 133);
            pbRecipePic.TabIndex = 7;
            pbRecipePic.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(197, 334);
            button1.Name = "button1";
            button1.Size = new Size(16, 133);
            button1.TabIndex = 8;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 571);
            Controls.Add(button1);
            Controls.Add(pbRecipePic);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AddRecipe";
            Text = "AddRecipe";
            ((System.ComponentModel.ISupportInitialize)pbRecipePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private PictureBox pbRecipePic;
        private Button button1;
    }
}