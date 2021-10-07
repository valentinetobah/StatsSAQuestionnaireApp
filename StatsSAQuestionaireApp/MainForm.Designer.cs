
namespace StatsSAQuestionaireApp
{
    partial class MainForm
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
            this.tbMainForm = new System.Windows.Forms.TabControl();
            this.tpSurveys = new System.Windows.Forms.TabPage();
            this.dgSurveys = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSurveyID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExitSurvey = new System.Windows.Forms.Button();
            this.cbIsUpdate = new System.Windows.Forms.CheckBox();
            this.tbSurveyIDToUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddUpdateSurvey = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbSurveyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSurvey = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestionnaires = new System.Windows.Forms.TabPage();
            this.dgQuestionnaires = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbQuestionnaireIDToDelete = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExitQuestionaires = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbIsQuestionnaireUpdate = new System.Windows.Forms.CheckBox();
            this.tbQuestionnaireID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddUpdateQuestionnaire = new System.Windows.Forms.Button();
            this.tbQuestionnaireDesc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeleteQuestionnaire = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tbMainForm.SuspendLayout();
            this.tpSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSurveys)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbQuestionnaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestionnaires)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMainForm
            // 
            this.tbMainForm.Controls.Add(this.tpSurveys);
            this.tbMainForm.Controls.Add(this.tbQuestionnaires);
            this.tbMainForm.Controls.Add(this.tabPage5);
            this.tbMainForm.Controls.Add(this.tabPage6);
            this.tbMainForm.Controls.Add(this.tabPage7);
            this.tbMainForm.Controls.Add(this.tabPage8);
            this.tbMainForm.Location = new System.Drawing.Point(0, 0);
            this.tbMainForm.Name = "tbMainForm";
            this.tbMainForm.SelectedIndex = 0;
            this.tbMainForm.Size = new System.Drawing.Size(829, 592);
            this.tbMainForm.TabIndex = 0;
            // 
            // tpSurveys
            // 
            this.tpSurveys.Controls.Add(this.dgSurveys);
            this.tpSurveys.Controls.Add(this.label7);
            this.tpSurveys.Controls.Add(this.label6);
            this.tpSurveys.Controls.Add(this.tbSurveyID);
            this.tpSurveys.Controls.Add(this.groupBox1);
            this.tpSurveys.Controls.Add(this.btnDeleteSurvey);
            this.tpSurveys.Controls.Add(this.linkLabel1);
            this.tpSurveys.Controls.Add(this.label2);
            this.tpSurveys.Controls.Add(this.lblName);
            this.tpSurveys.Controls.Add(this.label1);
            this.tpSurveys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSurveys.Location = new System.Drawing.Point(4, 22);
            this.tpSurveys.Name = "tpSurveys";
            this.tpSurveys.Padding = new System.Windows.Forms.Padding(3);
            this.tpSurveys.Size = new System.Drawing.Size(822, 566);
            this.tpSurveys.TabIndex = 0;
            this.tpSurveys.Text = "Surveys";
            this.tpSurveys.UseVisualStyleBackColor = true;
            this.tpSurveys.Click += new System.EventHandler(this.tpSurveys_Click);
            // 
            // dgSurveys
            // 
            this.dgSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSurveys.Location = new System.Drawing.Point(37, 89);
            this.dgSurveys.Name = "dgSurveys";
            this.dgSurveys.Size = new System.Drawing.Size(442, 199);
            this.dgSurveys.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ENTER SURVEY ID BELOW TO DELETE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Survey ID:";
            // 
            // tbSurveyID
            // 
            this.tbSurveyID.Location = new System.Drawing.Point(621, 124);
            this.tbSurveyID.Name = "tbSurveyID";
            this.tbSurveyID.Size = new System.Drawing.Size(155, 23);
            this.tbSurveyID.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExitSurvey);
            this.groupBox1.Controls.Add(this.cbIsUpdate);
            this.groupBox1.Controls.Add(this.tbSurveyIDToUpdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAddUpdateSurvey);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.tbSurveyName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 235);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD NEW SURVEY OR UPDATE EXISTING SURVEY";
            // 
            // btnExitSurvey
            // 
            this.btnExitSurvey.Location = new System.Drawing.Point(514, 178);
            this.btnExitSurvey.Name = "btnExitSurvey";
            this.btnExitSurvey.Size = new System.Drawing.Size(199, 51);
            this.btnExitSurvey.TabIndex = 10;
            this.btnExitSurvey.Text = "Exit";
            this.btnExitSurvey.UseVisualStyleBackColor = true;
            this.btnExitSurvey.Click += new System.EventHandler(this.btnExitSurvey_Click);
            // 
            // cbIsUpdate
            // 
            this.cbIsUpdate.AutoSize = true;
            this.cbIsUpdate.Location = new System.Drawing.Point(108, 41);
            this.cbIsUpdate.Name = "cbIsUpdate";
            this.cbIsUpdate.Size = new System.Drawing.Size(190, 17);
            this.cbIsUpdate.TabIndex = 9;
            this.cbIsUpdate.Text = "Updating an existing survey?";
            this.cbIsUpdate.UseVisualStyleBackColor = true;
            this.cbIsUpdate.CheckedChanged += new System.EventHandler(this.cbIsUpdate_CheckedChanged_1);
            // 
            // tbSurveyIDToUpdate
            // 
            this.tbSurveyIDToUpdate.Location = new System.Drawing.Point(108, 86);
            this.tbSurveyIDToUpdate.Name = "tbSurveyIDToUpdate";
            this.tbSurveyIDToUpdate.Size = new System.Drawing.Size(245, 20);
            this.tbSurveyIDToUpdate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Survey ID:";
            // 
            // btnAddUpdateSurvey
            // 
            this.btnAddUpdateSurvey.Location = new System.Drawing.Point(108, 178);
            this.btnAddUpdateSurvey.Name = "btnAddUpdateSurvey";
            this.btnAddUpdateSurvey.Size = new System.Drawing.Size(199, 51);
            this.btnAddUpdateSurvey.TabIndex = 6;
            this.btnAddUpdateSurvey.Text = "Add New/Update Existing";
            this.btnAddUpdateSurvey.UseVisualStyleBackColor = true;
            this.btnAddUpdateSurvey.Click += new System.EventHandler(this.btnAddUpdateSurvey_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(466, 123);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(247, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(466, 86);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(247, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // tbSurveyName
            // 
            this.tbSurveyName.Location = new System.Drawing.Point(108, 123);
            this.tbSurveyName.Name = "tbSurveyName";
            this.tbSurveyName.Size = new System.Drawing.Size(245, 20);
            this.tbSurveyName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Survey Name:";
            // 
            // btnDeleteSurvey
            // 
            this.btnDeleteSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSurvey.Location = new System.Drawing.Point(701, 160);
            this.btnDeleteSurvey.Name = "btnDeleteSurvey";
            this.btnDeleteSurvey.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSurvey.TabIndex = 14;
            this.btnDeleteSurvey.Text = "Delete";
            this.btnDeleteSurvey.UseVisualStyleBackColor = true;
            this.btnDeleteSurvey.Click += new System.EventHandler(this.btnDeleteSurvey_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(707, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 17);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hello,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(89, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "{lblName}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "LIST OF AVAILABLE SURVEYS";
            // 
            // tbQuestionnaires
            // 
            this.tbQuestionnaires.Controls.Add(this.dgQuestionnaires);
            this.tbQuestionnaires.Controls.Add(this.label9);
            this.tbQuestionnaires.Controls.Add(this.label10);
            this.tbQuestionnaires.Controls.Add(this.tbQuestionnaireIDToDelete);
            this.tbQuestionnaires.Controls.Add(this.groupBox2);
            this.tbQuestionnaires.Controls.Add(this.btnDeleteQuestionnaire);
            this.tbQuestionnaires.Controls.Add(this.label15);
            this.tbQuestionnaires.Controls.Add(this.label16);
            this.tbQuestionnaires.Controls.Add(this.label17);
            this.tbQuestionnaires.Location = new System.Drawing.Point(4, 22);
            this.tbQuestionnaires.Name = "tbQuestionnaires";
            this.tbQuestionnaires.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuestionnaires.Size = new System.Drawing.Size(821, 566);
            this.tbQuestionnaires.TabIndex = 1;
            this.tbQuestionnaires.Text = "Questionnaires";
            this.tbQuestionnaires.UseVisualStyleBackColor = true;
            this.tbQuestionnaires.Click += new System.EventHandler(this.tbQuestionnaires_Click);
            // 
            // dgQuestionnaires
            // 
            this.dgQuestionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuestionnaires.Location = new System.Drawing.Point(37, 89);
            this.dgQuestionnaires.Name = "dgQuestionnaires";
            this.dgQuestionnaires.Size = new System.Drawing.Size(442, 199);
            this.dgQuestionnaires.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "ENTER QUESTIONNAIRE ID BELOW TO DELETE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Questionnaire ID:";
            // 
            // tbQuestionnaireIDToDelete
            // 
            this.tbQuestionnaireIDToDelete.Location = new System.Drawing.Point(648, 124);
            this.tbQuestionnaireIDToDelete.Name = "tbQuestionnaireIDToDelete";
            this.tbQuestionnaireIDToDelete.Size = new System.Drawing.Size(155, 20);
            this.tbQuestionnaireIDToDelete.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExitQuestionaires);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbIsQuestionnaireUpdate);
            this.groupBox2.Controls.Add(this.tbQuestionnaireID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnAddUpdateQuestionnaire);
            this.groupBox2.Controls.Add(this.tbQuestionnaireDesc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 235);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD NEW QUESTIONNAIRE OR UPDATE EXISTING QUESTIONNAIRE";
            // 
            // btnExitQuestionaires
            // 
            this.btnExitQuestionaires.Location = new System.Drawing.Point(524, 164);
            this.btnExitQuestionaires.Name = "btnExitQuestionaires";
            this.btnExitQuestionaires.Size = new System.Drawing.Size(199, 51);
            this.btnExitQuestionaires.TabIndex = 12;
            this.btnExitQuestionaires.Text = "Exit";
            this.btnExitQuestionaires.UseVisualStyleBackColor = true;
            this.btnExitQuestionaires.Click += new System.EventHandler(this.btnExitQuestionaires_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Survey ID:";
            // 
            // cbIsQuestionnaireUpdate
            // 
            this.cbIsQuestionnaireUpdate.AutoSize = true;
            this.cbIsQuestionnaireUpdate.Location = new System.Drawing.Point(128, 40);
            this.cbIsQuestionnaireUpdate.Name = "cbIsQuestionnaireUpdate";
            this.cbIsQuestionnaireUpdate.Size = new System.Drawing.Size(229, 17);
            this.cbIsQuestionnaireUpdate.TabIndex = 9;
            this.cbIsQuestionnaireUpdate.Text = "Updating an existing questionnaire?";
            this.cbIsQuestionnaireUpdate.UseVisualStyleBackColor = true;
            this.cbIsQuestionnaireUpdate.CheckedChanged += new System.EventHandler(this.cbIsQuestionnaireUpdate_CheckedChanged);
            // 
            // tbQuestionnaireID
            // 
            this.tbQuestionnaireID.Location = new System.Drawing.Point(128, 86);
            this.tbQuestionnaireID.Name = "tbQuestionnaireID";
            this.tbQuestionnaireID.Size = new System.Drawing.Size(225, 20);
            this.tbQuestionnaireID.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Questionnaire ID:";
            // 
            // btnAddUpdateQuestionnaire
            // 
            this.btnAddUpdateQuestionnaire.Location = new System.Drawing.Point(128, 164);
            this.btnAddUpdateQuestionnaire.Name = "btnAddUpdateQuestionnaire";
            this.btnAddUpdateQuestionnaire.Size = new System.Drawing.Size(199, 51);
            this.btnAddUpdateQuestionnaire.TabIndex = 6;
            this.btnAddUpdateQuestionnaire.Text = "Add New/Update Existing";
            this.btnAddUpdateQuestionnaire.UseVisualStyleBackColor = true;
            // 
            // tbQuestionnaireDesc
            // 
            this.tbQuestionnaireDesc.Location = new System.Drawing.Point(128, 123);
            this.tbQuestionnaireDesc.Name = "tbQuestionnaireDesc";
            this.tbQuestionnaireDesc.Size = new System.Drawing.Size(585, 20);
            this.tbQuestionnaireDesc.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Description:";
            // 
            // btnDeleteQuestionnaire
            // 
            this.btnDeleteQuestionnaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestionnaire.Location = new System.Drawing.Point(728, 161);
            this.btnDeleteQuestionnaire.Name = "btnDeleteQuestionnaire";
            this.btnDeleteQuestionnaire.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuestionnaire.TabIndex = 24;
            this.btnDeleteQuestionnaire.Text = "Delete";
            this.btnDeleteQuestionnaire.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Hello,";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "{lblName}";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(238, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "LIST OF AVAILABLE QUESTIONNAIRES";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(822, 566);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(822, 566);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(822, 566);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(822, 566);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 604);
            this.Controls.Add(this.tbMainForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbMainForm.ResumeLayout(false);
            this.tpSurveys.ResumeLayout(false);
            this.tpSurveys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSurveys)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbQuestionnaires.ResumeLayout(false);
            this.tbQuestionnaires.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestionnaires)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMainForm;
        private System.Windows.Forms.TabPage tpSurveys;
        private System.Windows.Forms.TabPage tbQuestionnaires;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgSurveys;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSurveyID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbIsUpdate;
        private System.Windows.Forms.TextBox tbSurveyIDToUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddUpdateSurvey;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbSurveyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteSurvey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgQuestionnaires;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbQuestionnaireIDToDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbIsQuestionnaireUpdate;
        private System.Windows.Forms.TextBox tbQuestionnaireID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddUpdateQuestionnaire;
        private System.Windows.Forms.TextBox tbQuestionnaireDesc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDeleteQuestionnaire;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnExitSurvey;
        private System.Windows.Forms.Button btnExitQuestionaires;
    }
}