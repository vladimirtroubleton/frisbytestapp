namespace FrisbiTestApp
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
            this.StaffFindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonSurname = new System.Windows.Forms.RadioButton();
            this.FindStaffButton = new System.Windows.Forms.Button();
            this.FindedStaffRecords = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStatisticsShow = new System.Windows.Forms.Button();
            this.DismissStaffButton = new System.Windows.Forms.Button();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.GetStaffsListButton = new System.Windows.Forms.Button();
            this.labelConnectData = new System.Windows.Forms.Label();
            this.buttonExportToXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffFindTextBox
            // 
            this.StaffFindTextBox.Location = new System.Drawing.Point(313, 87);
            this.StaffFindTextBox.Name = "StaffFindTextBox";
            this.StaffFindTextBox.Size = new System.Drawing.Size(184, 23);
            this.StaffFindTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя или фамилию разыскиваемого сотрудника";
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(350, 116);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(85, 19);
            this.radioButtonName.TabIndex = 2;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Я ввел имя";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonSurname
            // 
            this.radioButtonSurname.AutoSize = true;
            this.radioButtonSurname.Location = new System.Drawing.Point(350, 143);
            this.radioButtonSurname.Name = "radioButtonSurname";
            this.radioButtonSurname.Size = new System.Drawing.Size(118, 19);
            this.radioButtonSurname.TabIndex = 3;
            this.radioButtonSurname.TabStop = true;
            this.radioButtonSurname.Text = "Я ввел фамилию";
            this.radioButtonSurname.UseVisualStyleBackColor = true;
            // 
            // FindStaffButton
            // 
            this.FindStaffButton.Location = new System.Drawing.Point(369, 168);
            this.FindStaffButton.Name = "FindStaffButton";
            this.FindStaffButton.Size = new System.Drawing.Size(75, 23);
            this.FindStaffButton.TabIndex = 4;
            this.FindStaffButton.Text = "Найти";
            this.FindStaffButton.UseVisualStyleBackColor = true;
            this.FindStaffButton.Click += new System.EventHandler(this.FindStaffButton_Click);
            // 
            // FindedStaffRecords
            // 
            this.FindedStaffRecords.FormattingEnabled = true;
            this.FindedStaffRecords.ItemHeight = 15;
            this.FindedStaffRecords.Location = new System.Drawing.Point(630, 99);
            this.FindedStaffRecords.Name = "FindedStaffRecords";
            this.FindedStaffRecords.Size = new System.Drawing.Size(503, 514);
            this.FindedStaffRecords.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результаты поиска:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExportToXML);
            this.groupBox1.Controls.Add(this.buttonStatisticsShow);
            this.groupBox1.Controls.Add(this.DismissStaffButton);
            this.groupBox1.Controls.Add(this.AddStaffButton);
            this.groupBox1.Controls.Add(this.GetStaffsListButton);
            this.groupBox1.Location = new System.Drawing.Point(52, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 373);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // buttonStatisticsShow
            // 
            this.buttonStatisticsShow.Location = new System.Drawing.Point(86, 200);
            this.buttonStatisticsShow.Name = "buttonStatisticsShow";
            this.buttonStatisticsShow.Size = new System.Drawing.Size(166, 46);
            this.buttonStatisticsShow.TabIndex = 0;
            this.buttonStatisticsShow.Text = "Просмотр статистики";
            this.buttonStatisticsShow.UseVisualStyleBackColor = true;
            this.buttonStatisticsShow.Click += new System.EventHandler(this.buttonStatisticsShow_Click);
            // 
            // DismissStaffButton
            // 
            this.DismissStaffButton.Location = new System.Drawing.Point(86, 148);
            this.DismissStaffButton.Name = "DismissStaffButton";
            this.DismissStaffButton.Size = new System.Drawing.Size(166, 46);
            this.DismissStaffButton.TabIndex = 0;
            this.DismissStaffButton.Text = "Увольнение сотрудника";
            this.DismissStaffButton.UseVisualStyleBackColor = true;
            this.DismissStaffButton.Click += new System.EventHandler(this.DismissStaffButton_Click);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(86, 96);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(166, 46);
            this.AddStaffButton.TabIndex = 0;
            this.AddStaffButton.Text = "Добавление сотрудника";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButon_Click);
            // 
            // GetStaffsListButton
            // 
            this.GetStaffsListButton.Location = new System.Drawing.Point(86, 44);
            this.GetStaffsListButton.Name = "GetStaffsListButton";
            this.GetStaffsListButton.Size = new System.Drawing.Size(166, 46);
            this.GetStaffsListButton.TabIndex = 0;
            this.GetStaffsListButton.Text = "Просмотр списка сотрудников";
            this.GetStaffsListButton.UseVisualStyleBackColor = true;
            this.GetStaffsListButton.Click += new System.EventHandler(this.GetStaffsListButton_Click);
            // 
            // labelConnectData
            // 
            this.labelConnectData.AutoSize = true;
            this.labelConnectData.Location = new System.Drawing.Point(449, 598);
            this.labelConnectData.Name = "labelConnectData";
            this.labelConnectData.Size = new System.Drawing.Size(163, 15);
            this.labelConnectData.TabIndex = 9;
            this.labelConnectData.Text = "База данных не подключена";
            // 
            // buttonExportToXML
            // 
            this.buttonExportToXML.Location = new System.Drawing.Point(86, 252);
            this.buttonExportToXML.Name = "buttonExportToXML";
            this.buttonExportToXML.Size = new System.Drawing.Size(166, 46);
            this.buttonExportToXML.TabIndex = 0;
            this.buttonExportToXML.Text = "Экспорт данных";
            this.buttonExportToXML.UseVisualStyleBackColor = true;
            this.buttonExportToXML.Click += new System.EventHandler(this.buttonExportToXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 639);
            this.Controls.Add(this.labelConnectData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.FindStaffButton);
            this.Controls.Add(this.radioButtonSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffFindTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindedStaffRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "FrisbiTestApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StaffFindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonSurname;
        private System.Windows.Forms.Button FindStaffButton;
        private System.Windows.Forms.ListBox FindedStaffRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStatisticsShow;
        private System.Windows.Forms.Button DismissStaffButton;
        private System.Windows.Forms.Button AddStaffButton;
        private System.Windows.Forms.Button GetStaffsListButton;
        private System.Windows.Forms.Label labelConnectData;
        private System.Windows.Forms.Button buttonExportToXML;
    }
}