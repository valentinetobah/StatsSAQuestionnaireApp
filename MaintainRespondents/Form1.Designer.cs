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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStrName = new System.Windows.Forms.TextBox();
            this.txtStrNo = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRespID = new System.Windows.Forms.TextBox();
            this.Respondents.SuspendLayout();
            this.SuspendLayout();
            // 
            // Respondents
            // 
            this.Respondents.Controls.Add(this.txtRespID);
            this.Respondents.Controls.Add(this.label7);
            this.Respondents.Controls.Add(this.txtCity);
            this.Respondents.Controls.Add(this.label6);
            this.Respondents.Controls.Add(this.dateTimePicker1);
            this.Respondents.Controls.Add(this.btnDelete);
            this.Respondents.Controls.Add(this.btnSubmit);
            this.Respondents.Controls.Add(this.txtStrName);
            this.Respondents.Controls.Add(this.txtStrNo);
            this.Respondents.Controls.Add(this.txtSurname);
            this.Respondents.Controls.Add(this.txtName);
            this.Respondents.Controls.Add(this.label5);
            this.Respondents.Controls.Add(this.label4);
            this.Respondents.Controls.Add(this.label3);
            this.Respondents.Controls.Add(this.label2);
            this.Respondents.Controls.Add(this.label1);
            this.Respondents.Location = new System.Drawing.Point(13, 13);
            this.Respondents.Name = "Respondents";
            this.Respondents.Size = new System.Drawing.Size(534, 373);
            this.Respondents.TabIndex = 0;
            this.Respondents.TabStop = false;
            this.Respondents.Text = "Maintain Respondents";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(228, 236);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(219, 20);
            this.txtCity.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "City :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(69, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 28);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Add/Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtStrName
            // 
            this.txtStrName.Location = new System.Drawing.Point(228, 201);
            this.txtStrName.Name = "txtStrName";
            this.txtStrName.Size = new System.Drawing.Size(219, 20);
            this.txtStrName.TabIndex = 9;
            // 
            // txtStrNo
            // 
            this.txtStrNo.Location = new System.Drawing.Point(228, 164);
            this.txtStrNo.Name = "txtStrNo";
            this.txtStrNo.Size = new System.Drawing.Size(219, 20);
            this.txtStrNo.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(228, 93);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(219, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Street Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stree Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Respondent ID:";
            // 
            // txtRespID
            // 
            this.txtRespID.Location = new System.Drawing.Point(228, 37);
            this.txtRespID.Name = "txtRespID";
            this.txtRespID.Size = new System.Drawing.Size(219, 20);
            this.txtRespID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 425);
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
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRespID;
        private System.Windows.Forms.Label label7;
    }
}

