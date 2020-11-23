namespace WA_GiocoMacchineBGW
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pct_car1 = new System.Windows.Forms.PictureBox();
            this.pct_car2 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.pct_traguardo = new System.Windows.Forms.PictureBox();
            this.txt_ngiri = new System.Windows.Forms.TextBox();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_traguardo)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_car1
            // 
            this.pct_car1.BackColor = System.Drawing.Color.Transparent;
            this.pct_car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pct_car1.Image = global::WA_GiocoMacchineBGW.Properties.Resources.macchinabianca;
            this.pct_car1.Location = new System.Drawing.Point(12, 23);
            this.pct_car1.Name = "pct_car1";
            this.pct_car1.Size = new System.Drawing.Size(89, 40);
            this.pct_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_car1.TabIndex = 0;
            this.pct_car1.TabStop = false;
            // 
            // pct_car2
            // 
            this.pct_car2.BackColor = System.Drawing.Color.Transparent;
            this.pct_car2.Image = global::WA_GiocoMacchineBGW.Properties.Resources.macchinarossa;
            this.pct_car2.Location = new System.Drawing.Point(12, 104);
            this.pct_car2.Name = "pct_car2";
            this.pct_car2.Size = new System.Drawing.Size(89, 40);
            this.pct_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_car2.TabIndex = 1;
            this.pct_car2.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.Location = new System.Drawing.Point(613, 1);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(69, 22);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pct_traguardo
            // 
            this.pct_traguardo.BackColor = System.Drawing.Color.Transparent;
            this.pct_traguardo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pct_traguardo.Image = global::WA_GiocoMacchineBGW.Properties.Resources.traguardo;
            this.pct_traguardo.Location = new System.Drawing.Point(782, 1);
            this.pct_traguardo.Name = "pct_traguardo";
            this.pct_traguardo.Size = new System.Drawing.Size(21, 156);
            this.pct_traguardo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_traguardo.TabIndex = 3;
            this.pct_traguardo.TabStop = false;
            // 
            // txt_ngiri
            // 
            this.txt_ngiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngiri.Location = new System.Drawing.Point(688, 1);
            this.txt_ngiri.Name = "txt_ngiri";
            this.txt_ngiri.ReadOnly = true;
            this.txt_ngiri.Size = new System.Drawing.Size(65, 22);
            this.txt_ngiri.TabIndex = 4;
            this.txt_ngiri.Text = "N.Giri:";
            this.txt_ngiri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(607, 1);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 23);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Visible = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(-5, -6);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(45, 23);
            this.btn_quit.TabIndex = 6;
            this.btn_quit.Text = "quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WA_GiocoMacchineBGW.Properties.Resources.road_trip_background_10864211;
            this.ClientSize = new System.Drawing.Size(800, 156);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.txt_ngiri);
            this.Controls.Add(this.pct_traguardo);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pct_car2);
            this.Controls.Add(this.pct_car1);
            this.MaximumSize = new System.Drawing.Size(816, 195);
            this.MinimumSize = new System.Drawing.Size(816, 195);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct_car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_traguardo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pct_car1;
        private System.Windows.Forms.PictureBox pct_car2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pct_traguardo;
        private System.Windows.Forms.TextBox txt_ngiri;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_quit;
    }
}

