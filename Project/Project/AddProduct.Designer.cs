namespace Project
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.toppicture5 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.topusername5 = new Guna.UI.WinForms.GunaLabel();
            this.text = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.sabbir = new Guna.UI.WinForms.GunaTextBox();
            this.idtext = new Guna.UI.WinForms.GunaLabel();
            this.taken = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.qty = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.price = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.ProductPicture = new Guna.UI.WinForms.GunaPictureBox();
            this.BrowseImage = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cartpanel = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            this.cartpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppicture5
            // 
            this.toppicture5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(59)))));
            this.toppicture5.Image = ((System.Drawing.Image)(resources.GetObject("toppicture5.Image")));
            this.toppicture5.Location = new System.Drawing.Point(594, 2);
            this.toppicture5.Name = "toppicture5";
            this.toppicture5.Size = new System.Drawing.Size(30, 30);
            this.toppicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toppicture5.TabIndex = 85;
            this.toppicture5.TabStop = false;
            this.toppicture5.UseTransfarantBackground = false;
            this.toppicture5.Click += new System.EventHandler(this.toppicture5_Click);
            // 
            // topusername5
            // 
            this.topusername5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topusername5.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topusername5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.topusername5.Location = new System.Drawing.Point(652, 3);
            this.topusername5.Name = "topusername5";
            this.topusername5.Size = new System.Drawing.Size(97, 29);
            this.topusername5.TabIndex = 84;
            this.topusername5.Text = "Username";
            this.topusername5.Click += new System.EventHandler(this.topusername5_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.BaseColor = System.Drawing.Color.White;
            this.text.BorderColor = System.Drawing.Color.Silver;
            this.text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text.FocusedBaseColor = System.Drawing.Color.White;
            this.text.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.text.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text.Location = new System.Drawing.Point(270, 137);
            this.text.Name = "text";
            this.text.PasswordChar = '\0';
            this.text.Radius = 10;
            this.text.SelectedText = "";
            this.text.Size = new System.Drawing.Size(160, 30);
            this.text.TabIndex = 94;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(110, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel1.TabIndex = 95;
            this.gunaLabel1.Text = "Product Name";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(300, 411);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(87, 50);
            this.gunaButton1.TabIndex = 96;
            this.gunaButton1.Text = "Add";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // sabbir
            // 
            this.sabbir.BackColor = System.Drawing.Color.Transparent;
            this.sabbir.BaseColor = System.Drawing.Color.White;
            this.sabbir.BorderColor = System.Drawing.Color.Silver;
            this.sabbir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sabbir.FocusedBaseColor = System.Drawing.Color.White;
            this.sabbir.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sabbir.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.sabbir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sabbir.Location = new System.Drawing.Point(270, 173);
            this.sabbir.Name = "sabbir";
            this.sabbir.PasswordChar = '\0';
            this.sabbir.Radius = 10;
            this.sabbir.SelectedText = "";
            this.sabbir.Size = new System.Drawing.Size(160, 30);
            this.sabbir.TabIndex = 97;
            this.sabbir.TextChanged += new System.EventHandler(this.sabbir_TextChanged);
            // 
            // idtext
            // 
            this.idtext.AutoSize = true;
            this.idtext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idtext.Location = new System.Drawing.Point(110, 188);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(28, 15);
            this.idtext.TabIndex = 98;
            this.idtext.Text = "SKU";
            this.idtext.Click += new System.EventHandler(this.idtext_Click);
            // 
            // taken
            // 
            this.taken.AutoSize = true;
            this.taken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taken.Location = new System.Drawing.Point(447, 188);
            this.taken.Name = "taken";
            this.taken.Size = new System.Drawing.Size(125, 15);
            this.taken.TabIndex = 99;
            this.taken.Text = "***SKU already taken!!!";
            this.taken.Visible = false;
            this.taken.Click += new System.EventHandler(this.taken_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(458, 411);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(114, 50);
            this.gunaButton2.TabIndex = 100;
            this.gunaButton2.Text = "Back";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(113, 411);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(116, 50);
            this.gunaButton3.TabIndex = 101;
            this.gunaButton3.Text = "Exit";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.Color.Transparent;
            this.qty.BaseColor = System.Drawing.Color.White;
            this.qty.BorderColor = System.Drawing.Color.Silver;
            this.qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qty.FocusedBaseColor = System.Drawing.Color.White;
            this.qty.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.qty.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.qty.Location = new System.Drawing.Point(270, 209);
            this.qty.Name = "qty";
            this.qty.PasswordChar = '\0';
            this.qty.Radius = 10;
            this.qty.SelectedText = "";
            this.qty.Size = new System.Drawing.Size(160, 30);
            this.qty.TabIndex = 102;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(110, 224);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(53, 15);
            this.gunaLabel2.TabIndex = 103;
            this.gunaLabel2.Text = "Quantity";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.BaseColor = System.Drawing.Color.White;
            this.price.BorderColor = System.Drawing.Color.Silver;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.FocusedBaseColor = System.Drawing.Color.White;
            this.price.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price.Location = new System.Drawing.Point(270, 248);
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.Radius = 10;
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(160, 30);
            this.price.TabIndex = 104;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(110, 263);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(33, 15);
            this.gunaLabel3.TabIndex = 105;
            this.gunaLabel3.Text = "Price";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(110, 328);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel4.TabIndex = 108;
            this.gunaLabel4.Text = "Upload Image";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // ProductPicture
            // 
            this.ProductPicture.BaseColor = System.Drawing.Color.White;
            this.ProductPicture.Location = new System.Drawing.Point(270, 284);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.Size = new System.Drawing.Size(160, 93);
            this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPicture.TabIndex = 109;
            this.ProductPicture.TabStop = false;
            this.ProductPicture.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // BrowseImage
            // 
            this.BrowseImage.AnimationHoverSpeed = 0.07F;
            this.BrowseImage.AnimationSpeed = 0.03F;
            this.BrowseImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BrowseImage.BorderColor = System.Drawing.Color.Black;
            this.BrowseImage.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BrowseImage.CheckedBorderColor = System.Drawing.Color.Black;
            this.BrowseImage.CheckedForeColor = System.Drawing.Color.White;
            this.BrowseImage.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BrowseImage.CheckedImage")));
            this.BrowseImage.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BrowseImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseImage.FocusedColor = System.Drawing.Color.Empty;
            this.BrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrowseImage.ForeColor = System.Drawing.Color.White;
            this.BrowseImage.Image = ((System.Drawing.Image)(resources.GetObject("BrowseImage.Image")));
            this.BrowseImage.ImageSize = new System.Drawing.Size(20, 20);
            this.BrowseImage.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BrowseImage.Location = new System.Drawing.Point(449, 336);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BrowseImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BrowseImage.OnHoverForeColor = System.Drawing.Color.White;
            this.BrowseImage.OnHoverImage = null;
            this.BrowseImage.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BrowseImage.OnPressedColor = System.Drawing.Color.Black;
            this.BrowseImage.Size = new System.Drawing.Size(123, 41);
            this.BrowseImage.TabIndex = 110;
            this.BrowseImage.Text = "Browse ";
            this.BrowseImage.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // cartpanel
            // 
            this.cartpanel.Controls.Add(this.BrowseImage);
            this.cartpanel.Controls.Add(this.ProductPicture);
            this.cartpanel.Controls.Add(this.gunaLabel4);
            this.cartpanel.Controls.Add(this.gunaLabel3);
            this.cartpanel.Controls.Add(this.price);
            this.cartpanel.Controls.Add(this.gunaLabel2);
            this.cartpanel.Controls.Add(this.qty);
            this.cartpanel.Controls.Add(this.gunaButton3);
            this.cartpanel.Controls.Add(this.gunaButton2);
            this.cartpanel.Controls.Add(this.taken);
            this.cartpanel.Controls.Add(this.idtext);
            this.cartpanel.Controls.Add(this.sabbir);
            this.cartpanel.Controls.Add(this.gunaButton1);
            this.cartpanel.Controls.Add(this.gunaLabel1);
            this.cartpanel.Controls.Add(this.text);
            this.cartpanel.Controls.Add(this.topusername5);
            this.cartpanel.Controls.Add(this.toppicture5);
            this.cartpanel.Location = new System.Drawing.Point(12, -50);
            this.cartpanel.Name = "cartpanel";
            this.cartpanel.Size = new System.Drawing.Size(752, 550);
            this.cartpanel.TabIndex = 86;
            this.cartpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cartpanel_Paint);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 511);
            this.Controls.Add(this.cartpanel);
            this.Location = new System.Drawing.Point(258, 31);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            this.cartpanel.ResumeLayout(false);
            this.cartpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox toppicture5;
        private Guna.UI.WinForms.GunaLabel topusername5;
        private Guna.UI.WinForms.GunaTextBox text;
        protected internal Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox sabbir;
        protected internal Guna.UI.WinForms.GunaLabel idtext;
        protected internal Guna.UI.WinForms.GunaLabel taken;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaTextBox qty;
        protected internal Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox price;
        protected internal Guna.UI.WinForms.GunaLabel gunaLabel3;
        protected internal Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPictureBox ProductPicture;
        private Guna.UI.WinForms.GunaAdvenceButton BrowseImage;
        private Guna.UI.WinForms.GunaPanel cartpanel;
    }
}