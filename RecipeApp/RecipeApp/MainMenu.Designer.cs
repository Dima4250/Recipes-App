namespace RecipeApp
{
    partial class MainMenu
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
            AddRecipeMenuBtn = new Button();
            RecipeList = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // AddRecipeMenuBtn
            // 
            AddRecipeMenuBtn.Location = new Point(648, 61);
            AddRecipeMenuBtn.Name = "AddRecipeMenuBtn";
            AddRecipeMenuBtn.Size = new Size(140, 57);
            AddRecipeMenuBtn.TabIndex = 0;
            AddRecipeMenuBtn.Text = "Добавить рецепт";
            AddRecipeMenuBtn.UseVisualStyleBackColor = true;
            AddRecipeMenuBtn.Click += button1_Click;
            // 
            // RecipeList
            // 
            RecipeList.BackColor = SystemColors.ButtonHighlight;
            RecipeList.FormattingEnabled = true;
            RecipeList.ItemHeight = 15;
            RecipeList.Location = new Point(169, 329);
            RecipeList.Name = "RecipeList";
            RecipeList.Size = new Size(432, 109);
            RecipeList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(266, 12);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 2;
            label1.Text = "Менеджер рецептов";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(315, 23);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 136);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 183);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 234);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(RecipeList);
            Controls.Add(AddRecipeMenuBtn);
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddRecipeMenuBtn;
        private ListBox RecipeList;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
