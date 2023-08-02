
namespace Hastane_Proje2
{
    partial class FrmSekreterDetay
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
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuruolustur = new System.Windows.Forms.Button();
            this.rchtxtduyurular = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.msktxttc = new System.Windows.Forms.MaskedTextBox();
            this.msktxttarih = new System.Windows.Forms.MaskedTextBox();
            this.msktxtsaat = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrdwbranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgrdwdoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrandevulistesi = new System.Windows.Forms.Button();
            this.btndoktorpaneli = new System.Windows.Forms.Button();
            this.btnbranspaneli = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwbranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwdoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(131, 84);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(60, 17);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(131, 43);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(96, 17);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnduyuruolustur);
            this.groupBox2.Controls.Add(this.rchtxtduyurular);
            this.groupBox2.Location = new System.Drawing.Point(13, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 242);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnduyuruolustur
            // 
            this.btnduyuruolustur.Location = new System.Drawing.Point(72, 154);
            this.btnduyuruolustur.Name = "btnduyuruolustur";
            this.btnduyuruolustur.Size = new System.Drawing.Size(155, 38);
            this.btnduyuruolustur.TabIndex = 1;
            this.btnduyuruolustur.Text = "Oluştur";
            this.btnduyuruolustur.UseVisualStyleBackColor = true;
            this.btnduyuruolustur.Click += new System.EventHandler(this.btnduyuruolustur_Click);
            // 
            // rchtxtduyurular
            // 
            this.rchtxtduyurular.Location = new System.Drawing.Point(6, 34);
            this.rchtxtduyurular.Name = "rchtxtduyurular";
            this.rchtxtduyurular.Size = new System.Drawing.Size(302, 114);
            this.rchtxtduyurular.TabIndex = 0;
            this.rchtxtduyurular.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.msktxttc);
            this.groupBox3.Controls.Add(this.msktxttarih);
            this.groupBox3.Controls.Add(this.msktxtsaat);
            this.groupBox3.Controls.Add(this.cmbdoktor);
            this.groupBox3.Controls.Add(this.cmbbrans);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(357, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 392);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(106, 329);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(76, 39);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 271);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 21);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Durum";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // msktxttc
            // 
            this.msktxttc.Location = new System.Drawing.Point(82, 226);
            this.msktxttc.Mask = "00000000000";
            this.msktxttc.Name = "msktxttc";
            this.msktxttc.Size = new System.Drawing.Size(129, 22);
            this.msktxttc.TabIndex = 5;
            this.msktxttc.ValidatingType = typeof(int);
            // 
            // msktxttarih
            // 
            this.msktxttarih.Location = new System.Drawing.Point(82, 66);
            this.msktxttarih.Mask = "00/00/0000";
            this.msktxttarih.Name = "msktxttarih";
            this.msktxttarih.Size = new System.Drawing.Size(129, 22);
            this.msktxttarih.TabIndex = 1;
            this.msktxttarih.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtsaat
            // 
            this.msktxtsaat.Location = new System.Drawing.Point(82, 105);
            this.msktxtsaat.Mask = "90:00";
            this.msktxtsaat.Name = "msktxtsaat";
            this.msktxtsaat.Size = new System.Drawing.Size(129, 22);
            this.msktxtsaat.TabIndex = 2;
            this.msktxtsaat.ValidatingType = typeof(System.DateTime);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(82, 185);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(129, 24);
            this.cmbdoktor.TabIndex = 4;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(82, 144);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(129, 24);
            this.cmbbrans.TabIndex = 3;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(82, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 22);
            this.txtid.TabIndex = 20;
            this.txtid.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "branş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgrdwbranslar);
            this.groupBox4.Location = new System.Drawing.Point(667, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 193);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dgrdwbranslar
            // 
            this.dgrdwbranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdwbranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdwbranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdwbranslar.Location = new System.Drawing.Point(3, 18);
            this.dgrdwbranslar.Name = "dgrdwbranslar";
            this.dgrdwbranslar.RowHeadersWidth = 51;
            this.dgrdwbranslar.RowTemplate.Height = 24;
            this.dgrdwbranslar.Size = new System.Drawing.Size(298, 172);
            this.dgrdwbranslar.TabIndex = 0;
            this.dgrdwbranslar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdwbranslar_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgrdwdoktorlar);
            this.groupBox5.Location = new System.Drawing.Point(667, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 175);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dgrdwdoktorlar
            // 
            this.dgrdwdoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrdwdoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdwdoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdwdoktorlar.Location = new System.Drawing.Point(3, 18);
            this.dgrdwdoktorlar.Name = "dgrdwdoktorlar";
            this.dgrdwdoktorlar.RowHeadersWidth = 51;
            this.dgrdwdoktorlar.RowTemplate.Height = 24;
            this.dgrdwdoktorlar.Size = new System.Drawing.Size(298, 154);
            this.dgrdwdoktorlar.TabIndex = 1;
            this.dgrdwdoktorlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdwdoktorlar_CellContentClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnrandevulistesi);
            this.groupBox6.Controls.Add(this.btndoktorpaneli);
            this.groupBox6.Controls.Add(this.btnbranspaneli);
            this.groupBox6.Location = new System.Drawing.Point(185, 420);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(637, 89);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrandevulistesi
            // 
            this.btnrandevulistesi.Location = new System.Drawing.Point(341, 21);
            this.btnrandevulistesi.Name = "btnrandevulistesi";
            this.btnrandevulistesi.Size = new System.Drawing.Size(104, 55);
            this.btnrandevulistesi.TabIndex = 19;
            this.btnrandevulistesi.Text = "Randevu Listesi";
            this.btnrandevulistesi.UseVisualStyleBackColor = true;
            this.btnrandevulistesi.Click += new System.EventHandler(this.btnrandevulistesi_Click);
            // 
            // btndoktorpaneli
            // 
            this.btndoktorpaneli.Location = new System.Drawing.Point(47, 21);
            this.btndoktorpaneli.Name = "btndoktorpaneli";
            this.btndoktorpaneli.Size = new System.Drawing.Size(104, 55);
            this.btndoktorpaneli.TabIndex = 18;
            this.btndoktorpaneli.Text = "Doktor Paneli";
            this.btndoktorpaneli.UseVisualStyleBackColor = true;
            this.btndoktorpaneli.Click += new System.EventHandler(this.btndoktorpaneli_Click);
            // 
            // btnbranspaneli
            // 
            this.btnbranspaneli.Location = new System.Drawing.Point(196, 21);
            this.btnbranspaneli.Name = "btnbranspaneli";
            this.btnbranspaneli.Size = new System.Drawing.Size(104, 55);
            this.btnbranspaneli.TabIndex = 17;
            this.btnbranspaneli.Text = "Branş Paneli";
            this.btnbranspaneli.UseVisualStyleBackColor = true;
            this.btnbranspaneli.Click += new System.EventHandler(this.btnbranspaneli_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(19, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(994, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwbranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwdoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuruolustur;
        private System.Windows.Forms.RichTextBox rchtxtduyurular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox msktxttc;
        private System.Windows.Forms.MaskedTextBox msktxttarih;
        private System.Windows.Forms.MaskedTextBox msktxtsaat;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgrdwbranslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgrdwdoktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnrandevulistesi;
        private System.Windows.Forms.Button btndoktorpaneli;
        private System.Windows.Forms.Button btnbranspaneli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}