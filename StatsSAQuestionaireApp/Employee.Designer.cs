
namespace StatsSAQuestionaireApp
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
            this.components = new System.ComponentModel.Container();
            this.add_empl = new System.Windows.Forms.Button();
            this.update_empl = new System.Windows.Forms.Button();
            this.del_empl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statsSADbDataSet = new StatsSAQuestionaireApp.StatsSADbDataSet();
            this.statsSADbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsSADbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsSADbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_empl
            // 
            this.add_empl.Location = new System.Drawing.Point(41, 297);
            this.add_empl.Name = "add_empl";
            this.add_empl.Size = new System.Drawing.Size(101, 47);
            this.add_empl.TabIndex = 0;
            this.add_empl.Text = "Add Employee";
            this.add_empl.UseVisualStyleBackColor = true;
            this.add_empl.Click += new System.EventHandler(this.add_empl_Click);
            // 
            // update_empl
            // 
            this.update_empl.Location = new System.Drawing.Point(344, 297);
            this.update_empl.Name = "update_empl";
            this.update_empl.Size = new System.Drawing.Size(101, 47);
            this.update_empl.TabIndex = 1;
            this.update_empl.Text = "Edit Employee";
            this.update_empl.UseVisualStyleBackColor = true;
            // 
            // del_empl
            // 
            this.del_empl.Location = new System.Drawing.Point(641, 297);
            this.del_empl.Name = "del_empl";
            this.del_empl.Size = new System.Drawing.Size(101, 47);
            this.del_empl.TabIndex = 2;
            this.del_empl.Text = "Remove Employee";
            this.del_empl.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.statsSADbDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(41, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 233);
            this.dataGridView1.TabIndex = 3;
            // 
            // statsSADbDataSet
            // 
            this.statsSADbDataSet.DataSetName = "StatsSADbDataSet";
            this.statsSADbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statsSADbDataSetBindingSource
            // 
            this.statsSADbDataSetBindingSource.DataSource = this.statsSADbDataSet;
            this.statsSADbDataSetBindingSource.Position = 0;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.del_empl);
            this.Controls.Add(this.update_empl);
            this.Controls.Add(this.add_empl);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsSADbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsSADbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_empl;
        private System.Windows.Forms.Button update_empl;
        private System.Windows.Forms.Button del_empl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StatsSADbDataSet statsSADbDataSet;
        private System.Windows.Forms.BindingSource statsSADbDataSetBindingSource;
    }
}