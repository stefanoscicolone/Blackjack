namespace BlackJackScicolone
{
    partial class FormBlackJack
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
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblGiocatore = new System.Windows.Forms.Label();
            this.lblPuntiDealer = new System.Windows.Forms.Label();
            this.lblPuntiGiocatore = new System.Windows.Forms.Label();
            this.ptbCartaG1 = new System.Windows.Forms.PictureBox();
            this.ptbCartaG2 = new System.Windows.Forms.PictureBox();
            this.ptbCartaD1 = new System.Windows.Forms.PictureBox();
            this.ptbCartaD2 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.ptbCartaG3 = new System.Windows.Forms.PictureBox();
            this.ptbCartaD3 = new System.Windows.Forms.PictureBox();
            this.ptbCartaG4 = new System.Windows.Forms.PictureBox();
            this.ptbCartaD4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(79, 63);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(68, 13);
            this.lblDealer.TabIndex = 0;
            this.lblDealer.Text = "Punti Dealer:";
            // 
            // lblGiocatore
            // 
            this.lblGiocatore.AutoSize = true;
            this.lblGiocatore.Location = new System.Drawing.Point(79, 237);
            this.lblGiocatore.Name = "lblGiocatore";
            this.lblGiocatore.Size = new System.Drawing.Size(83, 13);
            this.lblGiocatore.TabIndex = 1;
            this.lblGiocatore.Text = "Punti Giocatore:";
            // 
            // lblPuntiDealer
            // 
            this.lblPuntiDealer.AutoSize = true;
            this.lblPuntiDealer.Location = new System.Drawing.Point(147, 63);
            this.lblPuntiDealer.Name = "lblPuntiDealer";
            this.lblPuntiDealer.Size = new System.Drawing.Size(0, 13);
            this.lblPuntiDealer.TabIndex = 2;
            // 
            // lblPuntiGiocatore
            // 
            this.lblPuntiGiocatore.AutoSize = true;
            this.lblPuntiGiocatore.Location = new System.Drawing.Point(168, 237);
            this.lblPuntiGiocatore.Name = "lblPuntiGiocatore";
            this.lblPuntiGiocatore.Size = new System.Drawing.Size(0, 13);
            this.lblPuntiGiocatore.TabIndex = 3;
            // 
            // ptbCartaG1
            // 
            this.ptbCartaG1.Location = new System.Drawing.Point(82, 254);
            this.ptbCartaG1.Name = "ptbCartaG1";
            this.ptbCartaG1.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaG1.TabIndex = 4;
            this.ptbCartaG1.TabStop = false;
            // 
            // ptbCartaG2
            // 
            this.ptbCartaG2.Location = new System.Drawing.Point(159, 254);
            this.ptbCartaG2.Name = "ptbCartaG2";
            this.ptbCartaG2.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaG2.TabIndex = 5;
            this.ptbCartaG2.TabStop = false;
            // 
            // ptbCartaD1
            // 
            this.ptbCartaD1.Location = new System.Drawing.Point(82, 79);
            this.ptbCartaD1.Name = "ptbCartaD1";
            this.ptbCartaD1.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaD1.TabIndex = 9;
            this.ptbCartaD1.TabStop = false;
            // 
            // ptbCartaD2
            // 
            this.ptbCartaD2.Location = new System.Drawing.Point(159, 79);
            this.ptbCartaD2.Name = "ptbCartaD2";
            this.ptbCartaD2.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaD2.TabIndex = 10;
            this.ptbCartaD2.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(82, 386);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(148, 51);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(313, 386);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(148, 51);
            this.btnStand.TabIndex = 16;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // ptbCartaG3
            // 
            this.ptbCartaG3.Location = new System.Drawing.Point(236, 254);
            this.ptbCartaG3.Name = "ptbCartaG3";
            this.ptbCartaG3.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaG3.TabIndex = 17;
            this.ptbCartaG3.TabStop = false;
            // 
            // ptbCartaD3
            // 
            this.ptbCartaD3.Location = new System.Drawing.Point(236, 79);
            this.ptbCartaD3.Name = "ptbCartaD3";
            this.ptbCartaD3.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaD3.TabIndex = 18;
            this.ptbCartaD3.TabStop = false;
            // 
            // ptbCartaG4
            // 
            this.ptbCartaG4.Location = new System.Drawing.Point(313, 254);
            this.ptbCartaG4.Name = "ptbCartaG4";
            this.ptbCartaG4.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaG4.TabIndex = 19;
            this.ptbCartaG4.TabStop = false;
            // 
            // ptbCartaD4
            // 
            this.ptbCartaD4.Location = new System.Drawing.Point(313, 79);
            this.ptbCartaD4.Name = "ptbCartaD4";
            this.ptbCartaD4.Size = new System.Drawing.Size(71, 96);
            this.ptbCartaD4.TabIndex = 20;
            this.ptbCartaD4.TabStop = false;
            // 
            // FormBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(672, 462);
            this.Controls.Add(this.ptbCartaD4);
            this.Controls.Add(this.ptbCartaG4);
            this.Controls.Add(this.ptbCartaD3);
            this.Controls.Add(this.ptbCartaG3);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.ptbCartaD2);
            this.Controls.Add(this.ptbCartaD1);
            this.Controls.Add(this.ptbCartaG2);
            this.Controls.Add(this.ptbCartaG1);
            this.Controls.Add(this.lblPuntiGiocatore);
            this.Controls.Add(this.lblPuntiDealer);
            this.Controls.Add(this.lblGiocatore);
            this.Controls.Add(this.lblDealer);
            this.Name = "FormBlackJack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaG4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCartaD4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblGiocatore;
        private System.Windows.Forms.Label lblPuntiDealer;
        private System.Windows.Forms.Label lblPuntiGiocatore;
        private System.Windows.Forms.PictureBox ptbCartaG1;
        private System.Windows.Forms.PictureBox ptbCartaG2;
        private System.Windows.Forms.PictureBox ptbCartaD1;
        private System.Windows.Forms.PictureBox ptbCartaD2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox ptbCartaG3;
        private System.Windows.Forms.PictureBox ptbCartaD3;
        private System.Windows.Forms.PictureBox ptbCartaG4;
        private System.Windows.Forms.PictureBox ptbCartaD4;
    }
}

