namespace Certificate._1
{
    partial class login1
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
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Intern name";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(249, 55);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(88, 26);
            this.text1.TabIndex = 1;
            this.text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text1_KeyPress);
            // 
            // ok
            // 
            this.ok.AutoSize = true;
            this.ok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ok.Location = new System.Drawing.Point(245, 140);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(33, 22);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 201);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1);
            this.Name = "login1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label ok;
    }
}