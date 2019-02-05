namespace SoundTest
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
            this.btnDo_Octave = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnLa = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnFa = new System.Windows.Forms.Button();
            this.cbxStretched = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDo_Octave
            // 
            this.btnDo_Octave.Location = new System.Drawing.Point(210, 0);
            this.btnDo_Octave.Name = "btnDo_Octave";
            this.btnDo_Octave.Size = new System.Drawing.Size(30, 76);
            this.btnDo_Octave.TabIndex = 0;
            this.btnDo_Octave.Text = "Do";
            this.btnDo_Octave.UseVisualStyleBackColor = true;
            this.btnDo_Octave.Click += new System.EventHandler(this.btnDo_Octave_Click);
            this.btnDo_Octave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(180, 0);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(30, 76);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            this.btnSi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnLa
            // 
            this.btnLa.Location = new System.Drawing.Point(150, 0);
            this.btnLa.Name = "btnLa";
            this.btnLa.Size = new System.Drawing.Size(30, 76);
            this.btnLa.TabIndex = 2;
            this.btnLa.Text = "La";
            this.btnLa.UseVisualStyleBackColor = true;
            this.btnLa.Click += new System.EventHandler(this.btnLa_Click);
            this.btnLa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(120, 0);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(30, 76);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            this.btnSol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(0, 0);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(30, 76);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            this.btnDo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnMi
            // 
            this.btnMi.Location = new System.Drawing.Point(60, 0);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(30, 76);
            this.btnMi.TabIndex = 5;
            this.btnMi.Text = "Mi";
            this.btnMi.UseVisualStyleBackColor = true;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            this.btnMi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnRe
            // 
            this.btnRe.Location = new System.Drawing.Point(30, 0);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(30, 76);
            this.btnRe.TabIndex = 6;
            this.btnRe.Text = "Re";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            this.btnRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnFa
            // 
            this.btnFa.Location = new System.Drawing.Point(90, 0);
            this.btnFa.Name = "btnFa";
            this.btnFa.Size = new System.Drawing.Size(30, 76);
            this.btnFa.TabIndex = 7;
            this.btnFa.Text = "Fa";
            this.btnFa.UseVisualStyleBackColor = true;
            this.btnFa.Click += new System.EventHandler(this.btnFa_Click);
            this.btnFa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cbxStretched
            // 
            this.cbxStretched.AutoSize = true;
            this.cbxStretched.ForeColor = System.Drawing.SystemColors.Window;
            this.cbxStretched.Location = new System.Drawing.Point(89, 89);
            this.cbxStretched.Name = "cbxStretched";
            this.cbxStretched.Size = new System.Drawing.Size(72, 17);
            this.cbxStretched.TabIndex = 8;
            this.cbxStretched.Text = "Stretched";
            this.cbxStretched.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(242, 118);
            this.ControlBox = false;
            this.Controls.Add(this.cbxStretched);
            this.Controls.Add(this.btnFa);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnMi);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnLa);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnDo_Octave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDo_Octave;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnLa;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnFa;
        private System.Windows.Forms.CheckBox cbxStretched;
    }
}

