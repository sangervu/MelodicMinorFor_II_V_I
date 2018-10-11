namespace DesktopMelodicMinor4minor_II_V_I
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
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.Scale_I = new System.Windows.Forms.Label();
            this.Scale_II = new System.Windows.Forms.Label();
            this.Scale_V = new System.Windows.Forms.Label();
            this.isSharp = new System.Windows.Forms.RadioButton();
            this.isFlat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Intervals_II = new System.Windows.Forms.Label();
            this.Intervals_V = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.melodicMinorFor_I = new System.Windows.Forms.Label();
            this.melodicMinorFor_II = new System.Windows.Forms.Label();
            this.melodicMinorFor_V = new System.Windows.Forms.Label();
            this.ScaleNotesFor_I = new System.Windows.Forms.Label();
            this.ScaleNotesFor_II = new System.Windows.Forms.Label();
            this.ScaleNotesFor_V = new System.Windows.Forms.Label();
            this.isNone = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Intervals_I = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(58, 22);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(714, 37);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Melodic Minor Scales for II V I Cord Progressions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the key for the II V I cord progression:";
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(634, 92);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(83, 37);
            this.cboState.TabIndex = 5;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // Scale_I
            // 
            this.Scale_I.AutoSize = true;
            this.Scale_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale_I.Location = new System.Drawing.Point(70, 555);
            this.Scale_I.Name = "Scale_I";
            this.Scale_I.Size = new System.Drawing.Size(101, 32);
            this.Scale_I.TabIndex = 6;
            this.Scale_I.Text = "I Scale";
            // 
            // Scale_II
            // 
            this.Scale_II.AutoSize = true;
            this.Scale_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale_II.Location = new System.Drawing.Point(70, 268);
            this.Scale_II.Name = "Scale_II";
            this.Scale_II.Size = new System.Drawing.Size(108, 32);
            this.Scale_II.TabIndex = 12;
            this.Scale_II.Text = "II Scale";
            // 
            // Scale_V
            // 
            this.Scale_V.AutoSize = true;
            this.Scale_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale_V.Location = new System.Drawing.Point(72, 411);
            this.Scale_V.Name = "Scale_V";
            this.Scale_V.Size = new System.Drawing.Size(113, 32);
            this.Scale_V.TabIndex = 16;
            this.Scale_V.Text = "V Scale";
            // 
            // isSharp
            // 
            this.isSharp.AutoSize = true;
            this.isSharp.Location = new System.Drawing.Point(737, 79);
            this.isSharp.Name = "isSharp";
            this.isSharp.Size = new System.Drawing.Size(87, 24);
            this.isSharp.TabIndex = 23;
            this.isSharp.TabStop = true;
            this.isSharp.Text = "# sharp";
            this.isSharp.UseVisualStyleBackColor = true;
            this.isSharp.CheckedChanged += new System.EventHandler(this.isSharp_CheckedChanged);
            // 
            // isFlat
            // 
            this.isFlat.AutoSize = true;
            this.isFlat.Location = new System.Drawing.Point(737, 109);
            this.isFlat.Name = "isFlat";
            this.isFlat.Size = new System.Drawing.Size(69, 24);
            this.isFlat.TabIndex = 24;
            this.isFlat.TabStop = true;
            this.isFlat.Text = "b flat";
            this.isFlat.UseVisualStyleBackColor = true;
            this.isFlat.CheckedChanged += new System.EventHandler(this.isFlat_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 26;
            // 
            // Intervals_II
            // 
            this.Intervals_II.AutoSize = true;
            this.Intervals_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_II.Location = new System.Drawing.Point(74, 311);
            this.Intervals_II.Name = "Intervals_II";
            this.Intervals_II.Size = new System.Drawing.Size(62, 29);
            this.Intervals_II.TabIndex = 27;
            this.Intervals_II.Text = "Int 2";
            // 
            // Intervals_V
            // 
            this.Intervals_V.AutoSize = true;
            this.Intervals_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_V.Location = new System.Drawing.Point(71, 455);
            this.Intervals_V.Name = "Intervals_V";
            this.Intervals_V.Size = new System.Drawing.Size(62, 29);
            this.Intervals_V.TabIndex = 28;
            this.Intervals_V.Text = "Int 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Melodic Minor Scale on";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Melodic Minor Scale on";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Melodic Minor Scale on";
            // 
            // melodicMinorFor_I
            // 
            this.melodicMinorFor_I.AutoSize = true;
            this.melodicMinorFor_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melodicMinorFor_I.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.melodicMinorFor_I.Location = new System.Drawing.Point(251, 629);
            this.melodicMinorFor_I.Name = "melodicMinorFor_I";
            this.melodicMinorFor_I.Size = new System.Drawing.Size(131, 29);
            this.melodicMinorFor_I.TabIndex = 32;
            this.melodicMinorFor_I.Text = "\"New key\"";
            // 
            // melodicMinorFor_II
            // 
            this.melodicMinorFor_II.AutoSize = true;
            this.melodicMinorFor_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melodicMinorFor_II.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.melodicMinorFor_II.Location = new System.Drawing.Point(253, 346);
            this.melodicMinorFor_II.Name = "melodicMinorFor_II";
            this.melodicMinorFor_II.Size = new System.Drawing.Size(131, 29);
            this.melodicMinorFor_II.TabIndex = 33;
            this.melodicMinorFor_II.Text = "\"New key\"";
            // 
            // melodicMinorFor_V
            // 
            this.melodicMinorFor_V.AutoSize = true;
            this.melodicMinorFor_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melodicMinorFor_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.melodicMinorFor_V.Location = new System.Drawing.Point(253, 494);
            this.melodicMinorFor_V.Name = "melodicMinorFor_V";
            this.melodicMinorFor_V.Size = new System.Drawing.Size(131, 29);
            this.melodicMinorFor_V.TabIndex = 34;
            this.melodicMinorFor_V.Text = "\"New key\"";
            // 
            // ScaleNotesFor_I
            // 
            this.ScaleNotesFor_I.AutoSize = true;
            this.ScaleNotesFor_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleNotesFor_I.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScaleNotesFor_I.Location = new System.Drawing.Point(464, 601);
            this.ScaleNotesFor_I.Name = "ScaleNotesFor_I";
            this.ScaleNotesFor_I.Size = new System.Drawing.Size(299, 40);
            this.ScaleNotesFor_I.TabIndex = 35;
            this.ScaleNotesFor_I.Text = "Scale Notes for I";
            // 
            // ScaleNotesFor_II
            // 
            this.ScaleNotesFor_II.AutoSize = true;
            this.ScaleNotesFor_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleNotesFor_II.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScaleNotesFor_II.Location = new System.Drawing.Point(464, 268);
            this.ScaleNotesFor_II.Name = "ScaleNotesFor_II";
            this.ScaleNotesFor_II.Size = new System.Drawing.Size(309, 40);
            this.ScaleNotesFor_II.TabIndex = 36;
            this.ScaleNotesFor_II.Text = "Scale Notes for II";
            // 
            // ScaleNotesFor_V
            // 
            this.ScaleNotesFor_V.AutoSize = true;
            this.ScaleNotesFor_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleNotesFor_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ScaleNotesFor_V.Location = new System.Drawing.Point(464, 426);
            this.ScaleNotesFor_V.Name = "ScaleNotesFor_V";
            this.ScaleNotesFor_V.Size = new System.Drawing.Size(314, 40);
            this.ScaleNotesFor_V.TabIndex = 37;
            this.ScaleNotesFor_V.Text = "Scale Notes for V";
            // 
            // isNone
            // 
            this.isNone.AutoSize = true;
            this.isNone.Location = new System.Drawing.Point(737, 139);
            this.isNone.Name = "isNone";
            this.isNone.Size = new System.Drawing.Size(70, 24);
            this.isNone.TabIndex = 38;
            this.isNone.TabStop = true;
            this.isNone.Text = "none";
            this.isNone.UseVisualStyleBackColor = true;
            this.isNone.CheckedChanged += new System.EventHandler(this.isNone_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 39;
            this.button1.Text = "II V I minor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(265, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 48);
            this.button2.TabIndex = 40;
            this.button2.Text = "II V I minor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Intervals_I
            // 
            this.Intervals_I.AutoSize = true;
            this.Intervals_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_I.Location = new System.Drawing.Point(72, 600);
            this.Intervals_I.Name = "Intervals_I";
            this.Intervals_I.Size = new System.Drawing.Size(62, 29);
            this.Intervals_I.TabIndex = 42;
            this.Intervals_I.Text = "Int 1";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(458, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 48);
            this.button3.TabIndex = 43;
            this.button3.Text = "II V I Major";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.DarkRed;
            this.key.Location = new System.Drawing.Point(861, 113);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(53, 29);
            this.key.TabIndex = 44;
            this.key.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(861, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 719);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Intervals_I);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isNone);
            this.Controls.Add(this.ScaleNotesFor_V);
            this.Controls.Add(this.ScaleNotesFor_II);
            this.Controls.Add(this.ScaleNotesFor_I);
            this.Controls.Add(this.melodicMinorFor_V);
            this.Controls.Add(this.melodicMinorFor_II);
            this.Controls.Add(this.melodicMinorFor_I);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Intervals_V);
            this.Controls.Add(this.Intervals_II);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isFlat);
            this.Controls.Add(this.isSharp);
            this.Controls.Add(this.Scale_V);
            this.Controls.Add(this.Scale_II);
            this.Controls.Add(this.Scale_I);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloWorldLabel);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label Scale_I;
        private System.Windows.Forms.Label Scale_II;
        private System.Windows.Forms.Label Scale_V;
        private System.Windows.Forms.RadioButton isSharp;
        private System.Windows.Forms.RadioButton isFlat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Intervals_II;
        private System.Windows.Forms.Label Intervals_V;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label melodicMinorFor_I;
        private System.Windows.Forms.Label melodicMinorFor_II;
        private System.Windows.Forms.Label melodicMinorFor_V;
        private System.Windows.Forms.Label ScaleNotesFor_I;
        private System.Windows.Forms.Label ScaleNotesFor_II;
        private System.Windows.Forms.Label ScaleNotesFor_V;
        private System.Windows.Forms.RadioButton isNone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Intervals_I;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Label label3;
    }
}

