namespace Certificate._1
{
    partial class Employee
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
            this.username_btn = new System.Windows.Forms.Label();
            this.Pass_btn = new System.Windows.Forms.Label();
            this.Emp_btn = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Label();
            this.user_btn = new System.Windows.Forms.TextBox();
            this.password_btn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username_btn
            // 
            this.username_btn.AutoSize = true;
            this.username_btn.Location = new System.Drawing.Point(85, 155);
            this.username_btn.Name = "username_btn";
            this.username_btn.Size = new System.Drawing.Size(80, 20);
            this.username_btn.TabIndex = 0;
            this.username_btn.Text = "username";
            this.username_btn.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Pass_btn
            // 
            this.Pass_btn.AutoSize = true;
            this.Pass_btn.Location = new System.Drawing.Point(85, 225);
            this.Pass_btn.Name = "Pass_btn";
            this.Pass_btn.Size = new System.Drawing.Size(77, 20);
            this.Pass_btn.TabIndex = 1;
            this.Pass_btn.Text = "password";
            // 
            // Emp_btn
            // 
            this.Emp_btn.AutoSize = true;
            this.Emp_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Emp_btn.Location = new System.Drawing.Point(131, 29);
            this.Emp_btn.Name = "Emp_btn";
            this.Emp_btn.Size = new System.Drawing.Size(320, 45);
            this.Emp_btn.TabIndex = 2;
            this.Emp_btn.Text = "Employee login ";
            // 
            // Submit_btn
            // 
            this.Submit_btn.AutoSize = true;
            this.Submit_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Submit_btn.Location = new System.Drawing.Point(260, 317);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(61, 22);
            this.Submit_btn.TabIndex = 3;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // user_btn
            // 
            this.user_btn.Location = new System.Drawing.Point(196, 149);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(151, 26);
            this.user_btn.TabIndex = 4;
            // 
            // password_btn
            // 
            this.password_btn.Location = new System.Drawing.Point(196, 219);
            this.password_btn.Name = "password_btn";
            this.password_btn.Size = new System.Drawing.Size(151, 26);
            this.password_btn.TabIndex = 5;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 393);
            this.Controls.Add(this.password_btn);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Emp_btn);
            this.Controls.Add(this.Pass_btn);
            this.Controls.Add(this.username_btn);
            this.Name = "Employee";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_btn;
        private System.Windows.Forms.Label Pass_btn;
        private System.Windows.Forms.Label Emp_btn;
        private System.Windows.Forms.Label Submit_btn;
        private System.Windows.Forms.TextBox user_btn;
        private System.Windows.Forms.TextBox password_btn;
    }
}

