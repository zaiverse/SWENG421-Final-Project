namespace SWENG421_Final_Project
{
    partial class DesigningFrame
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
            CartButton2 = new Button();
            AddButton2 = new Button();
            AddDesignButton = new Button();
            CreatedProductListBox2 = new ListBox();
            DesignListBox = new ListBox();
            CategoryListBox2 = new ListBox();
            SearchButton2 = new Button();
            DesignButton2 = new Button();
            BuildButton2 = new Button();
            label1 = new Label();
            DesignsLabel = new Label();
            SuspendLayout();
            // 
            // CartButton2
            // 
            CartButton2.Location = new Point(510, 10);
            CartButton2.Name = "CartButton2";
            CartButton2.Size = new Size(96, 34);
            CartButton2.TabIndex = 17;
            CartButton2.Text = "Cart";
            CartButton2.UseVisualStyleBackColor = true;
            CartButton2.Click += CartButton2_Click;
            // 
            // AddButton2
            // 
            AddButton2.Location = new Point(415, 145);
            AddButton2.Name = "AddButton2";
            AddButton2.Size = new Size(191, 73);
            AddButton2.TabIndex = 16;
            AddButton2.Text = "Add To Cart";
            AddButton2.UseVisualStyleBackColor = true;
            AddButton2.Click += AddButton2_Click;
            // 
            // AddDesignButton
            // 
            AddDesignButton.Location = new Point(415, 66);
            AddDesignButton.Name = "AddDesignButton";
            AddDesignButton.Size = new Size(191, 73);
            AddDesignButton.TabIndex = 15;
            AddDesignButton.Text = "Add Design";
            AddDesignButton.UseVisualStyleBackColor = true;
            AddDesignButton.Click += AddDesignButton_Click;
            // 
            // CreatedProductListBox2
            // 
            CreatedProductListBox2.FormattingEnabled = true;
            CreatedProductListBox2.ItemHeight = 15;
            CreatedProductListBox2.Location = new Point(415, 231);
            CreatedProductListBox2.Name = "CreatedProductListBox2";
            CreatedProductListBox2.Size = new Size(191, 199);
            CreatedProductListBox2.TabIndex = 14;
            // 
            // DesignListBox
            // 
            DesignListBox.FormattingEnabled = true;
            DesignListBox.ItemHeight = 15;
            DesignListBox.Location = new Point(215, 66);
            DesignListBox.Name = "DesignListBox";
            DesignListBox.Size = new Size(194, 364);
            DesignListBox.TabIndex = 13;
            // 
            // CategoryListBox2
            // 
            CategoryListBox2.FormattingEnabled = true;
            CategoryListBox2.ItemHeight = 15;
            CategoryListBox2.Location = new Point(15, 66);
            CategoryListBox2.Name = "CategoryListBox2";
            CategoryListBox2.Size = new Size(194, 364);
            CategoryListBox2.TabIndex = 12;
            // 
            // SearchButton2
            // 
            SearchButton2.Location = new Point(203, 10);
            SearchButton2.Name = "SearchButton2";
            SearchButton2.Size = new Size(88, 34);
            SearchButton2.TabIndex = 11;
            SearchButton2.Text = "Search";
            SearchButton2.UseVisualStyleBackColor = true;
            SearchButton2.Click += SearchButton2_Click;
            // 
            // DesignButton2
            // 
            DesignButton2.Location = new Point(109, 10);
            DesignButton2.Name = "DesignButton2";
            DesignButton2.Size = new Size(88, 34);
            DesignButton2.TabIndex = 10;
            DesignButton2.Text = "Design";
            DesignButton2.UseVisualStyleBackColor = true;
            DesignButton2.Click += DesignButton2_Click;
            // 
            // BuildButton2
            // 
            BuildButton2.Location = new Point(15, 10);
            BuildButton2.Name = "BuildButton2";
            BuildButton2.Size = new Size(88, 34);
            BuildButton2.TabIndex = 9;
            BuildButton2.Text = "Build";
            BuildButton2.UseVisualStyleBackColor = true;
            BuildButton2.Click += BuildButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Products";
            // 
            // DesignsLabel
            // 
            DesignsLabel.AutoSize = true;
            DesignsLabel.Location = new Point(215, 48);
            DesignsLabel.Name = "DesignsLabel";
            DesignsLabel.Size = new Size(48, 15);
            DesignsLabel.TabIndex = 11;
            DesignsLabel.Text = "Designs";
            // 
            // DesigningFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 442);
            Controls.Add(DesignsLabel);
            Controls.Add(label1);
            Controls.Add(CartButton2);
            Controls.Add(AddButton2);
            Controls.Add(AddDesignButton);
            Controls.Add(CreatedProductListBox2);
            Controls.Add(DesignListBox);
            Controls.Add(CategoryListBox2);
            Controls.Add(SearchButton2);
            Controls.Add(DesignButton2);
            Controls.Add(BuildButton2);
            MaximumSize = new Size(634, 481);
            MinimumSize = new Size(634, 481);
            Name = "DesigningFrame";
            Text = "Designing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CartButton2;
        private Button AddButton2;
        private Button AddDesignButton;
        private ListBox CreatedProductListBox2;
        private ListBox DesignListBox;
        private ListBox CategoryListBox2;
        private Button SearchButton2;
        private Button DesignButton2;
        private Button BuildButton2;
        private Label label1;
        private Label DesignsLabel;
    }
}