namespace Updater
{
    partial class Ui
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui));
            this.RangeIP = new System.Windows.Forms.GroupBox();
            this.StopIP = new System.Windows.Forms.TextBox();
            this.StartIP = new System.Windows.Forms.TextBox();
            this.LebelStopIP = new System.Windows.Forms.Label();
            this.LebelStartIP = new System.Windows.Forms.Label();
            this.checkBoxFolder = new System.Windows.Forms.CheckBox();
            this.UpdateFile = new System.Windows.Forms.GroupBox();
            this.labelTextBox = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Selects = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Updater = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.Updates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RangeIP.SuspendLayout();
            this.UpdateFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Updater.SuspendLayout();
            this.SuspendLayout();
            // 
            // RangeIP
            // 
            this.RangeIP.Controls.Add(this.StopIP);
            this.RangeIP.Controls.Add(this.StartIP);
            this.RangeIP.Controls.Add(this.LebelStopIP);
            this.RangeIP.Controls.Add(this.LebelStartIP);
            this.RangeIP.Location = new System.Drawing.Point(8, 2);
            this.RangeIP.Margin = new System.Windows.Forms.Padding(5);
            this.RangeIP.Name = "RangeIP";
            this.RangeIP.Padding = new System.Windows.Forms.Padding(5);
            this.RangeIP.Size = new System.Drawing.Size(254, 100);
            this.RangeIP.TabIndex = 1;
            this.RangeIP.TabStop = false;
            // 
            // StopIP
            // 
            this.StopIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopIP.Location = new System.Drawing.Point(92, 57);
            this.StopIP.Margin = new System.Windows.Forms.Padding(5);
            this.StopIP.Name = "StopIP";
            this.StopIP.Size = new System.Drawing.Size(147, 26);
            this.StopIP.TabIndex = 3;
            this.StopIP.Text = "192.168.88.19";
            this.StopIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartIP
            // 
            this.StartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartIP.Location = new System.Drawing.Point(92, 21);
            this.StartIP.Margin = new System.Windows.Forms.Padding(5);
            this.StartIP.Name = "StartIP";
            this.StartIP.Size = new System.Drawing.Size(147, 26);
            this.StartIP.TabIndex = 2;
            this.StartIP.Text = "192.168.88.11";
            this.StartIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LebelStopIP
            // 
            this.LebelStopIP.AutoSize = true;
            this.LebelStopIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelStopIP.Location = new System.Drawing.Point(8, 60);
            this.LebelStopIP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelStopIP.Name = "LebelStopIP";
            this.LebelStopIP.Size = new System.Drawing.Size(74, 20);
            this.LebelStopIP.TabIndex = 1;
            this.LebelStopIP.Text = "Stop IP:";
            // 
            // LebelStartIP
            // 
            this.LebelStartIP.AutoSize = true;
            this.LebelStartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelStartIP.Location = new System.Drawing.Point(6, 24);
            this.LebelStartIP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelStartIP.Name = "LebelStartIP";
            this.LebelStartIP.Size = new System.Drawing.Size(76, 20);
            this.LebelStartIP.TabIndex = 0;
            this.LebelStartIP.Text = "Start IP:";
            // 
            // checkBoxFolder
            // 
            this.checkBoxFolder.AutoSize = true;
            this.checkBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFolder.Location = new System.Drawing.Point(364, 64);
            this.checkBoxFolder.Name = "checkBoxFolder";
            this.checkBoxFolder.Size = new System.Drawing.Size(143, 24);
            this.checkBoxFolder.TabIndex = 8;
            this.checkBoxFolder.Text = "Folder Update";
            this.checkBoxFolder.UseVisualStyleBackColor = true;
            this.checkBoxFolder.CheckedChanged += new System.EventHandler(this.checkBoxFolder_CheckedChanged);
            // 
            // UpdateFile
            // 
            this.UpdateFile.Controls.Add(this.checkBoxFolder);
            this.UpdateFile.Controls.Add(this.labelTextBox);
            this.UpdateFile.Controls.Add(this.label);
            this.UpdateFile.Controls.Add(this.Selects);
            this.UpdateFile.Controls.Add(this.textBox);
            this.UpdateFile.Location = new System.Drawing.Point(276, 2);
            this.UpdateFile.Name = "UpdateFile";
            this.UpdateFile.Size = new System.Drawing.Size(601, 100);
            this.UpdateFile.TabIndex = 4;
            this.UpdateFile.TabStop = false;
            // 
            // labelTextBox
            // 
            this.labelTextBox.AutoSize = true;
            this.labelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextBox.Location = new System.Drawing.Point(74, 64);
            this.labelTextBox.MaximumSize = new System.Drawing.Size(295, 20);
            this.labelTextBox.Name = "labelTextBox";
            this.labelTextBox.Size = new System.Drawing.Size(0, 20);
            this.labelTextBox.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(5, 64);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 20);
            this.label.TabIndex = 7;
            this.label.Text = "Module:";
            // 
            // Selects
            // 
            this.Selects.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.BackgroundImage = global::Updater.Properties.Resources.select;
            this.Selects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Selects.FlatAppearance.BorderSize = 0;
            this.Selects.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selects.Location = new System.Drawing.Point(515, 13);
            this.Selects.Margin = new System.Windows.Forms.Padding(5);
            this.Selects.Name = "Selects";
            this.Selects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Selects.Size = new System.Drawing.Size(80, 80);
            this.Selects.TabIndex = 6;
            this.Selects.UseVisualStyleBackColor = false;
            this.Selects.Click += new System.EventHandler(this.Selects_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(10, 21);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(497, 26);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Select the file to update.";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1567, 559);
            this.dataGridView.TabIndex = 5;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(1099, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(473, 83);
            this.progressBar.TabIndex = 6;
            this.progressBar.Value = 10;
            // 
            // Updater
            // 
            this.Updater.Controls.Add(this.Save);
            this.Updater.Controls.Add(this.Updates);
            this.Updater.Location = new System.Drawing.Point(891, 2);
            this.Updater.Name = "Updater";
            this.Updater.Size = new System.Drawing.Size(192, 100);
            this.Updater.TabIndex = 3;
            this.Updater.TabStop = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.BackgroundImage = global::Updater.Properties.Resources.save;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(8, 12);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 80);
            this.Save.TabIndex = 7;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Updates
            // 
            this.Updates.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updates.BackgroundImage = global::Updater.Properties.Resources.update;
            this.Updates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Updates.FlatAppearance.BorderSize = 0;
            this.Updates.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updates.Location = new System.Drawing.Point(104, 13);
            this.Updates.Margin = new System.Windows.Forms.Padding(5);
            this.Updates.Name = "Updates";
            this.Updates.Size = new System.Drawing.Size(80, 80);
            this.Updates.TabIndex = 6;
            this.Updates.UseVisualStyleBackColor = false;
            this.Updates.Click += new System.EventHandler(this.Updates_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1113, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(471, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 498);
            this.listBox1.TabIndex = 9;
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 681);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.UpdateFile);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.RangeIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 720);
            this.Name = "Ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.UpdateFile.ResumeLayout(false);
            this.UpdateFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Updater.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RangeIP;
        private System.Windows.Forms.TextBox StopIP;
        private System.Windows.Forms.TextBox StartIP;
        private System.Windows.Forms.Label LebelStopIP;
        private System.Windows.Forms.Label LebelStartIP;
        private System.Windows.Forms.CheckBox checkBoxFolder;
        private System.Windows.Forms.Button Updates;
        private System.Windows.Forms.GroupBox UpdateFile;
        private System.Windows.Forms.Label labelTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Selects;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox Updater;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

