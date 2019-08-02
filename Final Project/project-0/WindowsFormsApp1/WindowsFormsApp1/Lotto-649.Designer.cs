namespace WindowsFormsApp1
{
    partial class Lotto_649
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
            this.lotto2Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lotto1Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lotto2Exit
            // 
            this.lotto2Exit.Location = new System.Drawing.Point(354, 205);
            this.lotto2Exit.Name = "lotto2Exit";
            this.lotto2Exit.Size = new System.Drawing.Size(93, 41);
            this.lotto2Exit.TabIndex = 13;
            this.lotto2Exit.Text = "E&xit";
            this.lotto2Exit.UseVisualStyleBackColor = true;
            this.lotto2Exit.Click += new System.EventHandler(this.lotto2Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 179);
            this.textBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "&Read File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "The Winnings Numbers are:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lotto1Exit
            // 
            this.lotto1Exit.Location = new System.Drawing.Point(529, 337);
            this.lotto1Exit.Name = "lotto1Exit";
            this.lotto1Exit.Size = new System.Drawing.Size(93, 41);
            this.lotto1Exit.TabIndex = 19;
            this.lotto1Exit.Text = "E&xit";
            this.lotto1Exit.UseVisualStyleBackColor = true;
            this.lotto1Exit.Click += new System.EventHandler(this.lotto1Exit_Click);
            // 
            // Lotto_649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lotto1Exit);
            this.Controls.Add(this.lotto2Exit);
            this.Name = "Lotto_649";
            this.Text = "Lotto_649";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lotto2Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lotto1Exit;
    }
}