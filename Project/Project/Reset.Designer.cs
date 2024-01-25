namespace Project
{
    partial class Reset
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.textbox = new Guna.UI.WinForms.GunaTextBox();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.found = new Guna.UI.WinForms.GunaLabel();
            this.userlabel = new Guna.UI.WinForms.GunaLabel();
            this.emailsent = new Guna.UI.WinForms.GunaLabel();
            this.sent = new Guna.UI.WinForms.GunaLabel();
            this.confirmtext1 = new Guna.UI.WinForms.GunaTextBox();
            this.minimumCharacter = new Guna.UI.WinForms.GunaLabel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.hideButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.showButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.confirmbutton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.next = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.backButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox.BackColor = System.Drawing.Color.Transparent;
            this.textbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.textbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.textbox.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.textbox.FocusedForeColor = System.Drawing.SystemColors.ControlLight;
            this.textbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textbox.Location = new System.Drawing.Point(52, 219);
            this.textbox.Name = "textbox";
            this.textbox.PasswordChar = '\0';
            this.textbox.Radius = 10;
            this.textbox.SelectedText = "";
            this.textbox.Size = new System.Drawing.Size(216, 34);
            this.textbox.TabIndex = 43;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label.Location = new System.Drawing.Point(55, 191);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 28);
            this.label.TabIndex = 45;
            this.label.Text = "Username";
            // 
            // found
            // 
            this.found.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.found.AutoSize = true;
            this.found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.found.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.found.ForeColor = System.Drawing.Color.IndianRed;
            this.found.Location = new System.Drawing.Point(57, 257);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(115, 15);
            this.found.TabIndex = 46;
            this.found.Text = "Username not found";
            this.found.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.found.Visible = false;
            // 
            // userlabel
            // 
            this.userlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userlabel.AutoSize = true;
            this.userlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.userlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.IndianRed;
            this.userlabel.Location = new System.Drawing.Point(57, 257);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(122, 15);
            this.userlabel.TabIndex = 47;
            this.userlabel.Text = "Enter your username";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userlabel.Visible = false;
            // 
            // emailsent
            // 
            this.emailsent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailsent.AutoSize = true;
            this.emailsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.emailsent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsent.ForeColor = System.Drawing.Color.Gray;
            this.emailsent.Location = new System.Drawing.Point(110, 257);
            this.emailsent.Name = "emailsent";
            this.emailsent.Size = new System.Drawing.Size(98, 15);
            this.emailsent.TabIndex = 49;
            this.emailsent.Text = "An email sent to ";
            this.emailsent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.emailsent.Visible = false;
            // 
            // sent
            // 
            this.sent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sent.AutoSize = true;
            this.sent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.sent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sent.ForeColor = System.Drawing.Color.Gray;
            this.sent.Location = new System.Drawing.Point(74, 278);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(98, 15);
            this.sent.TabIndex = 50;
            this.sent.Text = "An email sent to ";
            this.sent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sent.Visible = false;
            // 
            // confirmtext1
            // 
            this.confirmtext1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmtext1.BackColor = System.Drawing.Color.Transparent;
            this.confirmtext1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.confirmtext1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmtext1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmtext1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.confirmtext1.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.confirmtext1.FocusedForeColor = System.Drawing.SystemColors.ControlLight;
            this.confirmtext1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtext1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.confirmtext1.Location = new System.Drawing.Point(52, 220);
            this.confirmtext1.Name = "confirmtext1";
            this.confirmtext1.PasswordChar = '\0';
            this.confirmtext1.Radius = 10;
            this.confirmtext1.SelectedText = "";
            this.confirmtext1.Size = new System.Drawing.Size(216, 34);
            this.confirmtext1.TabIndex = 53;
            this.confirmtext1.Visible = false;
            this.confirmtext1.TextChanged += new System.EventHandler(this.confirmtext1_TextChanged);
            // 
            // minimumCharacter
            // 
            this.minimumCharacter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimumCharacter.AutoSize = true;
            this.minimumCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.minimumCharacter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumCharacter.ForeColor = System.Drawing.Color.IndianRed;
            this.minimumCharacter.Location = new System.Drawing.Point(57, 258);
            this.minimumCharacter.Name = "minimumCharacter";
            this.minimumCharacter.Size = new System.Drawing.Size(147, 14);
            this.minimumCharacter.TabIndex = 54;
            this.minimumCharacter.Text = "Minimum 6 characters";
            this.minimumCharacter.Visible = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPanel1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(46)))), ((int)(((byte)(117)))));
            this.gunaPanel1.Controls.Add(this.gunaControlBox3);
            this.gunaPanel1.Controls.Add(this.gunaControlBox2);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(879, 25);
            this.gunaPanel1.TabIndex = 62;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Silver;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(823, 3);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(20, 20);
            this.gunaControlBox3.TabIndex = 44;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Silver;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(796, 3);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(20, 20);
            this.gunaControlBox2.TabIndex = 43;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Silver;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(850, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(20, 20);
            this.gunaControlBox1.TabIndex = 42;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Controls.Add(this.label);
            this.gunaLinePanel1.Controls.Add(this.button);
            this.gunaLinePanel1.Controls.Add(this.confirmtext1);
            this.gunaLinePanel1.Controls.Add(this.userlabel);
            this.gunaLinePanel1.Controls.Add(this.hideButton);
            this.gunaLinePanel1.Controls.Add(this.showButton);
            this.gunaLinePanel1.Controls.Add(this.found);
            this.gunaLinePanel1.Controls.Add(this.textbox);
            this.gunaLinePanel1.Controls.Add(this.minimumCharacter);
            this.gunaLinePanel1.Controls.Add(this.confirmbutton);
            this.gunaLinePanel1.Controls.Add(this.emailsent);
            this.gunaLinePanel1.Controls.Add(this.sent);
            this.gunaLinePanel1.Controls.Add(this.next);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLinePanel1.LineLeft = 2;
            this.gunaLinePanel1.LineRight = 2;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 2;
            this.gunaLinePanel1.Location = new System.Drawing.Point(288, 121);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(315, 333);
            this.gunaLinePanel1.TabIndex = 61;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel1.Location = new System.Drawing.Point(127, 68);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 42);
            this.gunaLabel1.TabIndex = 63;
            this.gunaLabel1.Text = "Reset";
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.AnimationHoverSpeed = 0.07F;
            this.button.AnimationSpeed = 0.03F;
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.button.BorderColor = System.Drawing.Color.Black;
            this.button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.button.CheckedBorderColor = System.Drawing.Color.Black;
            this.button.CheckedForeColor = System.Drawing.Color.White;
            this.button.CheckedImage = ((System.Drawing.Image)(resources.GetObject("button.CheckedImage")));
            this.button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button.FocusedColor = System.Drawing.Color.Empty;
            this.button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Image = null;
            this.button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button.ImageSize = new System.Drawing.Size(20, 20);
            this.button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button.Location = new System.Drawing.Point(95, 275);
            this.button.Name = "button";
            this.button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button.OnHoverForeColor = System.Drawing.Color.White;
            this.button.OnHoverImage = null;
            this.button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.button.OnPressedColor = System.Drawing.Color.Black;
            this.button.Radius = 10;
            this.button.Size = new System.Drawing.Size(122, 31);
            this.button.TabIndex = 44;
            this.button.Text = "Search";
            this.button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // hideButton
            // 
            this.hideButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hideButton.AnimationHoverSpeed = 0.07F;
            this.hideButton.AnimationSpeed = 0.03F;
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.BaseColor = System.Drawing.Color.Transparent;
            this.hideButton.BorderColor = System.Drawing.Color.Transparent;
            this.hideButton.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.hideButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.hideButton.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hideButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("hideButton.CheckedImage")));
            this.hideButton.CheckedLineColor = System.Drawing.Color.Transparent;
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hideButton.FocusedColor = System.Drawing.Color.Empty;
            this.hideButton.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.ForeColor = System.Drawing.Color.DimGray;
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.ImageSize = new System.Drawing.Size(16, 18);
            this.hideButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.hideButton.Location = new System.Drawing.Point(229, 226);
            this.hideButton.Name = "hideButton";
            this.hideButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.hideButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.hideButton.OnHoverForeColor = System.Drawing.Color.MidnightBlue;
            this.hideButton.OnHoverImage = null;
            this.hideButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.hideButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.hideButton.Radius = 10;
            this.hideButton.Size = new System.Drawing.Size(31, 25);
            this.hideButton.TabIndex = 55;
            this.hideButton.Visible = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // showButton
            // 
            this.showButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showButton.AnimationHoverSpeed = 0.07F;
            this.showButton.AnimationSpeed = 0.03F;
            this.showButton.BackColor = System.Drawing.Color.Transparent;
            this.showButton.BaseColor = System.Drawing.SystemColors.ControlLightLight;
            this.showButton.BorderColor = System.Drawing.Color.Transparent;
            this.showButton.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.showButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.showButton.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("showButton.CheckedImage")));
            this.showButton.CheckedLineColor = System.Drawing.Color.Transparent;
            this.showButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.showButton.FocusedColor = System.Drawing.Color.Empty;
            this.showButton.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.Color.DimGray;
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.ImageSize = new System.Drawing.Size(15, 18);
            this.showButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.showButton.Location = new System.Drawing.Point(229, 226);
            this.showButton.Name = "showButton";
            this.showButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.showButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.showButton.OnHoverForeColor = System.Drawing.Color.MidnightBlue;
            this.showButton.OnHoverImage = null;
            this.showButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.showButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.showButton.Radius = 10;
            this.showButton.Size = new System.Drawing.Size(32, 26);
            this.showButton.TabIndex = 56;
            this.showButton.Visible = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmbutton.AnimationHoverSpeed = 0.07F;
            this.confirmbutton.AnimationSpeed = 0.03F;
            this.confirmbutton.BackColor = System.Drawing.Color.Transparent;
            this.confirmbutton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.confirmbutton.BorderColor = System.Drawing.Color.Black;
            this.confirmbutton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.confirmbutton.CheckedBorderColor = System.Drawing.Color.Black;
            this.confirmbutton.CheckedForeColor = System.Drawing.Color.White;
            this.confirmbutton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("confirmbutton.CheckedImage")));
            this.confirmbutton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.confirmbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirmbutton.FocusedColor = System.Drawing.Color.Empty;
            this.confirmbutton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.ForeColor = System.Drawing.Color.White;
            this.confirmbutton.Image = null;
            this.confirmbutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutton.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmbutton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutton.Location = new System.Drawing.Point(95, 275);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.confirmbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirmbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmbutton.OnHoverImage = null;
            this.confirmbutton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmbutton.OnPressedColor = System.Drawing.Color.Black;
            this.confirmbutton.Radius = 10;
            this.confirmbutton.Size = new System.Drawing.Size(122, 31);
            this.confirmbutton.TabIndex = 51;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmbutton.Visible = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next.AnimationHoverSpeed = 0.07F;
            this.next.AnimationSpeed = 0.03F;
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.next.BorderColor = System.Drawing.Color.Black;
            this.next.CheckedBaseColor = System.Drawing.Color.Gray;
            this.next.CheckedBorderColor = System.Drawing.Color.Black;
            this.next.CheckedForeColor = System.Drawing.Color.White;
            this.next.CheckedImage = ((System.Drawing.Image)(resources.GetObject("next.CheckedImage")));
            this.next.CheckedLineColor = System.Drawing.Color.DimGray;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.next.FocusedColor = System.Drawing.Color.Empty;
            this.next.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = null;
            this.next.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.next.ImageSize = new System.Drawing.Size(20, 20);
            this.next.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.next.Location = new System.Drawing.Point(95, 275);
            this.next.Name = "next";
            this.next.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.next.OnHoverBorderColor = System.Drawing.Color.Black;
            this.next.OnHoverForeColor = System.Drawing.Color.White;
            this.next.OnHoverImage = null;
            this.next.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.next.OnPressedColor = System.Drawing.Color.Black;
            this.next.Radius = 10;
            this.next.Size = new System.Drawing.Size(122, 31);
            this.next.TabIndex = 62;
            this.next.Text = "Next";
            this.next.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel2.Location = new System.Drawing.Point(72, 104);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(174, 42);
            this.gunaLabel2.TabIndex = 64;
            this.gunaLabel2.Text = "Your Password";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(364, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(162, 194);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 60;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(6, 3);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 9;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.TabIndex = 58;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(15, 15);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(853, 4);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 9;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.TabIndex = 57;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click_1);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.AnimationHoverSpeed = 0.07F;
            this.backButton.AnimationSpeed = 0.03F;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.backButton.BorderColor = System.Drawing.Color.Black;
            this.backButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.backButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.backButton.CheckedForeColor = System.Drawing.Color.White;
            this.backButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("backButton.CheckedImage")));
            this.backButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backButton.FocusedColor = System.Drawing.Color.Empty;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backButton.ImageSize = new System.Drawing.Size(20, 20);
            this.backButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.backButton.Location = new System.Drawing.Point(-33, -9);
            this.backButton.Name = "backButton";
            this.backButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.backButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backButton.OnHoverForeColor = System.Drawing.Color.White;
            this.backButton.OnHoverImage = null;
            this.backButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.backButton.OnPressedColor = System.Drawing.Color.Black;
            this.backButton.Radius = 9;
            this.backButton.Size = new System.Drawing.Size(20, 20);
            this.backButton.TabIndex = 42;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset your password";
            this.Load += new System.EventHandler(this.Reset_Load_1);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton backButton;
        private Guna.UI.WinForms.GunaTextBox textbox;
        private Guna.UI.WinForms.GunaAdvenceButton button;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI.WinForms.GunaLabel found;
        private Guna.UI.WinForms.GunaLabel userlabel;
        private Guna.UI.WinForms.GunaLabel emailsent;
        private Guna.UI.WinForms.GunaLabel sent;
        private Guna.UI.WinForms.GunaAdvenceButton confirmbutton;
        private Guna.UI.WinForms.GunaTextBox confirmtext1;
        private Guna.UI.WinForms.GunaLabel minimumCharacter;
        private Guna.UI.WinForms.GunaAdvenceTileButton hideButton;
        private Guna.UI.WinForms.GunaAdvenceTileButton showButton;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaAdvenceButton next;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}