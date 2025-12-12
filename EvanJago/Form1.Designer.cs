namespace EvanJago
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNama = new TextBox();
            cbProyek = new ComboBox();
            cbStatus = new ComboBox();
            tbFitur = new TextBox();
            tbBug = new TextBox();
            dgvData = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(154, 119);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(326, 23);
            tbNama.TabIndex = 0;
            // 
            // cbProyek
            // 
            cbProyek.FormattingEnabled = true;
            cbProyek.Items.AddRange(new object[] { "Web Company Profile", "Sistem Parkir QR", "IoT Agriculture App", "E-Commerce Start Up", "AI-Fraud Detection" });
            cbProyek.Location = new Point(154, 159);
            cbProyek.Name = "cbProyek";
            cbProyek.Size = new Size(326, 23);
            cbProyek.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Fulltime", "Freelance" });
            cbStatus.Location = new Point(154, 199);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(326, 23);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // tbFitur
            // 
            tbFitur.Location = new Point(154, 257);
            tbFitur.Name = "tbFitur";
            tbFitur.Size = new Size(100, 23);
            tbFitur.TabIndex = 3;
            // 
            // tbBug
            // 
            tbBug.Location = new Point(154, 297);
            tbBug.Name = "tbBug";
            tbBug.Size = new Size(100, 23);
            tbBug.TabIndex = 4;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 413);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(565, 131);
            dgvData.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 336);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(95, 40);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(254, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 40);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(486, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_12_12_093806;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 12);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 10;
            label1.Text = "EvanJago";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 44);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 11;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 101);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 12;
            label3.Text = "DATA DEVELOPER";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 235);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 13;
            label4.Text = "DATA KINERJA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 122);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 14;
            label5.Text = "Nama Developer :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 202);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 15;
            label6.Text = "Status Kontrak :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 162);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 16;
            label7.Text = "Nama Proyek :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 260);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 17;
            label8.Text = "Fitur Selesai :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(73, 297);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 18;
            label9.Text = "Jumlah Bug :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(269, 260);
            label10.Name = "label10";
            label10.Size = new Size(166, 15);
            label10.TabIndex = 19;
            label10.Text = "(Jumlah Fitur yang dikerjakan)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(269, 300);
            label11.Name = "label11";
            label11.Size = new Size(166, 15);
            label11.TabIndex = 20;
            label11.Text = "(Jumlah Bug yang ditemukan)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(43, 387);
            label12.Name = "label12";
            label12.Size = new Size(143, 15);
            label12.TabIndex = 21;
            label12.Text = "DAFTAR PERFORMA TIM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 556);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvData);
            Controls.Add(tbBug);
            Controls.Add(tbFitur);
            Controls.Add(cbStatus);
            Controls.Add(cbProyek);
            Controls.Add(tbNama);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private ComboBox cbProyek;
        private ComboBox cbStatus;
        private TextBox tbFitur;
        private TextBox tbBug;
        private DataGridView dgvData;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
