namespace tema_14_gorodskoy_sovet
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbPokitika = new System.Windows.Forms.RadioButton();
            this.rbstort = new System.Windows.Forms.RadioButton();
            this.rdNovosti_goroda = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предложине вашу новость ниже";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 239);
            this.textBox1.TabIndex = 2;
            // 
            // rbPokitika
            // 
            this.rbPokitika.AutoSize = true;
            this.rbPokitika.Location = new System.Drawing.Point(60, 341);
            this.rbPokitika.Name = "rbPokitika";
            this.rbPokitika.Size = new System.Drawing.Size(74, 17);
            this.rbPokitika.TabIndex = 3;
            this.rbPokitika.TabStop = true;
            this.rbPokitika.Text = "Политика";
            this.rbPokitika.UseVisualStyleBackColor = true;
            // 
            // rbstort
            // 
            this.rbstort.AutoSize = true;
            this.rbstort.Location = new System.Drawing.Point(60, 364);
            this.rbstort.Name = "rbstort";
            this.rbstort.Size = new System.Drawing.Size(55, 17);
            this.rbstort.TabIndex = 4;
            this.rbstort.TabStop = true;
            this.rbstort.Text = "Спорт";
            this.rbstort.UseVisualStyleBackColor = true;
            // 
            // rdNovosti_goroda
            // 
            this.rdNovosti_goroda.AutoSize = true;
            this.rdNovosti_goroda.Location = new System.Drawing.Point(60, 387);
            this.rdNovosti_goroda.Name = "rdNovosti_goroda";
            this.rdNovosti_goroda.Size = new System.Drawing.Size(106, 17);
            this.rdNovosti_goroda.TabIndex = 5;
            this.rdNovosti_goroda.TabStop = true;
            this.rdNovosti_goroda.Text = "Новости города";
            this.rdNovosti_goroda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип новости";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdNovosti_goroda);
            this.Controls.Add(this.rbstort);
            this.Controls.Add(this.rbPokitika);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbPokitika;
        private System.Windows.Forms.RadioButton rbstort;
        private System.Windows.Forms.RadioButton rdNovosti_goroda;
        private System.Windows.Forms.Label label2;
    }
}