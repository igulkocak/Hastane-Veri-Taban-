namespace Ocean_Hospital_VeriTabanı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.btnsekretergirisi = new System.Windows.Forms.Button();
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(561, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sekreter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(346, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 48);
            this.label2.TabIndex = 10;
            this.label2.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta";
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.BackgroundImage = global::Ocean_Hospital_VeriTabanı.Properties.Resources.images;
            this.btndoktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirisi.Location = new System.Drawing.Point(304, 107);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(196, 169);
            this.btndoktorgirisi.TabIndex = 8;
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // btnsekretergirisi
            // 
            this.btnsekretergirisi.BackgroundImage = global::Ocean_Hospital_VeriTabanı.Properties.Resources._950051;
            this.btnsekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirisi.Location = new System.Drawing.Point(532, 107);
            this.btnsekretergirisi.Name = "btnsekretergirisi";
            this.btnsekretergirisi.Size = new System.Drawing.Size(196, 169);
            this.btnsekretergirisi.TabIndex = 7;
            this.btnsekretergirisi.UseVisualStyleBackColor = true;
            this.btnsekretergirisi.Click += new System.EventHandler(this.btnsekretergirisi_Click);
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.BackgroundImage = global::Ocean_Hospital_VeriTabanı.Properties.Resources.patient_icon_png_21;
            this.btnhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirisi.Location = new System.Drawing.Point(73, 107);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(196, 169);
            this.btnhastagirisi.TabIndex = 6;
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.btnhastagirisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ocean_Hospital_VeriTabanı.Properties.Resources.Sağlığınız__en_büyük_hazineniz___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnsekretergirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Başlangıç Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Button btnsekretergirisi;
        private System.Windows.Forms.Button btnhastagirisi;
    }
}

