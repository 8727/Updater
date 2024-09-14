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
            this.Search = new System.Windows.Forms.Button();
            this.StopIP = new System.Windows.Forms.TextBox();
            this.StartIP = new System.Windows.Forms.TextBox();
            this.LebelStopIP = new System.Windows.Forms.Label();
            this.LebelStartIP = new System.Windows.Forms.Label();
            this.checkBoxFolder = new System.Windows.Forms.CheckBox();
            this.UpdateFile = new System.Windows.Forms.GroupBox();
            this.Selects = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Updater = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.Updates = new System.Windows.Forms.Button();
            this.maxParallelism = new System.Windows.Forms.TrackBar();
            this.RangeIP.SuspendLayout();
            this.UpdateFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Updater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxParallelism)).BeginInit();
            this.SuspendLayout();
            // 
            // RangeIP
            // 
            this.RangeIP.Controls.Add(this.Search);
            this.RangeIP.Controls.Add(this.StopIP);
            this.RangeIP.Controls.Add(this.StartIP);
            this.RangeIP.Controls.Add(this.LebelStopIP);
            this.RangeIP.Controls.Add(this.LebelStartIP);
            this.RangeIP.Location = new System.Drawing.Point(8, 2);
            this.RangeIP.Margin = new System.Windows.Forms.Padding(5);
            this.RangeIP.Name = "RangeIP";
            this.RangeIP.Padding = new System.Windows.Forms.Padding(5);
            this.RangeIP.Size = new System.Drawing.Size(336, 100);
            this.RangeIP.TabIndex = 1;
            this.RangeIP.TabStop = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.BackgroundImage = global::Updater.Properties.Resources.search;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(250, 13);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 80);
            this.Search.TabIndex = 7;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
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
            this.checkBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFolder.Location = new System.Drawing.Point(162, 56);
            this.checkBoxFolder.Name = "checkBoxFolder";
            this.checkBoxFolder.Size = new System.Drawing.Size(200, 33);
            this.checkBoxFolder.TabIndex = 8;
            this.checkBoxFolder.Text = "Folder Update";
            this.checkBoxFolder.UseVisualStyleBackColor = true;
            this.checkBoxFolder.CheckedChanged += new System.EventHandler(this.checkBoxFolder_CheckedChanged);
            // 
            // UpdateFile
            // 
            this.UpdateFile.Controls.Add(this.checkBoxFolder);
            this.UpdateFile.Controls.Add(this.Selects);
            this.UpdateFile.Controls.Add(this.textBox);
            this.UpdateFile.Location = new System.Drawing.Point(356, 2);
            this.UpdateFile.Name = "UpdateFile";
            this.UpdateFile.Size = new System.Drawing.Size(463, 100);
            this.UpdateFile.TabIndex = 4;
            this.UpdateFile.TabStop = false;
            // 
            // Selects
            // 
            this.Selects.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.BackgroundImage = global::Updater.Properties.Resources.select;
            this.Selects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Selects.FlatAppearance.BorderSize = 0;
            this.Selects.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selects.Location = new System.Drawing.Point(375, 13);
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
            this.textBox.Size = new System.Drawing.Size(354, 26);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Select the file to update.";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Location = new System.Drawing.Point(8, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(1567, 551);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drop_DragDrop);
            this.dataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_DragEnter);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(1087, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(488, 83);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 6;
            // 
            // Updater
            // 
            this.Updater.Controls.Add(this.Save);
            this.Updater.Controls.Add(this.Updates);
            this.Updater.Location = new System.Drawing.Point(831, 2);
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
            // maxParallelism
            // 
            this.maxParallelism.AutoSize = false;
            this.maxParallelism.Location = new System.Drawing.Point(1040, 2);
            this.maxParallelism.Minimum = 1;
            this.maxParallelism.Name = "maxParallelism";
            this.maxParallelism.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.maxParallelism.Size = new System.Drawing.Size(29, 102);
            this.maxParallelism.TabIndex = 7;
            this.maxParallelism.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.maxParallelism.Value = 5;
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 672);
            this.Controls.Add(this.maxParallelism);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.UpdateFile);
            this.Controls.Add(this.Updater);
            this.Controls.Add(this.RangeIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 707);
            this.Name = "Ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.UpdateFile.ResumeLayout(false);
            this.UpdateFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Updater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxParallelism)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Selects;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox Updater;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TrackBar maxParallelism;
    }
}

