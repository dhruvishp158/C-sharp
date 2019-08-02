namespace WindowsFormsApp1
{
    partial class MoneyExchange
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
            this.moneyExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inr = new System.Windows.Forms.RadioButton();
            this.gbp = new System.Windows.Forms.RadioButton();
            this.eur = new System.Windows.Forms.RadioButton();
            this.usd = new System.Windows.Forms.RadioButton();
            this.cad = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inr2 = new System.Windows.Forms.RadioButton();
            this.gbp2 = new System.Windows.Forms.RadioButton();
            this.eur2 = new System.Windows.Forms.RadioButton();
            this.usd2 = new System.Windows.Forms.RadioButton();
            this.cad2 = new System.Windows.Forms.RadioButton();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // moneyExit
            // 
            this.moneyExit.Location = new System.Drawing.Point(520, 488);
            this.moneyExit.Name = "moneyExit";
            this.moneyExit.Size = new System.Drawing.Size(93, 41);
            this.moneyExit.TabIndex = 13;
            this.moneyExit.Text = "E&xit";
            this.moneyExit.UseVisualStyleBackColor = true;
            this.moneyExit.Click += new System.EventHandler(this.moneyExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Read File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "&Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inr);
            this.groupBox1.Controls.Add(this.gbp);
            this.groupBox1.Controls.Add(this.eur);
            this.groupBox1.Controls.Add(this.usd);
            this.groupBox1.Controls.Add(this.cad);
            this.groupBox1.Location = new System.Drawing.Point(132, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 319);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // inr
            // 
            this.inr.AutoSize = true;
            this.inr.Location = new System.Drawing.Point(67, 258);
            this.inr.Name = "inr";
            this.inr.Size = new System.Drawing.Size(62, 24);
            this.inr.TabIndex = 25;
            this.inr.TabStop = true;
            this.inr.Text = "INR";
            this.inr.UseVisualStyleBackColor = true;
            // 
            // gbp
            // 
            this.gbp.AutoSize = true;
            this.gbp.Location = new System.Drawing.Point(67, 204);
            this.gbp.Name = "gbp";
            this.gbp.Size = new System.Drawing.Size(68, 24);
            this.gbp.TabIndex = 24;
            this.gbp.TabStop = true;
            this.gbp.Text = "GBP";
            this.gbp.UseVisualStyleBackColor = true;
            // 
            // eur
            // 
            this.eur.AutoSize = true;
            this.eur.Location = new System.Drawing.Point(65, 146);
            this.eur.Name = "eur";
            this.eur.Size = new System.Drawing.Size(69, 24);
            this.eur.TabIndex = 23;
            this.eur.TabStop = true;
            this.eur.Text = "EUR";
            this.eur.UseVisualStyleBackColor = true;
            // 
            // usd
            // 
            this.usd.AutoSize = true;
            this.usd.Location = new System.Drawing.Point(65, 92);
            this.usd.Name = "usd";
            this.usd.Size = new System.Drawing.Size(69, 24);
            this.usd.TabIndex = 22;
            this.usd.TabStop = true;
            this.usd.Text = "USD";
            this.usd.UseVisualStyleBackColor = true;
            // 
            // cad
            // 
            this.cad.AutoSize = true;
            this.cad.Location = new System.Drawing.Point(65, 37);
            this.cad.Name = "cad";
            this.cad.Size = new System.Drawing.Size(68, 24);
            this.cad.TabIndex = 21;
            this.cad.TabStop = true;
            this.cad.Text = "CAD";
            this.cad.UseVisualStyleBackColor = true;
            this.cad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inr2);
            this.groupBox2.Controls.Add(this.gbp2);
            this.groupBox2.Controls.Add(this.eur2);
            this.groupBox2.Controls.Add(this.usd2);
            this.groupBox2.Controls.Add(this.cad2);
            this.groupBox2.Location = new System.Drawing.Point(434, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 319);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // inr2
            // 
            this.inr2.AutoSize = true;
            this.inr2.Location = new System.Drawing.Point(67, 258);
            this.inr2.Name = "inr2";
            this.inr2.Size = new System.Drawing.Size(62, 24);
            this.inr2.TabIndex = 25;
            this.inr2.TabStop = true;
            this.inr2.Text = "INR";
            this.inr2.UseVisualStyleBackColor = true;
            // 
            // gbp2
            // 
            this.gbp2.AutoSize = true;
            this.gbp2.Location = new System.Drawing.Point(67, 204);
            this.gbp2.Name = "gbp2";
            this.gbp2.Size = new System.Drawing.Size(68, 24);
            this.gbp2.TabIndex = 24;
            this.gbp2.TabStop = true;
            this.gbp2.Text = "GBP";
            this.gbp2.UseVisualStyleBackColor = true;
            // 
            // eur2
            // 
            this.eur2.AutoSize = true;
            this.eur2.Location = new System.Drawing.Point(65, 146);
            this.eur2.Name = "eur2";
            this.eur2.Size = new System.Drawing.Size(69, 24);
            this.eur2.TabIndex = 23;
            this.eur2.TabStop = true;
            this.eur2.Text = "EUR";
            this.eur2.UseVisualStyleBackColor = true;
            // 
            // usd2
            // 
            this.usd2.AutoSize = true;
            this.usd2.Location = new System.Drawing.Point(65, 92);
            this.usd2.Name = "usd2";
            this.usd2.Size = new System.Drawing.Size(69, 24);
            this.usd2.TabIndex = 22;
            this.usd2.TabStop = true;
            this.usd2.Text = "USD";
            this.usd2.UseVisualStyleBackColor = true;
            // 
            // cad2
            // 
            this.cad2.AutoSize = true;
            this.cad2.Location = new System.Drawing.Point(65, 37);
            this.cad2.Name = "cad2";
            this.cad2.Size = new System.Drawing.Size(68, 24);
            this.cad2.TabIndex = 21;
            this.cad2.TabStop = true;
            this.cad2.Text = "CAD";
            this.cad2.UseVisualStyleBackColor = true;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(132, 409);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 26);
            this.from.TabIndex = 28;
            this.from.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(434, 409);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 26);
            this.to.TabIndex = 29;
            // 
            // MoneyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 821);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moneyExit);
            this.Name = "MoneyExchange";
            this.Text = "MoneyExchange";
            this.Load += new System.EventHandler(this.MoneyExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moneyExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inr;
        private System.Windows.Forms.RadioButton gbp;
        private System.Windows.Forms.RadioButton eur;
        private System.Windows.Forms.RadioButton usd;
        private System.Windows.Forms.RadioButton cad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton inr2;
        private System.Windows.Forms.RadioButton gbp2;
        private System.Windows.Forms.RadioButton eur2;
        private System.Windows.Forms.RadioButton usd2;
        private System.Windows.Forms.RadioButton cad2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
    }
}