namespace Calculatrice
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Ecran = new System.Windows.Forms.TextBox();
            this.egal = new System.Windows.Forms.Button();
            this.soustraction = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Multipli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(490, 100);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(94, 75);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ecran
            // 
            this.Ecran.Location = new System.Drawing.Point(133, 41);
            this.Ecran.Name = "Ecran";
            this.Ecran.Size = new System.Drawing.Size(233, 20);
            this.Ecran.TabIndex = 4;
            this.Ecran.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // egal
            // 
            this.egal.Location = new System.Drawing.Point(266, 232);
            this.egal.Name = "egal";
            this.egal.Size = new System.Drawing.Size(115, 105);
            this.egal.TabIndex = 5;
            this.egal.Text = "=";
            this.egal.UseVisualStyleBackColor = true;
            this.egal.Click += new System.EventHandler(this.button5_Click);
            // 
            // soustraction
            // 
            this.soustraction.Location = new System.Drawing.Point(612, 100);
            this.soustraction.Name = "soustraction";
            this.soustraction.Size = new System.Drawing.Size(86, 77);
            this.soustraction.TabIndex = 6;
            this.soustraction.Text = "-";
            this.soustraction.UseVisualStyleBackColor = true;
            this.soustraction.Click += new System.EventHandler(this.soustraction_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(490, 347);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(85, 74);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Multipli
            // 
            this.Multipli.Location = new System.Drawing.Point(490, 200);
            this.Multipli.Name = "Multipli";
            this.Multipli.Size = new System.Drawing.Size(86, 72);
            this.Multipli.TabIndex = 8;
            this.Multipli.Text = "*";
            this.Multipli.UseVisualStyleBackColor = true;
            this.Multipli.Click += new System.EventHandler(this.Multipli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Multipli);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.soustraction);
            this.Controls.Add(this.egal);
            this.Controls.Add(this.Ecran);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.TextBox Ecran;
        private System.Windows.Forms.Button egal;
        private System.Windows.Forms.Button soustraction;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Multipli;
    }
}

