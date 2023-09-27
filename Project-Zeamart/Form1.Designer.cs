namespace Project_Zeamart
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
            panel1 = new Panel();
            label5 = new Label();
            txtUkuran = new TextBox();
            txtWarna = new TextBox();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            txtNamaBarang = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            btn_Add = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            panel2 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUkuran);
            panel1.Controls.Add(txtWarna);
            panel1.Controls.Add(txtHarga);
            panel1.Controls.Add(txtStok);
            panel1.Controls.Add(txtNamaBarang);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 267);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 203);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 16;
            label5.Text = "Stok";
            // 
            // txtUkuran
            // 
            txtUkuran.Location = new Point(283, 87);
            txtUkuran.Name = "txtUkuran";
            txtUkuran.Size = new Size(293, 23);
            txtUkuran.TabIndex = 15;
            // 
            // txtWarna
            // 
            txtWarna.Location = new Point(283, 126);
            txtWarna.Name = "txtWarna";
            txtWarna.Size = new Size(293, 23);
            txtWarna.TabIndex = 14;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(283, 163);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(293, 23);
            txtHarga.TabIndex = 13;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(283, 200);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(293, 23);
            txtStok.TabIndex = 12;
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(283, 48);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(293, 23);
            txtNamaBarang.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 166);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 129);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Warna";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 90);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Ukuran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 51);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "Nama Barang ";
            // 
            // txtId
            // 
            txtId.Location = new Point(283, 11);
            txtId.Name = "txtId";
            txtId.Size = new Size(293, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 14);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.LightGray;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(131, 135);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btn_Add);
            panel3.Controls.Add(btn_Delete);
            panel3.Controls.Add(btn_Update);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 267);
            panel3.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Location = new Point(22, 146);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 17;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.MediumPurple;
            btn_Add.Location = new Point(22, 175);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(87, 23);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.LightCoral;
            btn_Delete.Location = new Point(22, 233);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(87, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Cyan;
            btn_Update.Location = new Point(22, 204);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(87, 23);
            btn_Update.TabIndex = 4;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(15, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 217);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 16);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 18;
            label7.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(554, 153);
            dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(67, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(506, 23);
            txtSearch.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(613, 527);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtId;
        private Label label1;
        private PictureBox pictureBox;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUkuran;
        private TextBox txtWarna;
        private TextBox txtHarga;
        private TextBox txtStok;
        private TextBox txtNamaBarang;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button button1;
        private Label label7;
        private TextBox txtSearch;
    }
}