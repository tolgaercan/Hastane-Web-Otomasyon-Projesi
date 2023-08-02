
namespace Hastane_Proje2
{
    partial class FrmHastaDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladSoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblhastasoyad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linklblbilgidüzenle = new System.Windows.Forms.LinkLabel();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.rtxtsikayet = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrdwrandevugecmisi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrdwaktifrandevular = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnrandevusıl = new System.Windows.Forms.Button();
            this.btnrandevuguncelle = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.msktxttarih = new System.Windows.Forms.MaskedTextBox();
            this.msktxtsaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnyenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwrandevugecmisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwaktifrandevular)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladSoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.lblhastasoyad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // lbladSoyad
            // 
            this.lbladSoyad.AutoSize = true;
            this.lbladSoyad.Location = new System.Drawing.Point(146, 89);
            this.lbladSoyad.Name = "lbladSoyad";
            this.lbladSoyad.Size = new System.Drawing.Size(78, 23);
            this.lbladSoyad.TabIndex = 15;
            this.lbladSoyad.Text = "Null Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(146, 41);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(131, 23);
            this.lbltc.TabIndex = 14;
            this.lbltc.Text = "00000000000";
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(25, 89);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(102, 23);
            this.lblhastasoyad.TabIndex = 13;
            this.lblhastasoyad.Text = "Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "TC Kimlik No:";
            // 
            // linklblbilgidüzenle
            // 
            this.linklblbilgidüzenle.AutoSize = true;
            this.linklblbilgidüzenle.Location = new System.Drawing.Point(104, 369);
            this.linklblbilgidüzenle.Name = "linklblbilgidüzenle";
            this.linklblbilgidüzenle.Size = new System.Drawing.Size(162, 23);
            this.linklblbilgidüzenle.TabIndex = 23;
            this.linklblbilgidüzenle.TabStop = true;
            this.linklblbilgidüzenle.Text = "Bilgilerini Düzenle";
            this.linklblbilgidüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblbilgidüzenle_LinkClicked);
            // 
            // btnrandevual
            // 
            this.btnrandevual.Location = new System.Drawing.Point(-11, 271);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(177, 45);
            this.btnrandevual.TabIndex = 22;
            this.btnrandevual.Text = "Randevu Al";
            this.btnrandevual.UseVisualStyleBackColor = true;
            this.btnrandevual.Click += new System.EventHandler(this.btnrandevual_Click);
            // 
            // rtxtsikayet
            // 
            this.rtxtsikayet.Location = new System.Drawing.Point(220, 44);
            this.rtxtsikayet.Name = "rtxtsikayet";
            this.rtxtsikayet.Size = new System.Drawing.Size(154, 212);
            this.rtxtsikayet.TabIndex = 21;
            this.rtxtsikayet.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Şİkayet:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrdwrandevugecmisi);
            this.groupBox3.Location = new System.Drawing.Point(413, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dgrdwrandevugecmisi
            // 
            this.dgrdwrandevugecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdwrandevugecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdwrandevugecmisi.Location = new System.Drawing.Point(3, 26);
            this.dgrdwrandevugecmisi.Name = "dgrdwrandevugecmisi";
            this.dgrdwrandevugecmisi.RowHeadersWidth = 51;
            this.dgrdwrandevugecmisi.RowTemplate.Height = 24;
            this.dgrdwrandevugecmisi.Size = new System.Drawing.Size(571, 143);
            this.dgrdwrandevugecmisi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrdwaktifrandevular);
            this.groupBox4.Location = new System.Drawing.Point(413, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 255);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Raandevular";
            // 
            // dgrdwaktifrandevular
            // 
            this.dgrdwaktifrandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdwaktifrandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdwaktifrandevular.Location = new System.Drawing.Point(3, 26);
            this.dgrdwaktifrandevular.Name = "dgrdwaktifrandevular";
            this.dgrdwaktifrandevular.RowHeadersWidth = 51;
            this.dgrdwaktifrandevular.RowTemplate.Height = 24;
            this.dgrdwaktifrandevular.Size = new System.Drawing.Size(571, 226);
            this.dgrdwaktifrandevular.TabIndex = 0;
            this.dgrdwaktifrandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdwaktifrandevular_CellClick);
            this.dgrdwaktifrandevular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdwaktifrandevular_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btncıkıs);
            this.groupBox5.Controls.Add(this.btnrandevusıl);
            this.groupBox5.Controls.Add(this.btnrandevuguncelle);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.linklblbilgidüzenle);
            this.groupBox5.Controls.Add(this.msktxttarih);
            this.groupBox5.Controls.Add(this.rtxtsikayet);
            this.groupBox5.Controls.Add(this.msktxtsaat);
            this.groupBox5.Controls.Add(this.btnrandevual);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cmbdoktor);
            this.groupBox5.Controls.Add(this.cmbbrans);
            this.groupBox5.Controls.Add(this.txtid);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(18, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 404);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Randevu Paneli";
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(197, 322);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(171, 45);
            this.btncıkıs.TabIndex = 26;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnrandevusıl
            // 
            this.btnrandevusıl.Location = new System.Drawing.Point(0, 321);
            this.btnrandevusıl.Name = "btnrandevusıl";
            this.btnrandevusıl.Size = new System.Drawing.Size(170, 45);
            this.btnrandevusıl.TabIndex = 25;
            this.btnrandevusıl.Text = "Randevu Sil";
            this.btnrandevusıl.UseVisualStyleBackColor = true;
            this.btnrandevusıl.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnrandevuguncelle
            // 
            this.btnrandevuguncelle.Location = new System.Drawing.Point(197, 271);
            this.btnrandevuguncelle.Name = "btnrandevuguncelle";
            this.btnrandevuguncelle.Size = new System.Drawing.Size(177, 45);
            this.btnrandevuguncelle.TabIndex = 24;
            this.btnrandevuguncelle.Text = "Randevu Güncelle";
            this.btnrandevuguncelle.UseVisualStyleBackColor = true;
            this.btnrandevuguncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 238);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 27);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Durum";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // msktxttarih
            // 
            this.msktxttarih.Location = new System.Drawing.Point(82, 66);
            this.msktxttarih.Mask = "00/00/0000";
            this.msktxttarih.Name = "msktxttarih";
            this.msktxttarih.Size = new System.Drawing.Size(129, 30);
            this.msktxttarih.TabIndex = 1;
            this.msktxttarih.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtsaat
            // 
            this.msktxtsaat.Location = new System.Drawing.Point(82, 105);
            this.msktxtsaat.Mask = "90:00";
            this.msktxtsaat.Name = "msktxtsaat";
            this.msktxtsaat.Size = new System.Drawing.Size(129, 30);
            this.msktxtsaat.TabIndex = 2;
            this.msktxtsaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(82, 185);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(129, 31);
            this.cmbdoktor.TabIndex = 4;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged_1);
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(82, 144);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(129, 31);
            this.cmbbrans.TabIndex = 3;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged_1);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(82, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 30);
            this.txtid.TabIndex = 20;
            this.txtid.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "branş";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "saat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "tarih:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "id:";
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.Aqua;
            this.btnyenile.Location = new System.Drawing.Point(633, 474);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(133, 37);
            this.btnyenile.TabIndex = 27;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 559);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastaDetay";
            this.Text = "FrmHastaDetay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwrandevugecmisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwaktifrandevular)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lbladSoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.RichTextBox rtxtsikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrdwrandevugecmisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgrdwaktifrandevular;
        private System.Windows.Forms.LinkLabel linklblbilgidüzenle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox msktxttarih;
        private System.Windows.Forms.MaskedTextBox msktxtsaat;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnrandevuguncelle;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnrandevusıl;
        private System.Windows.Forms.Button btnyenile;
    }
}