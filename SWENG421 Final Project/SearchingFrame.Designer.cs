namespace SWENG421_Final_Project
{
    partial class SearchingFrame
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
            CartButton3 = new Button();
            AddButton3 = new Button();
            CategoryListBox3 = new ListBox();
            SearchButton3 = new Button();
            DesignButton3 = new Button();
            BuildButton3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SearchByLabel = new Label();
            SubCategoryLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // CartButton3
            // 
            CartButton3.Location = new Point(509, 11);
            CartButton3.Name = "CartButton3";
            CartButton3.Size = new Size(96, 34);
            CartButton3.TabIndex = 26;
            CartButton3.Text = "Cart";
            CartButton3.UseVisualStyleBackColor = true;
            CartButton3.Click += CartButton3_Click;
            // 
            // AddButton3
            // 
            AddButton3.Location = new Point(363, 327);
            AddButton3.Name = "AddButton3";
            AddButton3.Size = new Size(191, 73);
            AddButton3.TabIndex = 25;
            AddButton3.Text = "Add To Cart";
            AddButton3.UseVisualStyleBackColor = true;
            // 
            // CategoryListBox3
            // 
            CategoryListBox3.FormattingEnabled = true;
            CategoryListBox3.ItemHeight = 15;
            CategoryListBox3.Location = new Point(14, 67);
            CategoryListBox3.Name = "CategoryListBox3";
            CategoryListBox3.Size = new Size(276, 364);
            CategoryListBox3.TabIndex = 21;
            // 
            // SearchButton3
            // 
            SearchButton3.Location = new Point(202, 11);
            SearchButton3.Name = "SearchButton3";
            SearchButton3.Size = new Size(88, 34);
            SearchButton3.TabIndex = 20;
            SearchButton3.Text = "Search";
            SearchButton3.UseVisualStyleBackColor = true;
            SearchButton3.Click += SearchButton3_Click;
            // 
            // DesignButton3
            // 
            DesignButton3.Location = new Point(108, 11);
            DesignButton3.Name = "DesignButton3";
            DesignButton3.Size = new Size(88, 34);
            DesignButton3.TabIndex = 19;
            DesignButton3.Text = "Design";
            DesignButton3.UseVisualStyleBackColor = true;
            DesignButton3.Click += DesignButton3_Click;
            // 
            // BuildButton3
            // 
            BuildButton3.Location = new Point(14, 11);
            BuildButton3.Name = "BuildButton3";
            BuildButton3.Size = new Size(88, 34);
            BuildButton3.TabIndex = 18;
            BuildButton3.Text = "Build";
            BuildButton3.UseVisualStyleBackColor = true;
            BuildButton3.Click += BuildButton3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(377, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(377, 219);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 23);
            comboBox2.TabIndex = 28;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // SearchByLabel
            // 
            SearchByLabel.AutoSize = true;
            SearchByLabel.Location = new Point(377, 131);
            SearchByLabel.Name = "SearchByLabel";
            SearchByLabel.Size = new Size(61, 15);
            SearchByLabel.TabIndex = 29;
            SearchByLabel.Text = "Search By:";
            // 
            // SubCategoryLabel
            // 
            SubCategoryLabel.AutoSize = true;
            SubCategoryLabel.Location = new Point(377, 201);
            SubCategoryLabel.Name = "SubCategoryLabel";
            SubCategoryLabel.Size = new Size(76, 15);
            SubCategoryLabel.TabIndex = 30;
            SubCategoryLabel.Text = "Subcategory:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Products";
            // 
            // SearchingFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 442);
            Controls.Add(label1);
            Controls.Add(SubCategoryLabel);
            Controls.Add(SearchByLabel);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(CartButton3);
            Controls.Add(AddButton3);
            Controls.Add(CategoryListBox3);
            Controls.Add(SearchButton3);
            Controls.Add(DesignButton3);
            Controls.Add(BuildButton3);
            MaximumSize = new Size(634, 481);
            MinimumSize = new Size(634, 481);
            Name = "SearchingFrame";
            Text = "Searching";
            Load += SearchingFrame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CartButton3;
        private Button AddButton3;
        private ListBox CategoryListBox3;
        private Button SearchButton3;
        private Button DesignButton3;
        private Button BuildButton3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label SearchByLabel;
        private Label SubCategoryLabel;
        private Label label1;
    }
}