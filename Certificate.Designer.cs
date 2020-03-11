namespace Certificate._1
{
    partial class Certificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificate));
            this.picture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.parentname = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.marks = new System.Windows.Forms.Label();
            this.jdate = new System.Windows.Forms.Label();
            this.cdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.url2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(-1, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(709, 738);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(373, 234);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // parentname
            // 
            this.parentname.AutoSize = true;
            this.parentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentname.Location = new System.Drawing.Point(272, 273);
            this.parentname.Name = "parentname";
            this.parentname.Size = new System.Drawing.Size(48, 13);
            this.parentname.TabIndex = 2;
            this.parentname.Text = "guardian";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.Location = new System.Drawing.Point(537, 311);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(38, 13);
            this.course.TabIndex = 5;
            this.course.Text = "course";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(192, 346);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(34, 13);
            this.grade.TabIndex = 5;
            this.grade.Text = "grade";
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks.Location = new System.Drawing.Point(318, 346);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(34, 13);
            this.marks.TabIndex = 6;
            this.marks.Text = "marks";
            // 
            // jdate
            // 
            this.jdate.AutoSize = true;
            this.jdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdate.Location = new System.Drawing.Point(373, 387);
            this.jdate.Name = "jdate";
            this.jdate.Size = new System.Drawing.Size(30, 13);
            this.jdate.TabIndex = 7;
            this.jdate.Text = "jdate";
            // 
            // cdate
            // 
            this.cdate.AutoSize = true;
            this.cdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdate.Location = new System.Drawing.Point(559, 387);
            this.cdate.Name = "cdate";
            this.cdate.Size = new System.Drawing.Size(33, 13);
            this.cdate.TabIndex = 8;
            this.cdate.Text = "cdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 9);
            this.label1.TabIndex = 10;
            this.label1.Text = "1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 603);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // url2
            // 
            this.url2.AutoSize = true;
            this.url2.Location = new System.Drawing.Point(409, 37);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(210, 20);
            this.url2.TabIndex = 12;
            this.url2.TabStop = true;
            this.url2.Text = "SEE YOUR TRANSACTION";
            this.url2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Url2_LinkClicked);
            // 
            // Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 739);
            this.Controls.Add(this.url2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cdate);
            this.Controls.Add(this.jdate);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.course);
            this.Controls.Add(this.parentname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picture);
            this.MaximizeBox = false;
            this.Name = "Certificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Certificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label parentname;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label marks;
        private System.Windows.Forms.Label jdate;
        private System.Windows.Forms.Label cdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel url2;
    }
}