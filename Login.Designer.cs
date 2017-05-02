namespace SpaceTravel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SignupLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.LoginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Password = new Bunifu.Framework.UI.BunifuTextbox();
            this.UserName = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.LoginPanel.Controls.Add(this.bunifuCustomLabel1);
            this.LoginPanel.Controls.Add(this.SignupLabel);
            this.LoginPanel.Controls.Add(this.bunifuImageButton1);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.UserName);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(396, 509);
            this.LoginPanel.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(175, 427);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(30, 17);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Exit";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SignupLabel.Location = new System.Drawing.Point(144, 393);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(110, 17);
            this.SignupLabel.TabIndex = 6;
            this.SignupLabel.Text = "Sign up here !";
            this.SignupLabel.Click += new System.EventHandler(this.SignupLabel_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::SpaceTravel.Properties.Resources.singlelogo;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = global::SpaceTravel.Properties.Resources.singlelogo;
            this.bunifuImageButton1.Location = new System.Drawing.Point(116, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(141, 125);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // LoginButton
            // 
            this.LoginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.LoginButton.BackColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.BorderRadius = 0;
            this.LoginButton.ButtonText = "LOGIN";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("LoginButton.Iconimage")));
            this.LoginButton.Iconimage_right = null;
            this.LoginButton.Iconimage_right_Selected = null;
            this.LoginButton.Iconimage_Selected = null;
            this.LoginButton.IconZoom = 90D;
            this.LoginButton.IsTab = false;
            this.LoginButton.Location = new System.Drawing.Point(94, 320);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Normalcolor = System.Drawing.Color.SeaGreen;
            this.LoginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.selected = false;
            this.LoginButton.Size = new System.Drawing.Size(199, 56);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Textcolor = System.Drawing.Color.White;
            this.LoginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Password.BackgroundImage")));
            this.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Password.ForeColor = System.Drawing.Color.SeaGreen;
            this.Password.Icon = ((System.Drawing.Image)(resources.GetObject("Password.Icon")));
            this.Password.Location = new System.Drawing.Point(39, 236);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(315, 62);
            this.Password.TabIndex = 2;
            this.Password.text = "Password";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(27)))), ((int)(((byte)(41)))));
            this.UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserName.BackgroundImage")));
            this.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserName.ForeColor = System.Drawing.Color.SeaGreen;
            this.UserName.Icon = ((System.Drawing.Image)(resources.GetObject("UserName.Icon")));
            this.UserName.Location = new System.Drawing.Point(39, 166);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(315, 62);
            this.UserName.TabIndex = 1;
            this.UserName.text = "Username";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LoginPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 509);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel LoginPanel;
        private Bunifu.Framework.UI.BunifuFlatButton LoginButton;
        private Bunifu.Framework.UI.BunifuTextbox Password;
        private Bunifu.Framework.UI.BunifuTextbox UserName;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel SignupLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}