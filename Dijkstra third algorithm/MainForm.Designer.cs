namespace Dijkstra_third_algorithm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.m_numOfProcTextBox = new System.Windows.Forms.TextBox();
            this.m_randomButton = new System.Windows.Forms.Button();
            this.m_procPanel = new System.Windows.Forms.Panel();
            this.m_chosenLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundButton2 = new Dijkstra_third_algorithm.RoundButton();
            this.roundButton1 = new Dijkstra_third_algorithm.RoundButton();
            this.m_copyrightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_deltaYLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.m_secSchedulerTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m_kTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_autoSchedularCheckbox = new System.Windows.Forms.CheckBox();
            this.m_viewAsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.m_displayArrowCheckBox = new System.Windows.Forms.CheckBox();
            this.m_ringRadio = new System.Windows.Forms.RadioButton();
            this.m_sringRadio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toggleSwitch1 = new Dijkstra_third_algorithm.ToggleSwitch();
            this.m_oneArrowButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_noArrowsButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_procPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.m_viewAsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(290, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "N = ";
            this.toolTip1.SetToolTip(this.label1, "Number of processors");
            // 
            // m_numOfProcTextBox
            // 
            this.m_numOfProcTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.m_numOfProcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_numOfProcTextBox.Location = new System.Drawing.Point(330, 11);
            this.m_numOfProcTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_numOfProcTextBox.Name = "m_numOfProcTextBox";
            this.m_numOfProcTextBox.Size = new System.Drawing.Size(36, 29);
            this.m_numOfProcTextBox.TabIndex = 1;
            this.m_numOfProcTextBox.TabStop = false;
            this.m_numOfProcTextBox.Text = "0";
            this.m_numOfProcTextBox.TextChanged += new System.EventHandler(this.NumOfProcTextBox_TextChanged);
            // 
            // m_randomButton
            // 
            this.m_randomButton.BackColor = System.Drawing.Color.Gold;
            this.m_randomButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_randomButton.ForeColor = System.Drawing.Color.Black;
            this.m_randomButton.Location = new System.Drawing.Point(561, 12);
            this.m_randomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_randomButton.Name = "m_randomButton";
            this.m_randomButton.Size = new System.Drawing.Size(98, 25);
            this.m_randomButton.TabIndex = 7;
            this.m_randomButton.TabStop = false;
            this.m_randomButton.Text = "Random";
            this.toolTip1.SetToolTip(this.m_randomButton, "Set random states to all processors");
            this.m_randomButton.UseVisualStyleBackColor = false;
            this.m_randomButton.Click += new System.EventHandler(this.Random_Click);
            // 
            // m_procPanel
            // 
            this.m_procPanel.Controls.Add(this.m_chosenLabel);
            this.m_procPanel.Controls.Add(this.label6);
            this.m_procPanel.Controls.Add(this.label5);
            this.m_procPanel.Controls.Add(this.roundButton2);
            this.m_procPanel.Controls.Add(this.roundButton1);
            this.m_procPanel.Controls.Add(this.m_copyrightLabel);
            this.m_procPanel.Controls.Add(this.label3);
            this.m_procPanel.Controls.Add(this.m_deltaYLabel);
            this.m_procPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_procPanel.Location = new System.Drawing.Point(0, 0);
            this.m_procPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_procPanel.Name = "m_procPanel";
            this.m_procPanel.Size = new System.Drawing.Size(1099, 668);
            this.m_procPanel.TabIndex = 8;
            // 
            // m_chosenLabel
            // 
            this.m_chosenLabel.AutoSize = true;
            this.m_chosenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.m_chosenLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_chosenLabel.Location = new System.Drawing.Point(317, 28);
            this.m_chosenLabel.Name = "m_chosenLabel";
            this.m_chosenLabel.Size = new System.Drawing.Size(0, 24);
            this.m_chosenLabel.TabIndex = 19;
            this.m_chosenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(44, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "- Not Priviliged";
            this.toolTip1.SetToolTip(this.label6, "Number of processors");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "- Priviliged";
            this.toolTip1.SetToolTip(this.label5, "Number of processors");
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.LightYellow;
            this.roundButton2.Enabled = false;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.Black;
            this.roundButton2.Location = new System.Drawing.Point(12, 58);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(33, 33);
            this.roundButton2.TabIndex = 17;
            this.roundButton2.Text = "Pi";
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.LightGreen;
            this.roundButton1.Enabled = false;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(12, 19);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(33, 33);
            this.roundButton1.TabIndex = 16;
            this.roundButton1.Text = "Pi";
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // m_copyrightLabel
            // 
            this.m_copyrightLabel.AutoSize = true;
            this.m_copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_copyrightLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.m_copyrightLabel.Location = new System.Drawing.Point(318, 642);
            this.m_copyrightLabel.Name = "m_copyrightLabel";
            this.m_copyrightLabel.Size = new System.Drawing.Size(222, 17);
            this.m_copyrightLabel.TabIndex = 15;
            this.m_copyrightLabel.Text = "© Eyal Maoz (eyalvfs@gmail.com)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(270, 840);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "© Eyal Maoz, Tomer Goldberg";
            // 
            // m_deltaYLabel
            // 
            this.m_deltaYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_deltaYLabel.AutoSize = true;
            this.m_deltaYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_deltaYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_deltaYLabel.Location = new System.Drawing.Point(947, 28);
            this.m_deltaYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_deltaYLabel.Name = "m_deltaYLabel";
            this.m_deltaYLabel.Size = new System.Drawing.Size(0, 24);
            this.m_deltaYLabel.TabIndex = 13;
            this.m_deltaYLabel.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.m_secSchedulerTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.m_kTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.m_autoSchedularCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.m_viewAsPanel);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.toggleSwitch1);
            this.splitContainer1.Panel1.Controls.Add(this.m_oneArrowButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.m_noArrowsButton);
            this.splitContainer1.Panel1.Controls.Add(this.m_randomButton);
            this.splitContainer1.Panel1.Controls.Add(this.m_numOfProcTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_procPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 782);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 9;
            // 
            // m_secSchedulerTextBox
            // 
            this.m_secSchedulerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_secSchedulerTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.m_secSchedulerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_secSchedulerTextBox.Location = new System.Drawing.Point(1029, 53);
            this.m_secSchedulerTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_secSchedulerTextBox.Name = "m_secSchedulerTextBox";
            this.m_secSchedulerTextBox.Size = new System.Drawing.Size(42, 29);
            this.m_secSchedulerTextBox.TabIndex = 24;
            this.m_secSchedulerTextBox.TabStop = false;
            this.m_secSchedulerTextBox.Text = "0.5";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(925, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Step (sec):";
            this.toolTip1.SetToolTip(this.label11, "Step in second for the Auto Schedular");
            // 
            // m_kTextBox
            // 
            this.m_kTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.m_kTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_kTextBox.Location = new System.Drawing.Point(330, 50);
            this.m_kTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_kTextBox.Name = "m_kTextBox";
            this.m_kTextBox.Size = new System.Drawing.Size(36, 29);
            this.m_kTextBox.TabIndex = 22;
            this.m_kTextBox.TabStop = false;
            this.m_kTextBox.Text = "3";
            this.m_kTextBox.TextChanged += new System.EventHandler(this.m_kTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(290, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "K = ";
            this.toolTip1.SetToolTip(this.label10, "Number of processors");
            // 
            // m_autoSchedularCheckbox
            // 
            this.m_autoSchedularCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_autoSchedularCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_autoSchedularCheckbox.BackColor = System.Drawing.Color.Red;
            this.m_autoSchedularCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_autoSchedularCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_autoSchedularCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_autoSchedularCheckbox.Location = new System.Drawing.Point(929, 8);
            this.m_autoSchedularCheckbox.Name = "m_autoSchedularCheckbox";
            this.m_autoSchedularCheckbox.Size = new System.Drawing.Size(158, 37);
            this.m_autoSchedularCheckbox.TabIndex = 16;
            this.m_autoSchedularCheckbox.Text = "Auto Scheduler";
            this.m_autoSchedularCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.m_autoSchedularCheckbox, "Will choose priviliged processor automatically every 2 seconds");
            this.m_autoSchedularCheckbox.UseVisualStyleBackColor = false;
            this.m_autoSchedularCheckbox.CheckedChanged += new System.EventHandler(this.AutoSchedularCheckbox_CheckedChanged);
            // 
            // m_viewAsPanel
            // 
            this.m_viewAsPanel.Controls.Add(this.label2);
            this.m_viewAsPanel.Controls.Add(this.m_displayArrowCheckBox);
            this.m_viewAsPanel.Controls.Add(this.m_ringRadio);
            this.m_viewAsPanel.Controls.Add(this.m_sringRadio);
            this.m_viewAsPanel.Location = new System.Drawing.Point(671, 5);
            this.m_viewAsPanel.Name = "m_viewAsPanel";
            this.m_viewAsPanel.Size = new System.Drawing.Size(240, 93);
            this.m_viewAsPanel.TabIndex = 20;
            this.m_viewAsPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "View as:";
            // 
            // m_displayArrowCheckBox
            // 
            this.m_displayArrowCheckBox.AutoSize = true;
            this.m_displayArrowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_displayArrowCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_displayArrowCheckBox.Location = new System.Drawing.Point(88, 54);
            this.m_displayArrowCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_displayArrowCheckBox.Name = "m_displayArrowCheckBox";
            this.m_displayArrowCheckBox.Size = new System.Drawing.Size(153, 28);
            this.m_displayArrowCheckBox.TabIndex = 11;
            this.m_displayArrowCheckBox.Text = "Display Arrows";
            this.toolTip1.SetToolTip(this.m_displayArrowCheckBox, "Draw arrows");
            this.m_displayArrowCheckBox.UseVisualStyleBackColor = true;
            this.m_displayArrowCheckBox.Visible = false;
            this.m_displayArrowCheckBox.CheckedChanged += new System.EventHandler(this.DisplayArrowCheckBox_CheckedChanged);
            // 
            // m_ringRadio
            // 
            this.m_ringRadio.AutoSize = true;
            this.m_ringRadio.Checked = true;
            this.m_ringRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_ringRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ringRadio.Location = new System.Drawing.Point(6, 28);
            this.m_ringRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_ringRadio.Name = "m_ringRadio";
            this.m_ringRadio.Size = new System.Drawing.Size(67, 28);
            this.m_ringRadio.TabIndex = 8;
            this.m_ringRadio.TabStop = true;
            this.m_ringRadio.Text = "Ring";
            this.toolTip1.SetToolTip(this.m_ringRadio, "Show as a circle");
            this.m_ringRadio.UseVisualStyleBackColor = true;
            this.m_ringRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // m_sringRadio
            // 
            this.m_sringRadio.AutoSize = true;
            this.m_sringRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_sringRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_sringRadio.Location = new System.Drawing.Point(6, 54);
            this.m_sringRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_sringRadio.Name = "m_sringRadio";
            this.m_sringRadio.Size = new System.Drawing.Size(76, 28);
            this.m_sringRadio.TabIndex = 9;
            this.m_sringRadio.Text = "String";
            this.toolTip1.SetToolTip(this.m_sringRadio, "Show as a string");
            this.m_sringRadio.UseVisualStyleBackColor = true;
            this.m_sringRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(149, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Third";
            this.toolTip1.SetToolTip(this.label9, "Number of processors");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "First";
            this.toolTip1.SetToolTip(this.label8, "Number of processors");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Algorithm:";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(58, 42);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Padding = new System.Windows.Forms.Padding(6);
            this.toggleSwitch1.Size = new System.Drawing.Size(86, 37);
            this.toggleSwitch1.TabIndex = 17;
            this.toggleSwitch1.Text = "toggleSwitch1";
            this.toggleSwitch1.UseVisualStyleBackColor = true;
            this.toggleSwitch1.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // m_oneArrowButton
            // 
            this.m_oneArrowButton.BackColor = System.Drawing.Color.Gold;
            this.m_oneArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_oneArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_oneArrowButton.ForeColor = System.Drawing.Color.Black;
            this.m_oneArrowButton.Location = new System.Drawing.Point(561, 43);
            this.m_oneArrowButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_oneArrowButton.Name = "m_oneArrowButton";
            this.m_oneArrowButton.Size = new System.Drawing.Size(98, 25);
            this.m_oneArrowButton.TabIndex = 14;
            this.m_oneArrowButton.Text = "One Arrow";
            this.toolTip1.SetToolTip(this.m_oneArrowButton, "Set state such that only one arrow exist");
            this.m_oneArrowButton.UseVisualStyleBackColor = false;
            this.m_oneArrowButton.Visible = false;
            this.m_oneArrowButton.Click += new System.EventHandler(this.OneArrowButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(409, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Configurations:";
            // 
            // m_noArrowsButton
            // 
            this.m_noArrowsButton.BackColor = System.Drawing.Color.Gold;
            this.m_noArrowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_noArrowsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_noArrowsButton.ForeColor = System.Drawing.Color.Black;
            this.m_noArrowsButton.Location = new System.Drawing.Point(561, 76);
            this.m_noArrowsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_noArrowsButton.Name = "m_noArrowsButton";
            this.m_noArrowsButton.Size = new System.Drawing.Size(98, 25);
            this.m_noArrowsButton.TabIndex = 12;
            this.m_noArrowsButton.Text = "No Arrows";
            this.toolTip1.SetToolTip(this.m_noArrowsButton, "Set state such that no arrow exist");
            this.m_noArrowsButton.UseVisualStyleBackColor = false;
            this.m_noArrowsButton.Visible = false;
            this.m_noArrowsButton.Click += new System.EventHandler(this.AllEqual_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 1000000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Guide";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1099, 782);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(660, 350);
            this.Name = "MainForm";
            this.Text = "Dijkstra\'s Algorithms Simulation";
            this.Resize += new System.EventHandler(this.ResizeForm);
            this.m_procPanel.ResumeLayout(false);
            this.m_procPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.m_viewAsPanel.ResumeLayout(false);
            this.m_viewAsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_numOfProcTextBox;
        private System.Windows.Forms.Button m_randomButton;
        private System.Windows.Forms.Panel m_procPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton m_sringRadio;
        private System.Windows.Forms.RadioButton m_ringRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox m_displayArrowCheckBox;
        private System.Windows.Forms.Button m_noArrowsButton;
        private System.Windows.Forms.Label m_deltaYLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label m_copyrightLabel;
        private RoundButton roundButton2;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button m_oneArrowButton;
        private System.Windows.Forms.CheckBox m_autoSchedularCheckbox;
        private System.Windows.Forms.Label m_chosenLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Panel m_viewAsPanel;
        private System.Windows.Forms.TextBox m_kTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m_secSchedulerTextBox;
        private System.Windows.Forms.Label label11;
    }
}

