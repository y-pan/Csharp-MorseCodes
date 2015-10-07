namespace Morse_Codes
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtMorse = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbT2M = new System.Windows.Forms.RadioButton();
            this.rbM2T = new System.Windows.Forms.RadioButton();
            this.btnPlaySounds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.Location = new System.Drawing.Point(34, 348);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(146, 58);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtMorse
            // 
            this.txtMorse.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorse.Location = new System.Drawing.Point(194, 299);
            this.txtMorse.Multiline = true;
            this.txtMorse.Name = "txtMorse";
            this.txtMorse.ReadOnly = true;
            this.txtMorse.Size = new System.Drawing.Size(815, 195);
            this.txtMorse.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(194, 44);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(815, 195);
            this.txtText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Morse";
            // 
            // rbT2M
            // 
            this.rbT2M.AutoSize = true;
            this.rbT2M.Checked = true;
            this.rbT2M.Location = new System.Drawing.Point(34, 44);
            this.rbT2M.Name = "rbT2M";
            this.rbT2M.Size = new System.Drawing.Size(130, 24);
            this.rbT2M.TabIndex = 6;
            this.rbT2M.TabStop = true;
            this.rbT2M.Text = "Text -> Morse";
            this.rbT2M.UseVisualStyleBackColor = true;
            this.rbT2M.CheckedChanged += new System.EventHandler(this.rbT2M_CheckedChanged);
            // 
            // rbM2T
            // 
            this.rbM2T.AutoSize = true;
            this.rbM2T.Location = new System.Drawing.Point(34, 299);
            this.rbM2T.Name = "rbM2T";
            this.rbM2T.Size = new System.Drawing.Size(130, 24);
            this.rbM2T.TabIndex = 7;
            this.rbM2T.Text = "Morse -> Text";
            this.rbM2T.UseVisualStyleBackColor = true;
            this.rbM2T.CheckedChanged += new System.EventHandler(this.rbM2T_CheckedChanged);
            // 
            // btnPlaySounds
            // 
            this.btnPlaySounds.Location = new System.Drawing.Point(59, 442);
            this.btnPlaySounds.Name = "btnPlaySounds";
            this.btnPlaySounds.Size = new System.Drawing.Size(72, 64);
            this.btnPlaySounds.TabIndex = 8;
            this.btnPlaySounds.Text = "Play";
            this.btnPlaySounds.UseVisualStyleBackColor = true;
            this.btnPlaySounds.Click += new System.EventHandler(this.btnPlaySounds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 556);
            this.Controls.Add(this.btnPlaySounds);
            this.Controls.Add(this.rbM2T);
            this.Controls.Add(this.rbT2M);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtMorse);
            this.Controls.Add(this.btnTranslate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtMorse;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbT2M;
        private System.Windows.Forms.RadioButton rbM2T;
        private System.Windows.Forms.Button btnPlaySounds;
    }
}

