namespace Project
{
    partial class Product
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.available = new Guna.UI.WinForms.GunaLabel();
            this.buy = new Guna.UI.WinForms.GunaGradientButton();
            this.quantity = new Guna.UI.WinForms.GunaNumeric();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.title = new Guna.UI.WinForms.GunaLabel();
            this.price = new Guna.UI.WinForms.GunaLabel();
            this.Cart = new Guna.UI.WinForms.GunaGradientButton();
            this.productpicture = new Guna.UI.WinForms.GunaPictureBox();
            this.target = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // available
            // 
            this.available.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.available.AutoEllipsis = true;
            this.available.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.available.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.available.Location = new System.Drawing.Point(4, 113);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(146, 19);
            this.available.TabIndex = 83;
            this.available.Text = "Available 10";
            // 
            // buy
            // 
            this.buy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buy.AnimationHoverSpeed = 0.07F;
            this.buy.AnimationSpeed = 0.03F;
            this.buy.BackColor = System.Drawing.Color.Transparent;
            this.buy.BaseColor1 = System.Drawing.Color.Transparent;
            this.buy.BaseColor2 = System.Drawing.Color.Transparent;
            this.buy.BorderColor = System.Drawing.Color.Gray;
            this.buy.BorderSize = 2;
            this.buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buy.FocusedColor = System.Drawing.Color.Empty;
            this.buy.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Image = null;
            this.buy.ImageSize = new System.Drawing.Size(25, 25);
            this.buy.Location = new System.Drawing.Point(366, 78);
            this.buy.Name = "buy";
            this.buy.OnHoverBaseColor1 = System.Drawing.Color.SlateBlue;
            this.buy.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.buy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buy.OnHoverForeColor = System.Drawing.Color.White;
            this.buy.OnHoverImage = null;
            this.buy.OnPressedColor = System.Drawing.Color.Black;
            this.buy.Radius = 10;
            this.buy.Size = new System.Drawing.Size(81, 32);
            this.buy.TabIndex = 84;
            this.buy.Text = "Buy";
            this.buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buy.TextOffsetX = 20;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.quantity.BorderColor = System.Drawing.Color.White;
            this.quantity.BorderSize = 2;
            this.quantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.quantity.ButtonForeColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.quantity.Location = new System.Drawing.Point(454, 37);
            this.quantity.Maximum = ((long)(9999999));
            this.quantity.Minimum = ((long)(1));
            this.quantity.Name = "quantity";
            this.quantity.Radius = 10;
            this.quantity.Size = new System.Drawing.Size(81, 30);
            this.quantity.TabIndex = 88;
            this.quantity.Text = "gunaNumeric1";
            this.quantity.Value = ((long)(1));
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel1.Location = new System.Drawing.Point(373, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 19);
            this.gunaLabel1.TabIndex = 89;
            this.gunaLabel1.Text = "Quantity";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.title.AutoEllipsis = true;
            this.title.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.title.Location = new System.Drawing.Point(117, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(232, 27);
            this.title.TabIndex = 90;
            this.title.Text = "Title";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.price.AutoEllipsis = true;
            this.price.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.price.Location = new System.Drawing.Point(118, 78);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(231, 19);
            this.price.TabIndex = 91;
            this.price.Text = "Price";
            // 
            // Cart
            // 
            this.Cart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Cart.AnimationHoverSpeed = 0.07F;
            this.Cart.AnimationSpeed = 0.03F;
            this.Cart.BackColor = System.Drawing.Color.Transparent;
            this.Cart.BaseColor1 = System.Drawing.Color.Transparent;
            this.Cart.BaseColor2 = System.Drawing.Color.Transparent;
            this.Cart.BorderColor = System.Drawing.Color.Gray;
            this.Cart.BorderSize = 2;
            this.Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Cart.FocusedColor = System.Drawing.Color.Empty;
            this.Cart.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart.ForeColor = System.Drawing.Color.White;
            this.Cart.Image = ((System.Drawing.Image)(resources.GetObject("Cart.Image")));
            this.Cart.ImageSize = new System.Drawing.Size(22, 22);
            this.Cart.Location = new System.Drawing.Point(454, 78);
            this.Cart.Name = "Cart";
            this.Cart.OnHoverBaseColor1 = System.Drawing.Color.SlateBlue;
            this.Cart.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Cart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Cart.OnHoverForeColor = System.Drawing.Color.White;
            this.Cart.OnHoverImage = null;
            this.Cart.OnPressedColor = System.Drawing.Color.Black;
            this.Cart.Radius = 10;
            this.Cart.Size = new System.Drawing.Size(81, 32);
            this.Cart.TabIndex = 87;
            this.Cart.Text = "Cart";
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // productpicture
            // 
            this.productpicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productpicture.BaseColor = System.Drawing.Color.White;
            this.productpicture.Image = ((System.Drawing.Image)(resources.GetObject("productpicture.Image")));
            this.productpicture.Location = new System.Drawing.Point(3, 13);
            this.productpicture.Name = "productpicture";
            this.productpicture.Size = new System.Drawing.Size(109, 97);
            this.productpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productpicture.TabIndex = 0;
            this.productpicture.TabStop = false;
            // 
            // target
            // 
            this.target.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.target.AutoSize = true;
            this.target.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.target.Location = new System.Drawing.Point(246, 127);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(53, 19);
            this.target.TabIndex = 92;
            this.target.Text = "target";
            this.target.Visible = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.target);
            this.Controls.Add(this.price);
            this.Controls.Add(this.title);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.available);
            this.Controls.Add(this.productpicture);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(538, 148);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox productpicture;
        private Guna.UI.WinForms.GunaLabel available;
        private Guna.UI.WinForms.GunaGradientButton buy;
        private Guna.UI.WinForms.GunaGradientButton Cart;
        private Guna.UI.WinForms.GunaNumeric quantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel title;
        private Guna.UI.WinForms.GunaLabel price;
        private Guna.UI.WinForms.GunaLabel target;
    }
}
