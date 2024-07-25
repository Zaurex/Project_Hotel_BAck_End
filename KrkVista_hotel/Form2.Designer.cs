namespace KrkVista_hotel
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtmCo = new Guna.UI2.WinForms.Guna2Button();
            this.BtmRooms = new Guna.UI2.WinForms.Guna2Button();
            this.BtmRegister = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.us_Registration1 = new KrkVista_hotel.Users_Controll.Us_Registration();
            this.us_AddRoom1 = new KrkVista_hotel.Users_Controll.Us_AddRoom();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtmCo);
            this.panel1.Controls.Add(this.BtmRooms);
            this.panel1.Controls.Add(this.BtmRegister);
            this.panel1.Location = new System.Drawing.Point(210, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 106);
            this.panel1.TabIndex = 1;
            // 
            // BtmCo
            // 
            this.BtmCo.AutoRoundedCorners = true;
            this.BtmCo.BorderRadius = 35;
            this.BtmCo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtmCo.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtmCo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtmCo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtmCo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtmCo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtmCo.FillColor = System.Drawing.Color.IndianRed;
            this.BtmCo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.BtmCo.ForeColor = System.Drawing.Color.Black;
            this.BtmCo.Location = new System.Drawing.Point(765, 20);
            this.BtmCo.Name = "BtmCo";
            this.BtmCo.Size = new System.Drawing.Size(188, 72);
            this.BtmCo.TabIndex = 4;
            this.BtmCo.Text = "Check Out";
            // 
            // BtmRooms
            // 
            this.BtmRooms.AutoRoundedCorners = true;
            this.BtmRooms.BorderRadius = 35;
            this.BtmRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtmRooms.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtmRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtmRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtmRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtmRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtmRooms.FillColor = System.Drawing.Color.IndianRed;
            this.BtmRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.BtmRooms.ForeColor = System.Drawing.Color.Black;
            this.BtmRooms.Location = new System.Drawing.Point(16, 20);
            this.BtmRooms.Name = "BtmRooms";
            this.BtmRooms.Size = new System.Drawing.Size(188, 72);
            this.BtmRooms.TabIndex = 3;
            this.BtmRooms.Text = "Rooms";
            this.BtmRooms.Click += new System.EventHandler(this.BtmRooms_Click);
            // 
            // BtmRegister
            // 
            this.BtmRegister.AutoRoundedCorners = true;
            this.BtmRegister.BorderRadius = 35;
            this.BtmRegister.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtmRegister.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtmRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtmRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtmRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtmRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtmRegister.FillColor = System.Drawing.Color.IndianRed;
            this.BtmRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmRegister.ForeColor = System.Drawing.Color.Black;
            this.BtmRegister.Location = new System.Drawing.Point(387, 20);
            this.BtmRegister.Name = "BtmRegister";
            this.BtmRegister.Size = new System.Drawing.Size(188, 72);
            this.BtmRegister.TabIndex = 2;
            this.BtmRegister.Text = "Registration";
            this.BtmRegister.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.us_Registration1);
            this.panel2.Controls.Add(this.us_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(43, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1849, 683);
            this.panel2.TabIndex = 0;
            // 
            // us_Registration1
            // 
            this.us_Registration1.BackColor = System.Drawing.Color.IndianRed;
            this.us_Registration1.Location = new System.Drawing.Point(144, 3);
            this.us_Registration1.Name = "us_Registration1";
            this.us_Registration1.Size = new System.Drawing.Size(1023, 459);
            this.us_Registration1.TabIndex = 1;
            // 
            // us_AddRoom1
            // 
            this.us_AddRoom1.BackColor = System.Drawing.Color.IndianRed;
            this.us_AddRoom1.Location = new System.Drawing.Point(144, 0);
            this.us_AddRoom1.Name = "us_AddRoom1";
            this.us_AddRoom1.Size = new System.Drawing.Size(1023, 459);
            this.us_AddRoom1.TabIndex = 0;
            this.us_AddRoom1.Visible = false;
            this.us_AddRoom1.Load += new System.EventHandler(this.us_AddRoom1_Load);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::KrkVista_hotel.Properties.Resources.GIF;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(117, 125);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1349, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtmCo;
        private Guna.UI2.WinForms.Guna2Button BtmRooms;
        private Guna.UI2.WinForms.Guna2Button BtmRegister;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Users_Controll.Us_AddRoom us_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Users_Controll.Us_Registration us_Registration1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}