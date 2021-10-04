namespace MaintainCities
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
            this.Respondents = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtStrNo = new System.Windows.Forms.TextBox();
            this.txtStrName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Respondents.SuspendLayout();
            this.SuspendLayout();
            // 
            // Respondents
            // 
            this.Respondents.Controls.Add(this.btnSubmit);
            this.Respondents.Controls.Add(this.txtStrName);
            this.Respondents.Controls.Add(this.txtStrNo);
            this.Respondents.Controls.Add(this.txtDOB);
            this.Respondents.Controls.Add(this.txtSurname);
            this.Respondents.Controls.Add(this.txtName);
            this.Respondents.Controls.Add(this.label5);
            this.Respondents.Controls.Add(this.label4);
            this.Respondents.Controls.Add(this.label3);
            this.Respondents.Controls.Add(this.label2);
            this.Respondents.Controls.Add(this.label1);
            this.Respondents.Location = new System.Drawing.Point(13, 13);
            this.Respondents.Name = "Respondents";
            this.Respondents.Size = new System.Drawing.Size(488, 283);
            this.Respondents.TabIndex = 0;
            this.Respondents.TabStop = false;
            this.Respondents.Text = "Maintain Respondents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth (YYYY/MM/DD)  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stree Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(237, 71);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(219, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(237, 105);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(219, 20);
            this.txtDOB.TabIndex = 7;
            // 
            // txtStrNo
            // 
            this.txtStrNo.Location = new System.Drawing.Point(237, 142);
            this.txtStrNo.Name = "txtStrNo";
            this.txtStrNo.Size = new System.Drawing.Size(219, 20);
            this.txtStrNo.TabIndex = 8;
            // 
            // txtStrName
            // 
            this.txtStrName.Location = new System.Drawing.Point(237, 179);
            this.txtStrName.Name = "txtStrName";
            this.txtStrName.Size = new System.Drawing.Size(219, 20);
            this.txtStrName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(143, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 43);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 351);
            this.Controls.Add(this.Respondents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Respondents.ResumeLayout(false);
            this.Respondents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Respondents;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStrName;
        private System.Windows.Forms.TextBox txtStrNo;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

