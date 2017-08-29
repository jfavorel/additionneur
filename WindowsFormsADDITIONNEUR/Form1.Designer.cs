namespace WindowsFormsADDITIONNEUR
{
    partial class FormAdditionneur
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_default = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bt_vider = new System.Windows.Forms.Button();
            this.bt_calculer = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(284, 92);
            this.textBox1.TabIndex = 0;
            // 
            // bt_default
            // 
            this.bt_default.AccessibleDescription = "";
            this.bt_default.Location = new System.Drawing.Point(23, 130);
            this.bt_default.Name = "bt_default";
            this.bt_default.Size = new System.Drawing.Size(30, 30);
            this.bt_default.TabIndex = 1;
            this.bt_default.Text = "0";
            this.bt_default.UseVisualStyleBackColor = true;
            this.bt_default.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(247, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(135, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(79, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 6;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // bt_vider
            // 
            this.bt_vider.Location = new System.Drawing.Point(23, 252);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(75, 23);
            this.bt_vider.TabIndex = 11;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = true;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // bt_calculer
            // 
            this.bt_calculer.Location = new System.Drawing.Point(201, 251);
            this.bt_calculer.Name = "bt_calculer";
            this.bt_calculer.Size = new System.Drawing.Size(75, 23);
            this.bt_calculer.TabIndex = 12;
            this.bt_calculer.Text = "Calculer";
            this.bt_calculer.UseVisualStyleBackColor = true;
            this.bt_calculer.Click += new System.EventHandler(this.bt_calculer_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(112, 220);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // FormAdditionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsADDITIONNEUR.Properties.Resources.maths_ftr;
            this.ClientSize = new System.Drawing.Size(308, 302);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bt_calculer);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_default);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAdditionneur";
            this.ShowIcon = false;
            this.Text = "L’ADDITIONNEUR";
            this.Load += new System.EventHandler(this.FormAdditionneur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_default;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button bt_vider;
        private System.Windows.Forms.Button bt_calculer;
        private System.Windows.Forms.Button button10;
    }
}

