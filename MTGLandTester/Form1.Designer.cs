namespace MTGLandTester
{
    partial class Form1
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
            this.NumberBasics = new System.Windows.Forms.TextBox();
            this.NumberNonBasics = new System.Windows.Forms.TextBox();
            this.NumberSpells = new System.Windows.Forms.TextBox();
            this.HandSize = new System.Windows.Forms.TextBox();
            this.NumberOfDraws = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberBasics
            // 
            this.NumberBasics.Location = new System.Drawing.Point(168, 12);
            this.NumberBasics.Name = "NumberBasics";
            this.NumberBasics.Size = new System.Drawing.Size(100, 20);
            this.NumberBasics.TabIndex = 0;
            this.NumberBasics.Text = "20";
            // 
            // NumberNonBasics
            // 
            this.NumberNonBasics.Location = new System.Drawing.Point(168, 41);
            this.NumberNonBasics.Name = "NumberNonBasics";
            this.NumberNonBasics.Size = new System.Drawing.Size(100, 20);
            this.NumberNonBasics.TabIndex = 1;
            this.NumberNonBasics.Text = "2";
            // 
            // NumberSpells
            // 
            this.NumberSpells.Location = new System.Drawing.Point(168, 68);
            this.NumberSpells.Name = "NumberSpells";
            this.NumberSpells.Size = new System.Drawing.Size(100, 20);
            this.NumberSpells.TabIndex = 2;
            this.NumberSpells.Text = "38";
            // 
            // HandSize
            // 
            this.HandSize.Location = new System.Drawing.Point(168, 95);
            this.HandSize.Name = "HandSize";
            this.HandSize.Size = new System.Drawing.Size(100, 20);
            this.HandSize.TabIndex = 3;
            this.HandSize.Text = "7";
            // 
            // NumberOfDraws
            // 
            this.NumberOfDraws.Location = new System.Drawing.Point(168, 122);
            this.NumberOfDraws.Name = "NumberOfDraws";
            this.NumberOfDraws.Size = new System.Drawing.Size(100, 20);
            this.NumberOfDraws.TabIndex = 4;
            this.NumberOfDraws.Text = "10000";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(12, 178);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(787, 418);
            this.OutputText.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(168, 149);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Basic Lands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Non Basic Lands";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Spells";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hand Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Draws";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 608);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.NumberOfDraws);
            this.Controls.Add(this.HandSize);
            this.Controls.Add(this.NumberSpells);
            this.Controls.Add(this.NumberNonBasics);
            this.Controls.Add(this.NumberBasics);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberBasics;
        private System.Windows.Forms.TextBox NumberNonBasics;
        private System.Windows.Forms.TextBox NumberSpells;
        private System.Windows.Forms.TextBox HandSize;
        private System.Windows.Forms.TextBox NumberOfDraws;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

