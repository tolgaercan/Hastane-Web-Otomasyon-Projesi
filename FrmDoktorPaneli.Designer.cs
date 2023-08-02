
namespace Hastane_Proje2
{
    partial class FrmDoktorPaneli
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
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthastasoyad = new System.Windows.Forms.TextBox();
            this.txthastaad = new System.Windows.Forms.TextBox();
            this.lblhastasoyad = new System.Windows.Forms.Label();
            this.lblhastaad = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Items.AddRange(new object[] {
            ""});
            this.cmbbrans.Location = new System.Drawing.Point(180, 234);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(199, 31);
            this.cmbbrans.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Branş:";
            // 
            // txthastasoyad
            // 
            this.txthastasoyad.Location = new System.Drawing.Point(180, 173);
            this.txthastasoyad.Name = "txthastasoyad";
            this.txthastasoyad.Size = new System.Drawing.Size(199, 30);
            this.txthastasoyad.TabIndex = 2;
            // 
            // txthastaad
            // 
            this.txthastaad.Location = new System.Drawing.Point(180, 112);
            this.txthastaad.Name = "txthastaad";
            this.txthastaad.Size = new System.Drawing.Size(199, 30);
            this.txthastaad.TabIndex = 1;
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(18, 172);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(137, 23);
            this.lblhastasoyad.TabIndex = 28;
            this.lblhastasoyad.Text = "Doktor Soyad:";
            // 
            // lblhastaad
            // 
            this.lblhastaad.AutoSize = true;
            this.lblhastaad.Location = new System.Drawing.Point(51, 119);
            this.lblhastaad.Name = "lblhastaad";
            this.lblhastaad.Size = new System.Drawing.Size(104, 23);
            this.lblhastaad.TabIndex = 27;
            this.lblhastaad.Text = "Doktor Ad:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(180, 296);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(199, 30);
            this.msktc.TabIndex = 4;
            this.msktc.ValidatingType = typeof(int);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(26, 291);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(129, 23);
            this.lbltc.TabIndex = 25;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(180, 357);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(199, 30);
            this.txtsifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 415);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(440, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 46);
            this.label1.TabIndex = 33;
            this.label1.Text = "Doktor Paneli";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnekle.Location = new System.Drawing.Point(55, 417);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(119, 38);
            this.btnekle.TabIndex = 34;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Yellow;
            this.btnsil.Location = new System.Drawing.Point(222, 417);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(119, 38);
            this.btnsil.TabIndex = 35;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Lime;
            this.btnguncelle.Location = new System.Drawing.Point(130, 489);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(119, 38);
            this.btnguncelle.TabIndex = 36;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txthastasoyad);
            this.Controls.Add(this.txthastaad);
            this.Controls.Add(this.lblhastasoyad);
            this.Controls.Add(this.lblhastaad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthastasoyad;
        private System.Windows.Forms.TextBox txthastaad;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lblhastaad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
    }
}