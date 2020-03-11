namespace Certificate._1
{
    partial class Internlogin
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
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pas = new System.Windows.Forms.TextBox();
            this.qr = new System.Windows.Forms.PictureBox();
            this.response = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qr)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(335, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 52);
            this.add.TabIndex = 0;
            this.add.Text = "QR SCAN";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASSWORD";
            // 
            // pas
            // 
            this.pas.Location = new System.Drawing.Point(465, 239);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(156, 26);
            this.pas.TabIndex = 3;
            // 
            // qr
            // 
            this.qr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qr.Location = new System.Drawing.Point(12, 12);
            this.qr.Name = "qr";
            this.qr.Size = new System.Drawing.Size(210, 190);
            this.qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qr.TabIndex = 4;
            this.qr.TabStop = false;
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(314, 177);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(0, 20);
            this.response.TabIndex = 5;
            this.response.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(121, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click here to signup";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Internlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.response);
            this.Controls.Add(this.qr);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Name = "Internlogin";
            ((System.ComponentModel.ISupportInitialize)(this.qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.PictureBox qr;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.Label label2;
    }
}