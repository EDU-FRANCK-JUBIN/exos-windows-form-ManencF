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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_CE = new System.Windows.Forms.Button();
            this.bt_C = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_multiple = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_soustraction = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_addition = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_egal = new System.Windows.Forms.Button();
            this.bt_virgule = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_mystery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 115);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_CE
            // 
            this.bt_CE.Location = new System.Drawing.Point(52, 188);
            this.bt_CE.Name = "bt_CE";
            this.bt_CE.Size = new System.Drawing.Size(56, 43);
            this.bt_CE.TabIndex = 1;
            this.bt_CE.Text = "CE";
            this.bt_CE.UseVisualStyleBackColor = true;
            this.bt_CE.Click += new System.EventHandler(this.bt_CE_Click);
            // 
            // bt_C
            // 
            this.bt_C.Location = new System.Drawing.Point(153, 188);
            this.bt_C.Name = "bt_C";
            this.bt_C.Size = new System.Drawing.Size(56, 43);
            this.bt_C.TabIndex = 2;
            this.bt_C.Text = "C";
            this.bt_C.UseVisualStyleBackColor = true;
            this.bt_C.Click += new System.EventHandler(this.bt_C_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(259, 188);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(56, 43);
            this.bt_remove.TabIndex = 3;
            this.bt_remove.Text = "<--";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_div
            // 
            this.bt_div.Location = new System.Drawing.Point(346, 188);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(56, 43);
            this.bt_div.TabIndex = 4;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_multiple
            // 
            this.bt_multiple.Location = new System.Drawing.Point(346, 264);
            this.bt_multiple.Name = "bt_multiple";
            this.bt_multiple.Size = new System.Drawing.Size(56, 43);
            this.bt_multiple.TabIndex = 8;
            this.bt_multiple.Text = "*";
            this.bt_multiple.UseVisualStyleBackColor = true;
            this.bt_multiple.Click += new System.EventHandler(this.bt_multiple_Click);
            // 
            // bt_9
            // 
            this.bt_9.Location = new System.Drawing.Point(259, 264);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(56, 43);
            this.bt_9.TabIndex = 7;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = true;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.Location = new System.Drawing.Point(153, 264);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(56, 43);
            this.bt_8.TabIndex = 6;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = true;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(52, 264);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(56, 43);
            this.bt_7.TabIndex = 5;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_soustraction
            // 
            this.bt_soustraction.Location = new System.Drawing.Point(346, 329);
            this.bt_soustraction.Name = "bt_soustraction";
            this.bt_soustraction.Size = new System.Drawing.Size(56, 43);
            this.bt_soustraction.TabIndex = 12;
            this.bt_soustraction.Text = "-";
            this.bt_soustraction.UseVisualStyleBackColor = true;
            this.bt_soustraction.Click += new System.EventHandler(this.bt_soustraction_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(259, 329);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(56, 43);
            this.bt_6.TabIndex = 11;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(153, 329);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(56, 43);
            this.bt_5.TabIndex = 10;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(52, 329);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(56, 43);
            this.bt_4.TabIndex = 9;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_addition
            // 
            this.bt_addition.Location = new System.Drawing.Point(346, 395);
            this.bt_addition.Name = "bt_addition";
            this.bt_addition.Size = new System.Drawing.Size(56, 43);
            this.bt_addition.TabIndex = 16;
            this.bt_addition.Text = "+";
            this.bt_addition.UseVisualStyleBackColor = true;
            this.bt_addition.Click += new System.EventHandler(this.bt_addition_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(259, 395);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(56, 43);
            this.bt_3.TabIndex = 15;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(153, 395);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(56, 43);
            this.bt_2.TabIndex = 14;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(52, 395);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(56, 43);
            this.bt_1.TabIndex = 13;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_egal
            // 
            this.bt_egal.Location = new System.Drawing.Point(346, 470);
            this.bt_egal.Name = "bt_egal";
            this.bt_egal.Size = new System.Drawing.Size(56, 43);
            this.bt_egal.TabIndex = 20;
            this.bt_egal.Text = "=";
            this.bt_egal.UseVisualStyleBackColor = true;
            this.bt_egal.Click += new System.EventHandler(this.bt_egal_Click);
            // 
            // bt_virgule
            // 
            this.bt_virgule.Location = new System.Drawing.Point(259, 470);
            this.bt_virgule.Name = "bt_virgule";
            this.bt_virgule.Size = new System.Drawing.Size(56, 43);
            this.bt_virgule.TabIndex = 19;
            this.bt_virgule.Text = ",";
            this.bt_virgule.UseVisualStyleBackColor = true;
            this.bt_virgule.Click += new System.EventHandler(this.bt_virgule_Click);
            // 
            // bt_0
            // 
            this.bt_0.Location = new System.Drawing.Point(153, 470);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(56, 43);
            this.bt_0.TabIndex = 18;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = true;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_mystery
            // 
            this.bt_mystery.Location = new System.Drawing.Point(52, 470);
            this.bt_mystery.Name = "bt_mystery";
            this.bt_mystery.Size = new System.Drawing.Size(56, 43);
            this.bt_mystery.TabIndex = 17;
            this.bt_mystery.Text = "+-";
            this.bt_mystery.UseVisualStyleBackColor = true;
            this.bt_mystery.Click += new System.EventHandler(this.bt_mystery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_egal);
            this.Controls.Add(this.bt_virgule);
            this.Controls.Add(this.bt_0);
            this.Controls.Add(this.bt_mystery);
            this.Controls.Add(this.bt_addition);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Controls.Add(this.bt_soustraction);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_multiple);
            this.Controls.Add(this.bt_9);
            this.Controls.Add(this.bt_8);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_C);
            this.Controls.Add(this.bt_CE);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_CE;
        private System.Windows.Forms.Button bt_C;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_multiple;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_soustraction;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_addition;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_egal;
        private System.Windows.Forms.Button bt_virgule;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_mystery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

