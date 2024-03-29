﻿namespace SSH
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
            this.Stop_IP = new System.Windows.Forms.TextBox();
            this.Start_IP = new System.Windows.Forms.TextBox();
            this.Lebel_stop_IP = new System.Windows.Forms.Label();
            this.Lebel_start_IP = new System.Windows.Forms.Label();
            this.ListIP = new System.Windows.Forms.GroupBox();
            this.RangeIP.SuspendLayout();
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
            this.RangeIP.Margin = new System.Windows.Forms.Padding(8);
            this.RangeIP.Name = "RangeIP";
            this.RangeIP.Padding = new System.Windows.Forms.Padding(8);
            this.RangeIP.Size = new System.Drawing.Size(320, 96);
            this.RangeIP.TabIndex = 1;
            this.RangeIP.TabStop = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Search.BackgroundImage = global::SSH.Properties.Resources.search;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(250, 21);
            this.Search.Margin = new System.Windows.Forms.Padding(8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 60);
            this.Search.TabIndex = 4;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Stop_IP
            // 
            this.Stop_IP.Location = new System.Drawing.Point(88, 52);
            this.Stop_IP.Margin = new System.Windows.Forms.Padding(8);
            this.Stop_IP.Name = "Stop_IP";
            this.Stop_IP.Size = new System.Drawing.Size(150, 26);
            this.Stop_IP.TabIndex = 3;
            this.Stop_IP.Text = "192.168.88.19";
            this.Stop_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Start_IP
            // 
            this.Start_IP.Location = new System.Drawing.Point(88, 20);
            this.Start_IP.Margin = new System.Windows.Forms.Padding(8);
            this.Start_IP.Name = "Start_IP";
            this.Start_IP.Size = new System.Drawing.Size(150, 26);
            this.Start_IP.TabIndex = 2;
            this.Start_IP.Text = "192.168.88.11";
            this.Start_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lebel_stop_IP
            // 
            this.Lebel_stop_IP.AutoSize = true;
            this.Lebel_stop_IP.Location = new System.Drawing.Point(8, 55);
            this.Lebel_stop_IP.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lebel_stop_IP.Name = "Lebel_stop_IP";
            this.Lebel_stop_IP.Size = new System.Drawing.Size(74, 20);
            this.Lebel_stop_IP.TabIndex = 1;
            this.Lebel_stop_IP.Text = "Stop IP:";
            // 
            // Lebel_start_IP
            // 
            this.Lebel_start_IP.AutoSize = true;
            this.Lebel_start_IP.Location = new System.Drawing.Point(8, 23);
            this.Lebel_start_IP.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Lebel_start_IP.Name = "Lebel_start_IP";
            this.Lebel_start_IP.Size = new System.Drawing.Size(76, 20);
            this.Lebel_start_IP.TabIndex = 0;
            this.Lebel_start_IP.Text = "Start IP:";
            // 
            // ListIP
            // 
            this.ListIP.Location = new System.Drawing.Point(8, 96);
            this.ListIP.Name = "ListIP";
            this.ListIP.Size = new System.Drawing.Size(320, 534);
            this.ListIP.TabIndex = 2;
            this.ListIP.TabStop = false;
            // 
            // Ui
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ListIP);
            this.Controls.Add(this.RangeIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Ui";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SSH";
            this.Load += new System.EventHandler(this.Ui_Load);
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RangeIP;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Stop_IP;
        private System.Windows.Forms.TextBox Start_IP;
        private System.Windows.Forms.Label Lebel_stop_IP;
        private System.Windows.Forms.Label Lebel_start_IP;
        private System.Windows.Forms.GroupBox ListIP;
    }
}

