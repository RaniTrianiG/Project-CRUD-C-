namespace Crud
{
    partial class FCrud
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
            this.dataGridFCrud = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnLogin1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFCrud
            // 
            this.dataGridFCrud.AllowUserToAddRows = false;
            this.dataGridFCrud.AllowUserToDeleteRows = false;
            this.dataGridFCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFCrud.Location = new System.Drawing.Point(12, 12);
            this.dataGridFCrud.Name = "dataGridFCrud";
            this.dataGridFCrud.ReadOnly = true;
            this.dataGridFCrud.Size = new System.Drawing.Size(420, 235);
            this.dataGridFCrud.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 271);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(357, 271);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 2;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnLogin1
            // 
            this.btnLogin1.Location = new System.Drawing.Point(455, 12);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(75, 23);
            this.btnLogin1.TabIndex = 3;
            this.btnLogin1.Text = "Login";
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // FCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 317);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridFCrud);
            this.Name = "FCrud";
            this.Text = "FCrud";
            this.Load += new System.EventHandler(this.FCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFCrud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFCrud;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnLogin1;
    }
}