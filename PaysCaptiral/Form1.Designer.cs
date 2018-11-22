namespace PaysCaptiral
{
    partial class pays
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pay = new System.Windows.Forms.ListBox();
            this.TextPay = new System.Windows.Forms.TextBox();
            this.capital = new System.Windows.Forms.ListBox();
            this.TextCapit = new System.Windows.Forms.TextBox();
            this.Ajout = new System.Windows.Forms.Button();
            this.Supression = new System.Windows.Forms.Button();
            this.Sauvegarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pay
            // 
            this.pay.FormattingEnabled = true;
            this.pay.Location = new System.Drawing.Point(82, 36);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(180, 238);
            this.pay.TabIndex = 0;
            this.pay.SelectedIndexChanged += new System.EventHandler(this.pay_SelectedIndexChanged);
            // 
            // TextPay
            // 
            this.TextPay.Location = new System.Drawing.Point(82, 316);
            this.TextPay.Name = "TextPay";
            this.TextPay.Size = new System.Drawing.Size(180, 20);
            this.TextPay.TabIndex = 1;
            // 
            // capital
            // 
            this.capital.FormattingEnabled = true;
            this.capital.Location = new System.Drawing.Point(408, 36);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(175, 238);
            this.capital.TabIndex = 2;
            // 
            // TextCapit
            // 
            this.TextCapit.Location = new System.Drawing.Point(408, 316);
            this.TextCapit.Name = "TextCapit";
            this.TextCapit.Size = new System.Drawing.Size(175, 20);
            this.TextCapit.TabIndex = 3;
            // 
            // Ajout
            // 
            this.Ajout.Location = new System.Drawing.Point(293, 71);
            this.Ajout.Name = "Ajout";
            this.Ajout.Size = new System.Drawing.Size(75, 23);
            this.Ajout.TabIndex = 4;
            this.Ajout.Text = "Ajout";
            this.Ajout.UseVisualStyleBackColor = true;
            this.Ajout.Click += new System.EventHandler(this.Ajout_Click);
            // 
            // Supression
            // 
            this.Supression.Location = new System.Drawing.Point(293, 100);
            this.Supression.Name = "Supression";
            this.Supression.Size = new System.Drawing.Size(75, 23);
            this.Supression.TabIndex = 5;
            this.Supression.Text = "Supression";
            this.Supression.UseVisualStyleBackColor = true;
            this.Supression.Click += new System.EventHandler(this.Supression_Click);
            // 
            // Sauvegarde
            // 
            this.Sauvegarde.Location = new System.Drawing.Point(293, 171);
            this.Sauvegarde.Name = "Sauvegarde";
            this.Sauvegarde.Size = new System.Drawing.Size(75, 23);
            this.Sauvegarde.TabIndex = 6;
            this.Sauvegarde.Text = "Sauvegarde";
            this.Sauvegarde.UseVisualStyleBackColor = true;
            this.Sauvegarde.Click += new System.EventHandler(this.Sauvegarde_Click);
            // 
            // pays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sauvegarde);
            this.Controls.Add(this.Supression);
            this.Controls.Add(this.Ajout);
            this.Controls.Add(this.TextCapit);
            this.Controls.Add(this.capital);
            this.Controls.Add(this.TextPay);
            this.Controls.Add(this.pay);
            this.Name = "pays";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pay;
        private System.Windows.Forms.TextBox TextPay;
        private System.Windows.Forms.ListBox capital;
        private System.Windows.Forms.TextBox TextCapit;
        private System.Windows.Forms.Button Ajout;
        private System.Windows.Forms.Button Supression;
        private System.Windows.Forms.Button Sauvegarde;
    }
}

