namespace SWENG421_Final_Project
{
    partial class CreatingFrame
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
            BuildButton1 = new Button();
            DesignButton1 = new Button();
            SearchButton1 = new Button();
            CategoryListBox1 = new ListBox();
            ColorListBox = new ListBox();
            CreatedProductListBox = new ListBox();
            CreateButton1 = new Button();
            AddButton1 = new Button();
            CartButton1 = new Button();
            ProductLabel = new Label();
            ColorLabel = new Label();
            SuspendLayout();
            // 
            // BuildButton1
            // 
            BuildButton1.Location = new Point(12, 12);
            BuildButton1.Name = "BuildButton1";
            BuildButton1.Size = new Size(88, 34);
            BuildButton1.TabIndex = 0;
            BuildButton1.Text = "Build";
            BuildButton1.UseVisualStyleBackColor = true;
            BuildButton1.Click += BuildButton1_Click;
            // 
            // DesignButton1
            // 
            DesignButton1.Location = new Point(106, 12);
            DesignButton1.Name = "DesignButton1";
            DesignButton1.Size = new Size(88, 34);
            DesignButton1.TabIndex = 1;
            DesignButton1.Text = "Design";
            DesignButton1.UseVisualStyleBackColor = true;
            DesignButton1.Click += DesignButton1_Click;
            // 
            // SearchButton1
            // 
            SearchButton1.Location = new Point(200, 12);
            SearchButton1.Name = "SearchButton1";
            SearchButton1.Size = new Size(88, 34);
            SearchButton1.TabIndex = 2;
            SearchButton1.Text = "Search";
            SearchButton1.UseVisualStyleBackColor = true;
            SearchButton1.Click += SearchButton1_Click;
            // 
            // CategoryListBox1
            // 
            CategoryListBox1.FormattingEnabled = true;
            CategoryListBox1.ItemHeight = 15;
            CategoryListBox1.Location = new Point(12, 68);
            CategoryListBox1.Name = "CategoryListBox1";
            CategoryListBox1.Size = new Size(194, 364);
            CategoryListBox1.TabIndex = 3;
            // 
            // ColorListBox
            // 
            ColorListBox.FormattingEnabled = true;
            ColorListBox.ItemHeight = 15;
            ColorListBox.Location = new Point(212, 68);
            ColorListBox.Name = "ColorListBox";
            ColorListBox.Size = new Size(194, 364);
            ColorListBox.TabIndex = 4;
            // 
            // CreatedProductListBox
            // 
            CreatedProductListBox.FormattingEnabled = true;
            CreatedProductListBox.ItemHeight = 15;
            CreatedProductListBox.Location = new Point(412, 233);
            CreatedProductListBox.Name = "CreatedProductListBox";
            CreatedProductListBox.Size = new Size(191, 199);
            CreatedProductListBox.TabIndex = 5;
            // 
            // CreateButton1
            // 
            CreateButton1.Location = new Point(412, 68);
            CreateButton1.Name = "CreateButton1";
            CreateButton1.Size = new Size(191, 73);
            CreateButton1.TabIndex = 6;
            CreateButton1.Text = "Create Product";
            CreateButton1.UseVisualStyleBackColor = true;
            CreateButton1.Click += CreateButton1_Click;
            // 
            // AddButton1
            // 
            AddButton1.Location = new Point(412, 147);
            AddButton1.Name = "AddButton1";
            AddButton1.Size = new Size(191, 73);
            AddButton1.TabIndex = 7;
            AddButton1.Text = "Add To Cart";
            AddButton1.UseVisualStyleBackColor = true;
            AddButton1.Click += AddButton1_Click;
            // 
            // CartButton1
            // 
            CartButton1.Location = new Point(507, 12);
            CartButton1.Name = "CartButton1";
            CartButton1.Size = new Size(96, 34);
            CartButton1.TabIndex = 8;
            CartButton1.Text = "Cart";
            CartButton1.UseVisualStyleBackColor = true;
            CartButton1.Click += CartButton1_Click;
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Location = new Point(12, 49);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(54, 15);
            ProductLabel.TabIndex = 9;
            ProductLabel.Text = "Products";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(212, 50);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(41, 15);
            ColorLabel.TabIndex = 10;
            ColorLabel.Text = "Colors";
            // 
            // CreatingFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(618, 442);
            Controls.Add(ColorLabel);
            Controls.Add(ProductLabel);
            Controls.Add(CartButton1);
            Controls.Add(AddButton1);
            Controls.Add(CreateButton1);
            Controls.Add(CreatedProductListBox);
            Controls.Add(ColorListBox);
            Controls.Add(CategoryListBox1);
            Controls.Add(SearchButton1);
            Controls.Add(DesignButton1);
            Controls.Add(BuildButton1);
            MaximumSize = new Size(634, 481);
            MinimumSize = new Size(634, 481);
            Name = "CreatingFrame";
            Text = "Creating";
            Load += CreatingFrame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BuildButton1;
        private Button DesignButton1;
        private Button SearchButton1;
        private ListBox CategoryListBox1;
        private ListBox ColorListBox;
        private ListBox CreatedProductListBox;
        private Button CreateButton1;
        private Button AddButton1;
        private Button CartButton1;
        private Label ProductLabel;
        private Label ColorLabel;
    }
}
