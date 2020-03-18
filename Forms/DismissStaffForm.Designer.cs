namespace FrisbiTestApp.Forms
{
    partial class DismissStaffForm
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
            this.numericDismissId = new System.Windows.Forms.NumericUpDown();
            this.DismissStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DismissStaffInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DismissTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DismissEndButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDismissId)).BeginInit();
            this.SuspendLayout();
            // 
            // numericDismissId
            // 
            this.numericDismissId.Location = new System.Drawing.Point(305, 190);
            this.numericDismissId.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericDismissId.Name = "numericDismissId";
            this.numericDismissId.Size = new System.Drawing.Size(143, 23);
            this.numericDismissId.TabIndex = 0;
            // 
            // DismissStartButton
            // 
            this.DismissStartButton.Location = new System.Drawing.Point(305, 238);
            this.DismissStartButton.Name = "DismissStartButton";
            this.DismissStartButton.Size = new System.Drawing.Size(143, 23);
            this.DismissStartButton.TabIndex = 1;
            this.DismissStartButton.Text = "Записать увольнение";
            this.DismissStartButton.UseVisualStyleBackColor = true;
            this.DismissStartButton.Click += new System.EventHandler(this.DismissStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ID увольняемого";
            // 
            // DismissStaffInfo
            // 
            this.DismissStaffInfo.FormattingEnabled = true;
            this.DismissStaffInfo.ItemHeight = 15;
            this.DismissStaffInfo.Location = new System.Drawing.Point(12, 34);
            this.DismissStaffInfo.Name = "DismissStaffInfo";
            this.DismissStaffInfo.Size = new System.Drawing.Size(258, 379);
            this.DismissStaffInfo.TabIndex = 3;
            this.DismissStaffInfo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Информация о увольняемом";
            this.label2.Visible = false;
            // 
            // DismissTimePicker
            // 
            this.DismissTimePicker.Location = new System.Drawing.Point(525, 101);
            this.DismissTimePicker.Name = "DismissTimePicker";
            this.DismissTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DismissTimePicker.TabIndex = 5;
            this.DismissTimePicker.Visible = false;
            // 
            // DismissEndButton
            // 
            this.DismissEndButton.Location = new System.Drawing.Point(572, 130);
            this.DismissEndButton.Name = "DismissEndButton";
            this.DismissEndButton.Size = new System.Drawing.Size(96, 35);
            this.DismissEndButton.TabIndex = 6;
            this.DismissEndButton.Text = "Уволить";
            this.DismissEndButton.UseVisualStyleBackColor = true;
            this.DismissEndButton.Visible = false;
            this.DismissEndButton.Click += new System.EventHandler(this.DismissEndButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите дату увольнения";
            this.label3.Visible = false;
            // 
            // DismissStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DismissEndButton);
            this.Controls.Add(this.DismissTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DismissStaffInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DismissStartButton);
            this.Controls.Add(this.numericDismissId);
            this.Name = "DismissStaffForm";
            this.Text = "DismissStaffForm";
            this.Load += new System.EventHandler(this.DismissStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDismissId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericDismissId;
        private System.Windows.Forms.Button DismissStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DismissStaffInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DismissTimePicker;
        private System.Windows.Forms.Button DismissEndButton;
        private System.Windows.Forms.Label label3;
    }
}