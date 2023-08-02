
namespace Hastane_Proje2
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrdvbranspaneli = new System.Windows.Forms.DataGridView();
            this.txtbransad = new System.Windows.Forms.TextBox();
            this.txtbransid = new System.Windows.Forms.TextBox();
            this.lblhastasoyad = new System.Windows.Forms.Label();
            this.lblhastaad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvbranspaneli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Lime;
            this.btnguncelle.Location = new System.Drawing.Point(64, 279);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(125, 58);
            this.btnguncelle.TabIndex = 51;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Yellow;
            this.btnsil.Location = new System.Drawing.Point(236, 207);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(125, 58);
            this.btnsil.TabIndex = 50;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnekle.Location = new System.Drawing.Point(64, 207);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(125, 58);
            this.btnekle.TabIndex = 49;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 48;
            this.label1.Text = "Branş Paneli";
            // 
            // dgrdvbranspaneli
            // 
            this.dgrdvbranspaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdvbranspaneli.Location = new System.Drawing.Point(410, 84);
            this.dgrdvbranspaneli.Name = "dgrdvbranspaneli";
            this.dgrdvbranspaneli.RowHeadersWidth = 51;
            this.dgrdvbranspaneli.RowTemplate.Height = 24;
            this.dgrdvbranspaneli.Size = new System.Drawing.Size(369, 264);
            this.dgrdvbranspaneli.TabIndex = 47;
            this.dgrdvbranspaneli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdvbranspaneli_CellClick);
            // 
            // txtbransad
            // 
            this.txtbransad.Location = new System.Drawing.Point(129, 140);
            this.txtbransad.Name = "txtbransad";
            this.txtbransad.Size = new System.Drawing.Size(245, 22);
            this.txtbransad.TabIndex = 45;
            // 
            // txtbransid
            // 
            this.txtbransid.Location = new System.Drawing.Point(129, 88);
            this.txtbransid.Name = "txtbransid";
            this.txtbransid.Size = new System.Drawing.Size(245, 22);
            this.txtbransid.TabIndex = 44;
            // 
            // lblhastasoyad
            // 
            this.lblhastasoyad.AutoSize = true;
            this.lblhastasoyad.Location = new System.Drawing.Point(41, 145);
            this.lblhastasoyad.Name = "lblhastasoyad";
            this.lblhastasoyad.Size = new System.Drawing.Size(70, 17);
            this.lblhastasoyad.TabIndex = 43;
            this.lblhastasoyad.Text = "Branş Ad:";
            // 
            // lblhastaad
            // 
            this.lblhastaad.AutoSize = true;
            this.lblhastaad.Location = new System.Drawing.Point(47, 91);
            this.lblhastaad.Name = "lblhastaad";
            this.lblhastaad.Size = new System.Drawing.Size(64, 17);
            this.lblhastaad.TabIndex = 42;
            this.lblhastaad.Text = "Branş İd:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(236, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 52;
            this.button1.Text = "Sayfa Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(802, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrdvbranspaneli);
            this.Controls.Add(this.txtbransad);
            this.Controls.Add(this.txtbransid);
            this.Controls.Add(this.lblhastasoyad);
            this.Controls.Add(this.lblhastaad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBrans";
            this.Text = "FrmBrans";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdvbranspaneli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrdvbranspaneli;
        private System.Windows.Forms.TextBox txtbransad;
        private System.Windows.Forms.TextBox txtbransid;
        private System.Windows.Forms.Label lblhastasoyad;
        private System.Windows.Forms.Label lblhastaad;
        private System.Windows.Forms.Button button1;
    }
}