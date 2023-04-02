namespace Hastane_Otomasyonu
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnHastaGirisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(612, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Saira Stencil One", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(78, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 92);
            this.label4.TabIndex = 6;
            this.label4.Text = "SH Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyonu.Properties.Resources.Lovepik_com_401563532_hospital;
            this.pictureBox1.Location = new System.Drawing.Point(496, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.BackgroundImage = global::Hastane_Otomasyonu.Properties.Resources.png_clipart_computer_icons_desktop_maid_cartoon_service_cartoon;
            this.BtnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(536, 204);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(259, 195);
            this.BtnSekreterGirisi.TabIndex = 2;
            this.BtnSekreterGirisi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDoktorGirisi.BackgroundImage = global::Hastane_Otomasyonu.Properties.Resources.indir;
            this.BtnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(271, 204);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(259, 195);
            this.BtnDoktorGirisi.TabIndex = 1;
            this.BtnDoktorGirisi.UseVisualStyleBackColor = false;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.BackgroundImage = global::Hastane_Otomasyonu.Properties.Resources.People_Patient_Male_icon;
            this.BtnHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGirisi.Location = new System.Drawing.Point(6, 204);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(259, 195);
            this.BtnHastaGirisi.TabIndex = 0;
            this.BtnHastaGirisi.UseVisualStyleBackColor = true;
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

