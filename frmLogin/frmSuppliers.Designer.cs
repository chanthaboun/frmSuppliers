namespace frmLogin
{
    partial class frmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            label1 = new Label();
            label2 = new Label();
            txtSupID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSupName = new TextBox();
            label5 = new Label();
            txtContr = new TextBox();
            label6 = new Label();
            txtTel = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvShow = new DataGridView();
            txtEmail = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Phetsarath OT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(990, 39);
            label1.TabIndex = 0;
            label1.Text = "ຟອມຂໍ້ມູນຜູ້ສະໜອງ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(161, 34);
            label2.TabIndex = 1;
            label2.Text = "ຮັບຂໍ້ມູນຜູ້ສະໜອງ";
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(223, 109);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(476, 41);
            txtSupID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 115);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 3;
            label3.Text = "ຮັບຂໍ້ມູນຜູ້ສະໜອງ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 163);
            label4.Name = "label4";
            label4.Size = new Size(77, 29);
            label4.TabIndex = 4;
            label4.Text = "ຊື່ບໍລີສັດ:";
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(223, 157);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(722, 41);
            txtSupName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(139, 212);
            label5.Name = "label5";
            label5.Size = new Size(78, 29);
            label5.TabIndex = 6;
            label5.Text = "ຊື່ຜູ້ຕິດຕໍ່:";
            // 
            // txtContr
            // 
            txtContr.Location = new Point(223, 207);
            txtContr.Name = "txtContr";
            txtContr.Size = new Size(722, 41);
            txtContr.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 268);
            label6.Name = "label6";
            label6.Size = new Size(94, 29);
            label6.TabIndex = 8;
            label6.Text = "ເບີໂທຕິດຕໍ່:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(223, 262);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(476, 41);
            txtTel.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(174, 328);
            label7.Name = "label7";
            label7.Size = new Size(43, 29);
            label7.TabIndex = 10;
            label7.Text = "ທີ່ຢູ່:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(223, 322);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(722, 41);
            txtAddress.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(223, 429);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 55);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Green;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(480, 429);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 55);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(717, 429);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 55);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "ລົບຂໍ້ມູນ";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvShow
            // 
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(18, 503);
            dgvShow.Name = "dgvShow";
            dgvShow.RowHeadersWidth = 51;
            dgvShow.Size = new Size(958, 202);
            dgvShow.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 382);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(476, 41);
            txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Phetsarath OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(156, 388);
            label8.Name = "label8";
            label8.Size = new Size(61, 29);
            label8.TabIndex = 17;
            label8.Text = "ອີເມວ:";
            // 
            // frmSuppliers
            // 
            AutoScaleDimensions = new SizeF(13F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(988, 717);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(dgvShow);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(txtTel);
            Controls.Add(label6);
            Controls.Add(txtContr);
            Controls.Add(label5);
            Controls.Add(txtSupName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSupID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "frmSuppliers";
            Text = "frmSuppliers";
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSupID;
        private Label label3;
        private Label label4;
        private TextBox txtSupName;
        private Label label5;
        private TextBox txtContr;
        private Label label6;
        private TextBox txtTel;
        private Label label7;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvShow;
        private TextBox txtEmail;
        private Label label8;
    }
}