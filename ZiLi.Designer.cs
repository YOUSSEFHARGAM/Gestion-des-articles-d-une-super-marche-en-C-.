namespace Myregex
{
    partial class ZiLi
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
            this.TResultat = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.Tcomand = new System.Windows.Forms.TextBox();
            this.TArticles = new System.Windows.Forms.Label();
            this.LResultat = new System.Windows.Forms.Label();
            this.LDH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TResultat
            // 
            this.TResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TResultat.ForeColor = System.Drawing.Color.Red;
            this.TResultat.Location = new System.Drawing.Point(260, 315);
            this.TResultat.Name = "TResultat";
            this.TResultat.Size = new System.Drawing.Size(127, 22);
            this.TResultat.TabIndex = 13;
            this.TResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.Black;
            this.Valider.Location = new System.Drawing.Point(525, 262);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(104, 26);
            this.Valider.TabIndex = 12;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Tcomand
            // 
            this.Tcomand.BackColor = System.Drawing.Color.White;
            this.Tcomand.Location = new System.Drawing.Point(90, 82);
            this.Tcomand.Multiline = true;
            this.Tcomand.Name = "Tcomand";
            this.Tcomand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tcomand.Size = new System.Drawing.Size(539, 159);
            this.Tcomand.TabIndex = 11;
            this.Tcomand.TextChanged += new System.EventHandler(this.Tcomand_TextChanged);
            // 
            // TArticles
            // 
            this.TArticles.AutoSize = true;
            this.TArticles.BackColor = System.Drawing.Color.Transparent;
            this.TArticles.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TArticles.ForeColor = System.Drawing.Color.AliceBlue;
            this.TArticles.Location = new System.Drawing.Point(12, 82);
            this.TArticles.Name = "TArticles";
            this.TArticles.Size = new System.Drawing.Size(64, 22);
            this.TArticles.TabIndex = 14;
            this.TArticles.Text = "Articles";
            // 
            // LResultat
            // 
            this.LResultat.AutoSize = true;
            this.LResultat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultat.ForeColor = System.Drawing.Color.White;
            this.LResultat.Location = new System.Drawing.Point(160, 314);
            this.LResultat.Name = "LResultat";
            this.LResultat.Size = new System.Drawing.Size(68, 22);
            this.LResultat.TabIndex = 15;
            this.LResultat.Text = "Resultat";
            // 
            // LDH
            // 
            this.LDH.AutoSize = true;
            this.LDH.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDH.ForeColor = System.Drawing.Color.AliceBlue;
            this.LDH.Location = new System.Drawing.Point(410, 315);
            this.LDH.Name = "LDH";
            this.LDH.Size = new System.Drawing.Size(36, 22);
            this.LDH.TabIndex = 16;
            this.LDH.Text = "DH";
            // 
            // ZiLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(702, 447);
            this.Controls.Add(this.LDH);
            this.Controls.Add(this.LResultat);
            this.Controls.Add(this.TArticles);
            this.Controls.Add(this.TResultat);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Tcomand);
            this.Name = "ZiLi";
            this.Text = "ZiLi";
            this.Load += new System.EventHandler(this.ZiLi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TResultat;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox Tcomand;
        private System.Windows.Forms.Label TArticles;
        private System.Windows.Forms.Label LResultat;
        private System.Windows.Forms.Label LDH;
    }
}