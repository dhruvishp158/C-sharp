namespace WindowsFormsApp1
{
    partial class calculator
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
            this.calcExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btneql = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnneg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcExit
            // 
            this.calcExit.Location = new System.Drawing.Point(696, 633);
            this.calcExit.Name = "calcExit";
            this.calcExit.Size = new System.Drawing.Size(83, 41);
            this.calcExit.TabIndex = 0;
            this.calcExit.Text = "E&xit";
            this.calcExit.UseVisualStyleBackColor = true;
            this.calcExit.Click += new System.EventHandler(this.calcExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(217, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 195);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnce.Location = new System.Drawing.Point(218, 269);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(72, 41);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.Location = new System.Drawing.Point(295, 269);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(72, 41);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(373, 269);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(72, 41);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Del";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(451, 269);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(72, 41);
            this.btndiv.TabIndex = 5;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(451, 316);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(72, 41);
            this.btnmul.TabIndex = 10;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.Location = new System.Drawing.Point(373, 316);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(72, 41);
            this.btnnine.TabIndex = 9;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = false;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.Location = new System.Drawing.Point(295, 316);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(72, 41);
            this.btneight.TabIndex = 8;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = false;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(217, 316);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(72, 41);
            this.btnseven.TabIndex = 7;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = false;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(451, 363);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(72, 41);
            this.btnsub.TabIndex = 14;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.Location = new System.Drawing.Point(373, 363);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(72, 41);
            this.btnsix.TabIndex = 13;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = false;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.Location = new System.Drawing.Point(295, 363);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(72, 41);
            this.btnfive.TabIndex = 12;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = false;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.Location = new System.Drawing.Point(217, 363);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(72, 41);
            this.btnfour.TabIndex = 11;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = false;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(451, 410);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(72, 41);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.Location = new System.Drawing.Point(373, 410);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(72, 41);
            this.btnthree.TabIndex = 17;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = false;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(295, 410);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(72, 41);
            this.btntwo.TabIndex = 16;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = false;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.Location = new System.Drawing.Point(217, 410);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(72, 41);
            this.btnone.TabIndex = 15;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = false;
            this.btnone.Click += new System.EventHandler(this.button17_Click);
            // 
            // btneql
            // 
            this.btneql.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneql.Location = new System.Drawing.Point(451, 457);
            this.btneql.Name = "btneql";
            this.btneql.Size = new System.Drawing.Size(72, 41);
            this.btneql.TabIndex = 22;
            this.btneql.Text = "=";
            this.btneql.UseVisualStyleBackColor = false;
            this.btneql.Click += new System.EventHandler(this.btneql_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(373, 457);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(72, 41);
            this.btndot.TabIndex = 21;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(295, 457);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(72, 41);
            this.btnzero.TabIndex = 20;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = false;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnneg
            // 
            this.btnneg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnneg.Location = new System.Drawing.Point(217, 457);
            this.btnneg.Name = "btnneg";
            this.btnneg.Size = new System.Drawing.Size(72, 41);
            this.btnneg.TabIndex = 19;
            this.btnneg.Text = "Neg";
            this.btnneg.UseVisualStyleBackColor = false;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.btneql);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btnneg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calcExit);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "calculator";
            this.Text = "calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcExit;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btneql;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnneg;
    }
}