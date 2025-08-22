namespace SWENG421_Final_Project
{
    partial class PayingFrame
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
            CartButton4 = new Button();
            CartListBox = new ListBox();
            SearchButton4 = new Button();
            DesignButton4 = new Button();
            BuildButton4 = new Button();
            RemoveAllButton = new Button();
            CheckoutButton = new Button();
            TotalPriceText = new Label();
            PriceLabel = new Label();
            CreatedItemsLabel = new Label();
            SuspendLayout();
            // 
            // CartButton4
            // 
            CartButton4.Location = new Point(509, 11);
            CartButton4.Name = "CartButton4";
            CartButton4.Size = new Size(96, 34);
            CartButton4.TabIndex = 36;
            CartButton4.Text = "Cart";
            CartButton4.UseVisualStyleBackColor = true;
            CartButton4.Click += CartButton4_Click;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(14, 67);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(591, 289);
            CartListBox.TabIndex = 34;
            // 
            // SearchButton4
            // 
            SearchButton4.Location = new Point(202, 11);
            SearchButton4.Name = "SearchButton4";
            SearchButton4.Size = new Size(88, 34);
            SearchButton4.TabIndex = 33;
            SearchButton4.Text = "Search";
            SearchButton4.UseVisualStyleBackColor = true;
            SearchButton4.Click += SearchButton4_Click;
            // 
            // DesignButton4
            // 
            DesignButton4.Location = new Point(108, 11);
            DesignButton4.Name = "DesignButton4";
            DesignButton4.Size = new Size(88, 34);
            DesignButton4.TabIndex = 32;
            DesignButton4.Text = "Design";
            DesignButton4.UseVisualStyleBackColor = true;
            DesignButton4.Click += DesignButton4_Click;
            // 
            // BuildButton4
            // 
            BuildButton4.Location = new Point(14, 11);
            BuildButton4.Name = "BuildButton4";
            BuildButton4.Size = new Size(88, 34);
            BuildButton4.TabIndex = 31;
            BuildButton4.Text = "Build";
            BuildButton4.UseVisualStyleBackColor = true;
            BuildButton4.Click += BuildButton4_Click;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Location = new Point(14, 373);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(182, 57);
            RemoveAllButton.TabIndex = 37;
            RemoveAllButton.Text = "RemoveAll";
            RemoveAllButton.UseVisualStyleBackColor = true;
            // 
            // CheckoutButton
            // 
            CheckoutButton.Location = new Point(424, 373);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(182, 57);
            CheckoutButton.TabIndex = 38;
            CheckoutButton.Text = "Checkout";
            CheckoutButton.UseVisualStyleBackColor = true;
            // 
            // TotalPriceText
            // 
            TotalPriceText.AutoSize = true;
            TotalPriceText.Location = new Point(238, 394);
            TotalPriceText.Name = "TotalPriceText";
            TotalPriceText.Size = new Size(73, 15);
            TotalPriceText.TabIndex = 39;
            TotalPriceText.Text = "Total Price: $";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(313, 395);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(0, 15);
            PriceLabel.TabIndex = 40;
            // 
            // CreatedItemsLabel
            // 
            CreatedItemsLabel.AutoSize = true;
            CreatedItemsLabel.Location = new Point(14, 48);
            CreatedItemsLabel.Name = "CreatedItemsLabel";
            CreatedItemsLabel.Size = new Size(98, 15);
            CreatedItemsLabel.TabIndex = 18;
            CreatedItemsLabel.Text = "Created Products";
            // 
            // PayingFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 442);
            Controls.Add(CreatedItemsLabel);
            Controls.Add(PriceLabel);
            Controls.Add(TotalPriceText);
            Controls.Add(CheckoutButton);
            Controls.Add(RemoveAllButton);
            Controls.Add(CartButton4);
            Controls.Add(CartListBox);
            Controls.Add(SearchButton4);
            Controls.Add(DesignButton4);
            Controls.Add(BuildButton4);
            MaximumSize = new Size(634, 481);
            MinimumSize = new Size(634, 481);
            Name = "PayingFrame";
            Text = "Paying";
            Load += PayingFrame_Load;
            VisibleChanged += PayingFrame_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CartButton4;
        private ListBox CartListBox;
        private Button SearchButton4;
        private Button DesignButton4;
        private Button BuildButton4;
        private Button RemoveAllButton;
        private Button CheckoutButton;
        private Label TotalPriceText;
        private Label PriceLabel;
        private Label CreatedItemsLabel;
    }
}