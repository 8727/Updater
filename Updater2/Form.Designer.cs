namespace Updater2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Updater2 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.Updates = new System.Windows.Forms.Button();
            this.maxParallelism = new System.Windows.Forms.TrackBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.auti = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LebelPass = new System.Windows.Forms.Label();
            this.LebelLogin = new System.Windows.Forms.Label();
            this.labeltext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltext1 = new System.Windows.Forms.Label();
            this.labeltext5 = new System.Windows.Forms.Label();
            this.labeltext10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RangeIP.SuspendLayout();
            this.UpdateFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Updater2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxParallelism)).BeginInit();
            this.auti.SuspendLayout();
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
            this.Search.BackgroundImage = global::Updater2.Properties.Resources.search;
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
            this.Search.MouseHover += new System.EventHandler(this.Search_MouseHover);
            // 
            // StopIP
            // 
            this.StopIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopIP.Location = new System.Drawing.Point(92, 57);
            this.StopIP.Margin = new System.Windows.Forms.Padding(5);
            this.StopIP.Name = "StopIP";
            this.StopIP.Size = new System.Drawing.Size(147, 26);
            this.StopIP.TabIndex = 3;
            this.StopIP.Text = "10.158.1.20";
            this.StopIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StopIP.MouseHover += new System.EventHandler(this.StopIP_MouseHover);
            // 
            // StartIP
            // 
            this.StartIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartIP.Location = new System.Drawing.Point(92, 21);
            this.StartIP.Margin = new System.Windows.Forms.Padding(5);
            this.StartIP.Name = "StartIP";
            this.StartIP.Size = new System.Drawing.Size(147, 26);
            this.StartIP.TabIndex = 2;
            this.StartIP.Text = "10.158.1.2";
            this.StartIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartIP.MouseHover += new System.EventHandler(this.StartIP_MouseHover);
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
            this.checkBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFolder.AutoSize = true;
            this.checkBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFolder.Location = new System.Drawing.Point(162, 56);
            this.checkBoxFolder.Name = "checkBoxFolder";
            this.checkBoxFolder.Size = new System.Drawing.Size(200, 33);
            this.checkBoxFolder.TabIndex = 8;
            this.checkBoxFolder.Text = "Folder Update";
            this.checkBoxFolder.UseVisualStyleBackColor = true;
            this.checkBoxFolder.CheckedChanged += new System.EventHandler(this.checkBoxFolder_CheckedChanged);
            this.checkBoxFolder.MouseHover += new System.EventHandler(this.checkBoxFolder_MouseHover);
            // 
            // UpdateFile
            // 
            this.UpdateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateFile.Controls.Add(this.checkBoxFolder);
            this.UpdateFile.Controls.Add(this.Selects);
            this.UpdateFile.Controls.Add(this.textBox);
            this.UpdateFile.Location = new System.Drawing.Point(679, 2);
            this.UpdateFile.Name = "UpdateFile";
            this.UpdateFile.Size = new System.Drawing.Size(463, 100);
            this.UpdateFile.TabIndex = 4;
            this.UpdateFile.TabStop = false;
            // 
            // Selects
            // 
            this.Selects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Selects.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Selects.BackgroundImage = global::Updater2.Properties.Resources.select;
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
            this.Selects.MouseHover += new System.EventHandler(this.Selects_MouseHover);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView.Location = new System.Drawing.Point(8, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(1567, 551);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drop_DragDrop);
            this.dataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_DragEnter);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 667);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1567, 30);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 6;
            this.progressBar.MouseHover += new System.EventHandler(this.progressBar_MouseHover);
            // 
            // Updater2
            // 
            this.Updater2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updater2.Controls.Add(this.Save);
            this.Updater2.Controls.Add(this.Updates);
            this.Updater2.Location = new System.Drawing.Point(1153, 2);
            this.Updater2.Name = "Updater2";
            this.Updater2.Size = new System.Drawing.Size(192, 100);
            this.Updater2.TabIndex = 3;
            this.Updater2.TabStop = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.BackgroundImage = global::Updater2.Properties.Resources.save;
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
            this.Save.MouseHover += new System.EventHandler(this.Save_MouseHover);
            // 
            // Updates
            // 
            this.Updates.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Updates.BackgroundImage = global::Updater2.Properties.Resources.update;
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
            this.Updates.MouseHover += new System.EventHandler(this.Updates_MouseHover);
            // 
            // maxParallelism
            // 
            this.maxParallelism.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxParallelism.AutoSize = false;
            this.maxParallelism.Location = new System.Drawing.Point(1351, 73);
            this.maxParallelism.Minimum = 1;
            this.maxParallelism.Name = "maxParallelism";
            this.maxParallelism.Size = new System.Drawing.Size(221, 29);
            this.maxParallelism.TabIndex = 7;
            this.maxParallelism.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.maxParallelism.Value = 5;
            this.maxParallelism.MouseHover += new System.EventHandler(this.maxParallelism_MouseHover);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.GrayText;
            this.toolTip.IsBalloon = true;
            // 
            // auti
            // 
            this.auti.Controls.Add(this.textBox3);
            this.auti.Controls.Add(this.textBox1);
            this.auti.Controls.Add(this.labelPort);
            this.auti.Controls.Add(this.textBox2);
            this.auti.Controls.Add(this.LebelPass);
            this.auti.Controls.Add(this.LebelLogin);
            this.auti.Location = new System.Drawing.Point(354, 2);
            this.auti.Margin = new System.Windows.Forms.Padding(5);
            this.auti.Name = "auti";
            this.auti.Padding = new System.Windows.Forms.Padding(5);
            this.auti.Size = new System.Drawing.Size(315, 100);
            this.auti.TabIndex = 8;
            this.auti.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(200, 57);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "22";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(72, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "user";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.Location = new System.Drawing.Point(224, 24);
            this.labelPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(47, 20);
            this.labelPort.TabIndex = 9;
            this.labelPort.Text = "Port:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(72, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "user";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LebelPass
            // 
            this.LebelPass.AutoSize = true;
            this.LebelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelPass.Location = new System.Drawing.Point(11, 60);
            this.LebelPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelPass.Name = "LebelPass";
            this.LebelPass.Size = new System.Drawing.Size(53, 20);
            this.LebelPass.TabIndex = 1;
            this.LebelPass.Text = "Pass:";
            // 
            // LebelLogin
            // 
            this.LebelLogin.AutoSize = true;
            this.LebelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LebelLogin.Location = new System.Drawing.Point(6, 24);
            this.LebelLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LebelLogin.Name = "LebelLogin";
            this.LebelLogin.Size = new System.Drawing.Size(58, 20);
            this.LebelLogin.TabIndex = 0;
            this.LebelLogin.Text = "Login:";
            // 
            // labeltext
            // 
            this.labeltext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltext.AutoSize = true;
            this.labeltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext.Location = new System.Drawing.Point(1370, 9);
            this.labeltext.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(188, 20);
            this.labeltext.TabIndex = 9;
            this.labeltext.Text = "The number of parallel";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1426, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "updates.";
            // 
            // labeltext1
            // 
            this.labeltext1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltext1.AutoSize = true;
            this.labeltext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext1.Location = new System.Drawing.Point(1356, 55);
            this.labeltext1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeltext1.Name = "labeltext1";
            this.labeltext1.Size = new System.Drawing.Size(19, 20);
            this.labeltext1.TabIndex = 11;
            this.labeltext1.Text = "1";
            // 
            // labeltext5
            // 
            this.labeltext5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltext5.AutoSize = true;
            this.labeltext5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext5.Location = new System.Drawing.Point(1442, 55);
            this.labeltext5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeltext5.Name = "labeltext5";
            this.labeltext5.Size = new System.Drawing.Size(19, 20);
            this.labeltext5.TabIndex = 12;
            this.labeltext5.Text = "5";
            // 
            // labeltext10
            // 
            this.labeltext10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltext10.AutoSize = true;
            this.labeltext10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltext10.Location = new System.Drawing.Point(1545, 55);
            this.labeltext10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeltext10.Name = "labeltext10";
            this.labeltext10.Size = new System.Drawing.Size(29, 20);
            this.labeltext10.TabIndex = 13;
            this.labeltext10.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1378, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1399, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1421, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1463, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "6";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1484, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "7";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1506, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "8";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1526, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "9";
            // 
            // Ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeltext10);
            this.Controls.Add(this.labeltext5);
            this.Controls.Add(this.labeltext1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltext);
            this.Controls.Add(this.auti);
            this.Controls.Add(this.maxParallelism);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.UpdateFile);
            this.Controls.Add(this.Updater2);
            this.Controls.Add(this.RangeIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 737);
            this.Name = "Ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater2";
            this.RangeIP.ResumeLayout(false);
            this.RangeIP.PerformLayout();
            this.UpdateFile.ResumeLayout(false);
            this.UpdateFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Updater2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxParallelism)).EndInit();
            this.auti.ResumeLayout(false);
            this.auti.PerformLayout();
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
        private System.Windows.Forms.Button Selects;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox Updater2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TrackBar maxParallelism;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox auti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LebelPass;
        private System.Windows.Forms.Label LebelLogin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltext1;
        private System.Windows.Forms.Label labeltext5;
        private System.Windows.Forms.Label labeltext10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

