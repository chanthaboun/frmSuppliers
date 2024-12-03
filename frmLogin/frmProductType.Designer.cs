namespace frmLogin
{
    partial class frmProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductType));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPtTypeID = new TextBox();
            label4 = new Label();
            txtPtTypeName = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvShow = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-4, -2);
            label1.Name = "label1";
            label1.Size = new Size(953, 48);
            label1.TabIndex = 0;
            label1.Text = "ຟອມຂໍ້ມູນປະເພດສິນຄ້າ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(131, 34);
            label2.TabIndex = 1;
            label2.Text = "ຮັບຂໍ້ມູນສິນຄ້າ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 145);
            label3.Name = "label3";
            label3.Size = new Size(133, 34);
            label3.TabIndex = 2;
            label3.Text = "ລະຫັດປະເພດ :";
            // 
            // txtPtTypeID
            // 
            txtPtTypeID.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPtTypeID.Location = new Point(179, 142);
            txtPtTypeID.Name = "txtPtTypeID";
            txtPtTypeID.Size = new Size(327, 41);
            txtPtTypeID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 211);
            label4.Name = "label4";
            label4.Size = new Size(131, 34);
            label4.TabIndex = 4;
            label4.Text = "ຊື່ປະເພດສິນຄ້າ";
            // 
            // txtPtTypeName
            // 
            txtPtTypeName.Font = new Font("Phetsarath OT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPtTypeName.Location = new Point(179, 208);
            txtPtTypeName.Multiline = true;
            txtPtTypeName.Name = "txtPtTypeName";
            txtPtTypeName.Size = new Size(327, 384);
            txtPtTypeName.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Phetsarath OT", 13.8F);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(32, 615);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 48);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DeepSkyBlue;
            btnEdit.Font = new Font("Phetsarath OT", 13.8F);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(195, 615);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 48);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Phetsarath OT", 13.8F);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(375, 615);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 48);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "ລົບຂໍ້ມູນ";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvShow
            // 
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(520, 145);
            dgvShow.Name = "dgvShow";
            dgvShow.RowHeadersWidth = 51;
            dgvShow.Size = new Size(416, 548);
            dgvShow.TabIndex = 9;
            // 
            // frmProductType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(948, 705);
            Controls.Add(dgvShow);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtPtTypeName);
            Controls.Add(label4);
            Controls.Add(txtPtTypeID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductType";
            Text = "frmProductType";
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPtTypeID;
        private Label label4;
        private TextBox txtPtTypeName;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvShow;
    }
}