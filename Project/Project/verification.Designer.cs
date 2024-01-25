namespace Project
{
    partial class verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verification));
            this.verifyLabel = new Guna.UI.WinForms.GunaLabel();
            this.completeLabel = new Guna.UI.WinForms.GunaLabel();
            this.emailLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.codeText = new Guna.UI.WinForms.GunaTextBox();
            this.enterLabel = new Guna.UI.WinForms.GunaLabel();
            this.load = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.email = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new Guna.UI.WinForms.GunaLabel();
            this.wait = new Guna.UI.WinForms.GunaLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timelabel2 = new Guna.UI.WinForms.GunaLabel();
            this.backButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.confirmButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.resendButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // verifyLabel
            // 
            this.verifyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.verifyLabel.Font = new System.Drawing.Font("Calisto MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.verifyLabel.Location = new System.Drawing.Point(283, 24);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(288, 40);
            this.verifyLabel.TabIndex = 0;
            this.verifyLabel.Text = "Verify your email";
            this.verifyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // completeLabel
            // 
            this.completeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.completeLabel.AutoSize = true;
            this.completeLabel.BackColor = System.Drawing.Color.Transparent;
            this.completeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.completeLabel.Location = new System.Drawing.Point(191, 64);
            this.completeLabel.Name = "completeLabel";
            this.completeLabel.Size = new System.Drawing.Size(498, 23);
            this.completeLabel.TabIndex = 1;
            this.completeLabel.Text = "You will need to verify your email to complete registration";
            this.completeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.emailLabel.Location = new System.Drawing.Point(237, 346);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(167, 19);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "An email has been sent to ";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel2.Location = new System.Drawing.Point(110, 367);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(648, 19);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "If you have not received the email after a few minutes, please check your spam fo" +
    "lder or click resend email";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codeText
            // 
            this.codeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeText.BackColor = System.Drawing.Color.Transparent;
            this.codeText.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.codeText.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.codeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeText.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.codeText.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.codeText.FocusedForeColor = System.Drawing.SystemColors.ControlLight;
            this.codeText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.codeText.Location = new System.Drawing.Point(355, 409);
            this.codeText.Name = "codeText";
            this.codeText.PasswordChar = '\0';
            this.codeText.Radius = 10;
            this.codeText.SelectedText = "";
            this.codeText.Size = new System.Drawing.Size(216, 34);
            this.codeText.TabIndex = 21;
            this.codeText.TextChanged += new System.EventHandler(this.codeText_TextChanged);
            // 
            // enterLabel
            // 
            this.enterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.enterLabel.Location = new System.Drawing.Point(416, 392);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(84, 15);
            this.enterLabel.TabIndex = 22;
            this.enterLabel.Text = "Enter the code";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // load
            // 
            this.load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.load.Location = new System.Drawing.Point(511, 443);
            this.load.Name = "load";
            this.load.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.load.Size = new System.Drawing.Size(20, 20);
            this.load.TabIndex = 27;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.email.Location = new System.Drawing.Point(400, 346);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(193, 19);
            this.email.TabIndex = 28;
            this.email.Text = "naimurrahman471@gmail.com";
            this.email.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timelabel
            // 
            this.timelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.timelabel.Location = new System.Drawing.Point(488, 443);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(23, 20);
            this.timelabel.TabIndex = 39;
            this.timelabel.Text = "60";
            // 
            // wait
            // 
            this.wait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wait.AutoSize = true;
            this.wait.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wait.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.wait.Location = new System.Drawing.Point(401, 445);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(87, 15);
            this.wait.TabIndex = 40;
            this.wait.Text = "Wait for resend";
            this.wait.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timelabel2
            // 
            this.timelabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timelabel2.AutoSize = true;
            this.timelabel2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel2.Location = new System.Drawing.Point(629, 266);
            this.timelabel2.Name = "timelabel2";
            this.timelabel2.Size = new System.Drawing.Size(23, 20);
            this.timelabel2.TabIndex = 42;
            this.timelabel2.Text = "60";
            // 
            // backButton
            // 
            this.backButton.AnimationHoverSpeed = 0.07F;
            this.backButton.AnimationSpeed = 0.03F;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.Transparent;
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
            this.backButton.Location = new System.Drawing.Point(8, 3);
            this.backButton.Name = "backButton";
            this.backButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.backButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backButton.OnHoverForeColor = System.Drawing.Color.White;
            this.backButton.OnHoverImage = null;
            this.backButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.backButton.OnPressedColor = System.Drawing.Color.Black;
            this.backButton.Radius = 9;
            this.backButton.Size = new System.Drawing.Size(20, 20);
            this.backButton.TabIndex = 41;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.AnimationHoverSpeed = 0.07F;
            this.confirmButton.AnimationSpeed = 0.03F;
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.confirmButton.BorderColor = System.Drawing.Color.Black;
            this.confirmButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.confirmButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.confirmButton.CheckedForeColor = System.Drawing.Color.White;
            this.confirmButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("confirmButton.CheckedImage")));
            this.confirmButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.confirmButton.FocusedColor = System.Drawing.Color.Empty;
            this.confirmButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Image = null;
            this.confirmButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmButton.ImageSize = new System.Drawing.Size(20, 20);
            this.confirmButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmButton.Location = new System.Drawing.Point(493, 476);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.confirmButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.confirmButton.OnHoverForeColor = System.Drawing.Color.White;
            this.confirmButton.OnHoverImage = null;
            this.confirmButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.confirmButton.OnPressedColor = System.Drawing.Color.Black;
            this.confirmButton.Radius = 8;
            this.confirmButton.Size = new System.Drawing.Size(115, 32);
            this.confirmButton.TabIndex = 25;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // resendButton
            // 
            this.resendButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resendButton.AnimationHoverSpeed = 0.07F;
            this.resendButton.AnimationSpeed = 0.03F;
            this.resendButton.BackColor = System.Drawing.Color.Transparent;
            this.resendButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.resendButton.BorderColor = System.Drawing.Color.Black;
            this.resendButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.resendButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.resendButton.CheckedForeColor = System.Drawing.Color.White;
            this.resendButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resendButton.CheckedImage")));
            this.resendButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.resendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resendButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resendButton.FocusedColor = System.Drawing.Color.Empty;
            this.resendButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendButton.ForeColor = System.Drawing.Color.White;
            this.resendButton.Image = null;
            this.resendButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resendButton.ImageSize = new System.Drawing.Size(20, 20);
            this.resendButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.resendButton.Location = new System.Drawing.Point(334, 476);
            this.resendButton.Name = "resendButton";
            this.resendButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.resendButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resendButton.OnHoverForeColor = System.Drawing.Color.White;
            this.resendButton.OnHoverImage = null;
            this.resendButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.resendButton.OnPressedColor = System.Drawing.Color.Black;
            this.resendButton.Radius = 8;
            this.resendButton.Size = new System.Drawing.Size(115, 32);
            this.resendButton.TabIndex = 24;
            this.resendButton.Text = "Resend Email";
            this.resendButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resendButton.Click += new System.EventHandler(this.resendButton_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(223, 83);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(440, 247);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 2;
            this.gunaPictureBox1.TabStop = false;
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
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(853, 5);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.IndianRed;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 9;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.TabIndex = 43;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click_1);
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
            this.gunaPanel1.Controls.Add(this.backButton);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.ForeColor = System.Drawing.Color.Cyan;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(879, 25);
            this.gunaPanel1.TabIndex = 44;
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
            // verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.resendButton);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.completeLabel);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.load);
            this.Controls.Add(this.timelabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verification";
            this.Load += new System.EventHandler(this.verification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel verifyLabel;
        private Guna.UI.WinForms.GunaLabel completeLabel;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel emailLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox codeText;
        private Guna.UI.WinForms.GunaLabel enterLabel;
        private Guna.UI.WinForms.GunaAdvenceButton resendButton;
        private Guna.UI.WinForms.GunaAdvenceButton confirmButton;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator load;
        private Guna.UI.WinForms.GunaLabel email;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaLabel timelabel;
        private Guna.UI.WinForms.GunaLabel wait;
        private Guna.UI.WinForms.GunaAdvenceButton backButton;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI.WinForms.GunaLabel timelabel2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}