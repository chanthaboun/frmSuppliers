namespace frmLogin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            label2 = new Label();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPwd);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(47, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 604);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 348);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 8;
            label2.Text = "ລະຫັດຜ່ານ :";
            // 
            // txtPwd
            // 
            txtPwd.AcceptsReturn = true;
            txtPwd.Font = new Font("Phetsarath OT", 16.2F);
            txtPwd.Location = new Point(153, 380);
            txtPwd.Multiline = true;
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(297, 49);
            txtPwd.TabIndex = 7;
            txtPwd.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Location = new Point(337, 469);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 41);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(153, 469);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Phetsarath OT", 16.2F);
            txtUserName.Location = new Point(153, 280);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(297, 49);
            txtUserName.TabIndex = 2;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 244);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 1;
            label1.Text = "ຊື່ເຂົ້າໃຊ້ງານລະບົບ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 628);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnExit;
        private TextBox txtUserName;
        private Label label1;
        private TextBox txtPwd;
        private Label label2;
    }
}