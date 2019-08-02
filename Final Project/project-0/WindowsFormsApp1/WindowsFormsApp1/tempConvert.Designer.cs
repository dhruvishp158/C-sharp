namespace WindowsFormsApp1
{
    partial class tempConvert
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
            this.tempExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempExit
            // 
            this.tempExit.Location = new System.Drawing.Point(483, 496);
            this.tempExit.Name = "tempExit";
            this.tempExit.Size = new System.Drawing.Size(93, 41);
            this.tempExit.TabIndex = 13;
            this.tempExit.Text = "E&xit";
            this.tempExit.UseVisualStyleBackColor = true;
            this.tempExit.Click += new System.EventHandler(this.tempExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Read File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "&Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "F";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(172, 174);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 26);
            this.from.TabIndex = 19;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(440, 174);
            this.to.Name = "to";
            this.to.ReadOnly = true;
            this.to.Size = new System.Drawing.Size(100, 26);
            this.to.TabIndex = 20;
            this.to.TextChanged += new System.EventHandler(this.to_TextChanged);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(289, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(118, 24);
            this.btn1.TabIndex = 21;
            this.btn1.TabStop = true;
            this.btn1.Text = "From C to F";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(289, 103);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(118, 24);
            this.btn2.TabIndex = 22;
            this.btn2.TabStop = true;
            this.btn2.Text = "From F to C";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(140, 303);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(436, 162);
            this.description.TabIndex = 23;
            this.description.Text = "";
            this.description.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Message:";
            // 
            // tempConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempExit);
            this.Name = "tempConvert";
            this.Text = "tempConvert";
            this.Load += new System.EventHandler(this.tempConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tempExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label4;
    }
}