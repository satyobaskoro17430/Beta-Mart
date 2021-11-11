namespace BetaMart
{
    partial class Form1
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
            this.dgv_dataBarang = new System.Windows.Forms.DataGridView();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hargaEdit = new System.Windows.Forms.TextBox();
            this.tb_namaEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dataBarang
            // 
            this.dgv_dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataBarang.Location = new System.Drawing.Point(12, 168);
            this.dgv_dataBarang.Name = "dgv_dataBarang";
            this.dgv_dataBarang.Size = new System.Drawing.Size(622, 209);
            this.dgv_dataBarang.TabIndex = 0;
            this.dgv_dataBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataBarang_CellClick);
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(87, 60);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(153, 20);
            this.tb_nama.TabIndex = 1;
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(87, 86);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(153, 20);
            this.tb_harga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(109, 112);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 32);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "TAMBAH DATA";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(441, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 32);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "SIMPAN DATA";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama";
            // 
            // tb_hargaEdit
            // 
            this.tb_hargaEdit.Location = new System.Drawing.Point(419, 89);
            this.tb_hargaEdit.Name = "tb_hargaEdit";
            this.tb_hargaEdit.Size = new System.Drawing.Size(153, 20);
            this.tb_hargaEdit.TabIndex = 7;
            // 
            // tb_namaEdit
            // 
            this.tb_namaEdit.Location = new System.Drawing.Point(419, 63);
            this.tb_namaEdit.Name = "tb_namaEdit";
            this.tb_namaEdit.Size = new System.Drawing.Size(153, 20);
            this.tb_namaEdit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(419, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(153, 20);
            this.tb_id.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 389);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_hargaEdit);
            this.Controls.Add(this.tb_namaEdit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.dgv_dataBarang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataBarang;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hargaEdit;
        private System.Windows.Forms.TextBox tb_namaEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
    }
}

