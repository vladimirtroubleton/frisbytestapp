namespace FrisbiTestApp.Forms
{
    partial class StatisticsForm
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
            this.listBoxStatistics = new System.Windows.Forms.ListBox();
            this.buttonRefreshStatic = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStatistics
            // 
            this.listBoxStatistics.FormattingEnabled = true;
            this.listBoxStatistics.ItemHeight = 15;
            this.listBoxStatistics.Location = new System.Drawing.Point(36, 12);
            this.listBoxStatistics.Name = "listBoxStatistics";
            this.listBoxStatistics.Size = new System.Drawing.Size(371, 409);
            this.listBoxStatistics.TabIndex = 0;
            // 
            // buttonRefreshStatic
            // 
            this.buttonRefreshStatic.Location = new System.Drawing.Point(453, 132);
            this.buttonRefreshStatic.Name = "buttonRefreshStatic";
            this.buttonRefreshStatic.Size = new System.Drawing.Size(105, 57);
            this.buttonRefreshStatic.TabIndex = 1;
            this.buttonRefreshStatic.Text = "Обновить статистику";
            this.buttonRefreshStatic.UseVisualStyleBackColor = true;
            this.buttonRefreshStatic.Click += new System.EventHandler(this.buttonRefreshStatic_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(453, 244);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 53);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxStatistics);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRefreshStatic);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStatistics;
        private System.Windows.Forms.Button buttonRefreshStatic;
        private System.Windows.Forms.Button buttonExit;
    }
}