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
            this.Save = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Stop_IP = new System.Windows.Forms.TextBox();
            this.Start_IP = new System.Windows.Forms.TextBox();
            this.Lebel_stop_IP = new System.Windows.Forms.Label();
            this.Lebel_start_IP = new System.Windows.Forms.Label();
            this.UpdateFile = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Selects = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Updater = new System.Windows.Forms.GroupBox();
            this.folderUpdate = new System.Windows.Forms.CheckBox();
            this.updateAlll = new System.Windows.Forms.CheckBox();
            this.Updates = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RangeIP.SuspendLayout();
            this.UpdateFile.SuspendLayout();
            this.Updater.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RangeIP
            // 
            this.RangeIP.Controls.Add(this.Search);
            this.RangeIP.Controls.Add(this.Stop_IP);
            this.RangeIP.Controls.Add(this.Start_IP);
            this.RangeIP.Controls.Add(this.Lebel_stop_IP);
            this.RangeIP.Controls.Add(this.Lebel_start_IP);
            this.RangeIP.Location = new System.Drawing.Point(8, 0);
            this.RangeIP.Margin = new System.Windows.Forms.Padding(5);
            this.RangeIP.Name = "RangeIP";
            this.RangeIP.Padding = new System.Windows.Forms.Padding(5);
            this.RangeIP.Size = new System.Drawing.Size(371, 100);
            this.RangeIP.TabIndex = 0;
            this.RangeIP.TabStop = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.BackgroundImage = global::Updater.Properties.Resources.save;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(5, 12);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 80);
            this.Save.TabIndex = 5;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.BackgroundImage = global::Updater.Properties.Resources.search;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(285, 14);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 80);
            this.Search.TabIndex = 4;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Stop_IP
            // 
            this.Stop_IP.Location = new System.Drawing.Point(92, 57);
            this.Stop_IP.Margin = new System.Windows.Forms.Padding(5);
            this.Stop_IP.Name = "Stop_IP";
            this.Stop_IP.Size = new System.Drawing.Size(183, 26);
            this.Stop_IP.TabIndex = 3;
            this.Stop_IP.Text = "192.168.88.19";
            this.Stop_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start_IP
            // 
            this.Start_IP.Location = new System.Drawing.Point(92, 21);
            this.Start_IP.Margin = new System.Windows.Forms.Padding(5);
            this.Start_IP.Name = "Start_IP";
            this.Start_IP.Size = new System.Drawing.Size(183, 26);
            this.Start_IP.TabIndex = 2;
            this.Start_IP.Text = "192.168.88.11";
            this.Start_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lebel_stop_IP
            // 
            this.Lebel_stop_IP.AutoSize = true;
            this.Lebel_stop_IP.Location = new System.Drawing.Point(8, 60);
            this.Lebel_stop_IP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lebel_stop_IP.Name = "Lebel_stop_IP";
            this.Lebel_stop_IP.Size = new System.Drawing.Size(74, 20);
            this.Lebel_stop_IP.TabIndex = 1;
            this.Lebel_stop_IP.Text = "Stop IP:";
            // 
            // Lebel_start_IP
            // 
            this.Lebel_start_IP.AutoSize = true;
            this.Lebel_start_IP.Location = new System.Drawing.Point(6, 24);
            this.Lebel_start_IP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lebel_start_IP.Name = "Lebel_start_IP";
            this.Lebel_start_IP.Size = new System.Drawing.Size(76, 20);
            this.Lebel_start_IP.TabIndex = 0;
            this.Lebel_start_IP.Text = "Start IP:";
            // 
            // UpdateFile
            // 
            this.UpdateFile.Controls.Add(this.label4);
            this.UpdateFile.Controls.Add(this.label3);
            this.UpdateFile.Controls.Add(this.label2);
            this.UpdateFile.Controls.Add(this.label1);
            this.UpdateFile.Controls.Add(this.Selects);
            this.UpdateFile.Controls.Add(this.textBox1);
            this.UpdateFile.Location = new System.Drawing.Point(634, 0);
            this.UpdateFile.Name = "UpdateFile";
            this.UpdateFile.Size = new System.Drawing.Size(601, 100);
            this.UpdateFile.TabIndex = 1;
            this.UpdateFile.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "22.22.22.-dev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "2.2-fix_master-9mp-foton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Module:";
            // 
            // Selects
            // 
            this.Selects.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.BackgroundImage = global::Updater.Properties.Resources.select;
            this.Selects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Selects.FlatAppearance.BorderSize = 0;
            this.Selects.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selects.Location = new System.Drawing.Point(515, 14);
            this.Selects.Margin = new System.Windows.Forms.Padding(5);
            this.Selects.Name = "Selects";
            this.Selects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Selects.Size = new System.Drawing.Size(80, 80);
            this.Selects.TabIndex = 6;
            this.Selects.UseVisualStyleBackColor = false;
            this.Selects.Click += new System.EventHandler(this.Select_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Updater
            // 
            this.Updater.Controls.Add(this.folderUpdate);
            this.Updater.Controls.Add(this.updateAlll);
            this.Updater.Controls.Add(this.Updates);
            this.Updater.Location = new System.Drawing.Point(386, 0);
            this.Updater.Name = "Updater";
            this.Updater.Size = new System.Drawing.Size(240, 100);
            this.Updater.TabIndex = 2;
            this.Updater.TabStop = false;
            // 
            // folderUpdate
            // 
            this.folderUpdate.AutoSize = true;
            this.folderUpdate.Checked = true;
            this.folderUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.folderUpdate.Location = new System.Drawing.Point(6, 60);
            this.folderUpdate.Name = "folderUpdate";
            this.folderUpdate.Size = new System.Drawing.Size(143, 24);
            this.folderUpdate.TabIndex = 8;
            this.folderUpdate.Text = "Folder Update";
            this.folderUpdate.UseVisualStyleBackColor = true;
            // 
            // updateAlll
            // 
            this.updateAlll.AutoSize = true;
            this.updateAlll.Location = new System.Drawing.Point(6, 23);
            this.updateAlll.Name = "updateAlll";
            this.updateAlll.Size = new System.Drawing.Size(112, 24);
            this.updateAlll.TabIndex = 7;
            this.updateAlll.Text = "Update All";
            this.updateAlll.UseVisualStyleBackColor = true;
            // 
            // Updates
            // 
            this.Updates.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updates.BackgroundImage = global::Updater.Properties.Resources.update;
            this.Updates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Updates.FlatAppearance.BorderSize = 0;
            this.Updates.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updates.Location = new System.Drawing.Point(154, 14);
            this.Updates.Margin = new System.Windows.Forms.Padding(5);
            this.Updates.Name = "Updates";
            this.Updates.Size = new System.Drawing.Size(80, 80);
            this.Updates.TabIndex = 6;
            this.Updates.UseVisualStyleBackColor = false;
            this.Updates.Click += new System.EventHandler(this.Update_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(8, 650);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1564, 25);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Value = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(8, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 536);
            this.panel1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1566, 536);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.ForeColor = System.Drawing.Color.Red;
            this.LabelInfo.Location = new System.Drawing.Point(564, 214);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(438, 108);
            this.LabelInfo.TabIndex = 0;
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Location = new System.Drawing.Point(1241, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1584, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.UpdateFile);
            this.Controls.Add(this.RangeIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.Ui_Load);
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.UpdateFile.ResumeLayout(false);
            this.UpdateFile.PerformLayout();
            this.Updater.ResumeLayout(false);
            this.Updater.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RangeIP;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Stop_IP;
        private System.Windows.Forms.TextBox Start_IP;
        private System.Windows.Forms.Label Lebel_stop_IP;
        private System.Windows.Forms.Label Lebel_start_IP;
        private System.Windows.Forms.GroupBox UpdateFile;
        private System.Windows.Forms.GroupBox Updater;
        private System.Windows.Forms.CheckBox folderUpdate;
        private System.Windows.Forms.CheckBox updateAlll;
        private System.Windows.Forms.Button Updates;
        private System.Windows.Forms.Button Selects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

