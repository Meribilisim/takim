namespace takim
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
            this.btnGalatasaray = new System.Windows.Forms.Button();
            this.btnTürkiye = new System.Windows.Forms.Button();
            this.btnBesiktas = new System.Windows.Forms.Button();
            this.btnFener = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGalatasaray
            // 
            this.btnGalatasaray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGalatasaray.Location = new System.Drawing.Point(49, 125);
            this.btnGalatasaray.Name = "btnGalatasaray";
            this.btnGalatasaray.Size = new System.Drawing.Size(150, 66);
            this.btnGalatasaray.TabIndex = 0;
            this.btnGalatasaray.Text = "Galatasaray";
            this.btnGalatasaray.UseVisualStyleBackColor = true;
            this.btnGalatasaray.Click += new System.EventHandler(this.btnGalatasaray_Click);
            // 
            // btnTürkiye
            // 
            this.btnTürkiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTürkiye.Location = new System.Drawing.Point(49, 28);
            this.btnTürkiye.Name = "btnTürkiye";
            this.btnTürkiye.Size = new System.Drawing.Size(150, 75);
            this.btnTürkiye.TabIndex = 1;
            this.btnTürkiye.Text = "Türkiye";
            this.btnTürkiye.UseVisualStyleBackColor = true;
            this.btnTürkiye.Click += new System.EventHandler(this.btTürkiye_Click);
            // 
            // btnBesiktas
            // 
            this.btnBesiktas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBesiktas.Location = new System.Drawing.Point(49, 215);
            this.btnBesiktas.Name = "btnBesiktas";
            this.btnBesiktas.Size = new System.Drawing.Size(150, 78);
            this.btnBesiktas.TabIndex = 2;
            this.btnBesiktas.Text = "Beşiktaş";
            this.btnBesiktas.UseVisualStyleBackColor = true;
            this.btnBesiktas.Click += new System.EventHandler(this.btnBesiktas_Click);
            // 
            // btnFener
            // 
            this.btnFener.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFener.Location = new System.Drawing.Point(49, 317);
            this.btnFener.Name = "btnFener";
            this.btnFener.Size = new System.Drawing.Size(150, 77);
            this.btnFener.TabIndex = 3;
            this.btnFener.Text = "Fenerbahçe";
            this.btnFener.UseVisualStyleBackColor = true;
            this.btnFener.Click += new System.EventHandler(this.btnFener_Click);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakim.Location = new System.Drawing.Point(325, 171);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(106, 37);
            this.lblTakim.TabIndex = 4;
            this.lblTakim.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btnFener);
            this.Controls.Add(this.btnBesiktas);
            this.Controls.Add(this.btnTürkiye);
            this.Controls.Add(this.btnGalatasaray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGalatasaray;
        private System.Windows.Forms.Button btnTürkiye;
        private System.Windows.Forms.Button btnBesiktas;
        private System.Windows.Forms.Button btnFener;
        private System.Windows.Forms.Label lblTakim;
    }
}

