namespace DS1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtregion = new System.Windows.Forms.TextBox();
            this.temp_min = new System.Windows.Forms.TextBox();
            this.temp_max = new System.Windows.Forms.TextBox();
            this.prec_max = new System.Windows.Forms.TextBox();
            this.prec_min = new System.Windows.Forms.TextBox();
            this.Affiche_btn = new System.Windows.Forms.Button();
            this.enregistrer_btn = new System.Windows.Forms.Button();
            this.bulletin = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(48, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(48, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precipitation max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(48, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precipitation min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(48, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bulletin";
            // 
            // txtregion
            // 
            this.txtregion.Location = new System.Drawing.Point(247, 64);
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(210, 22);
            this.txtregion.TabIndex = 6;
            this.txtregion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtregion_KeyPress);
            // 
            // temp_min
            // 
            this.temp_min.Location = new System.Drawing.Point(247, 152);
            this.temp_min.Name = "temp_min";
            this.temp_min.Size = new System.Drawing.Size(210, 22);
            this.temp_min.TabIndex = 7;
            this.temp_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_min_KeyPress);
            // 
            // temp_max
            // 
            this.temp_max.Location = new System.Drawing.Point(247, 109);
            this.temp_max.Name = "temp_max";
            this.temp_max.Size = new System.Drawing.Size(210, 22);
            this.temp_max.TabIndex = 8;
            this.temp_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_max_KeyPress);
            // 
            // prec_max
            // 
            this.prec_max.Location = new System.Drawing.Point(247, 190);
            this.prec_max.Name = "prec_max";
            this.prec_max.Size = new System.Drawing.Size(210, 22);
            this.prec_max.TabIndex = 9;
            this.prec_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prec_max_KeyPress);
            // 
            // prec_min
            // 
            this.prec_min.Location = new System.Drawing.Point(247, 238);
            this.prec_min.Name = "prec_min";
            this.prec_min.Size = new System.Drawing.Size(210, 22);
            this.prec_min.TabIndex = 10;
            this.prec_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prec_min_KeyPress);
            // 
            // Affiche_btn
            // 
            this.Affiche_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Affiche_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affiche_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Affiche_btn.Location = new System.Drawing.Point(512, 64);
            this.Affiche_btn.Name = "Affiche_btn";
            this.Affiche_btn.Size = new System.Drawing.Size(163, 33);
            this.Affiche_btn.TabIndex = 11;
            this.Affiche_btn.Text = "Afficher";
            this.Affiche_btn.UseVisualStyleBackColor = false;
            this.Affiche_btn.Click += new System.EventHandler(this.Affiche_btn_Click);
            // 
            // enregistrer_btn
            // 
            this.enregistrer_btn.BackColor = System.Drawing.Color.DarkRed;
            this.enregistrer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enregistrer_btn.Location = new System.Drawing.Point(267, 276);
            this.enregistrer_btn.Name = "enregistrer_btn";
            this.enregistrer_btn.Size = new System.Drawing.Size(163, 33);
            this.enregistrer_btn.TabIndex = 12;
            this.enregistrer_btn.Text = "Enregistrer";
            this.enregistrer_btn.UseVisualStyleBackColor = false;
            this.enregistrer_btn.Click += new System.EventHandler(this.enregistrer_btn_Click);
            // 
            // bulletin
            // 
            this.bulletin.FormattingEnabled = true;
            this.bulletin.ItemHeight = 16;
            this.bulletin.Location = new System.Drawing.Point(53, 349);
            this.bulletin.Name = "bulletin";
            this.bulletin.Size = new System.Drawing.Size(622, 212);
            this.bulletin.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(512, 192);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(512, 236);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bulletin);
            this.Controls.Add(this.enregistrer_btn);
            this.Controls.Add(this.Affiche_btn);
            this.Controls.Add(this.prec_min);
            this.Controls.Add(this.prec_max);
            this.Controls.Add(this.temp_max);
            this.Controls.Add(this.temp_min);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Centre national de meteologie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtregion;
        private System.Windows.Forms.TextBox temp_min;
        private System.Windows.Forms.TextBox temp_max;
        private System.Windows.Forms.TextBox prec_max;
        private System.Windows.Forms.TextBox prec_min;
        private System.Windows.Forms.Button Affiche_btn;
        private System.Windows.Forms.Button enregistrer_btn;
        private System.Windows.Forms.ListBox bulletin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
    }
}

