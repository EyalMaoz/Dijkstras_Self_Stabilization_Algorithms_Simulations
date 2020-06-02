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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_randomButton = new System.Windows.Forms.Button();
            this.m_procPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.m_deltaYLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.m_noArrowsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_sringRadio = new System.Windows.Forms.RadioButton();
            this.m_ringRadio = new System.Windows.Forms.RadioButton();
            this.m_displayArrowCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.m_copyrightLabel = new System.Windows.Forms.Label();
            this.m_procPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "N = ";
            this.toolTip1.SetToolTip(this.label1, "Number of processors");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(48, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // m_randomButton
            // 
            this.m_randomButton.BackColor = System.Drawing.Color.Gold;
            this.m_randomButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_randomButton.ForeColor = System.Drawing.Color.Black;
            this.m_randomButton.Location = new System.Drawing.Point(532, 11);
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
            this.m_procPanel.Controls.Add(this.m_copyrightLabel);
            this.m_procPanel.Controls.Add(this.label3);
            this.m_procPanel.Controls.Add(this.m_deltaYLabel);
            this.m_procPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_procPanel.Location = new System.Drawing.Point(0, 0);
            this.m_procPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_procPanel.Name = "m_procPanel";
            this.m_procPanel.Size = new System.Drawing.Size(644, 472);
            this.m_procPanel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(270, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "© Eyal Maoz, Tomer Goldberg";
            // 
            // m_deltaYLabel
            // 
            this.m_deltaYLabel.AutoSize = true;
            this.m_deltaYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_deltaYLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_deltaYLabel.Location = new System.Drawing.Point(11, 19);
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.m_noArrowsButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.m_sringRadio);
            this.splitContainer1.Panel1.Controls.Add(this.m_ringRadio);
            this.splitContainer1.Panel1.Controls.Add(this.m_randomButton);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.m_displayArrowCheckBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_procPanel);
            this.splitContainer1.Size = new System.Drawing.Size(644, 568);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(380, 9);
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
            this.m_noArrowsButton.Location = new System.Drawing.Point(532, 42);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "View as:";
            // 
            // m_sringRadio
            // 
            this.m_sringRadio.AutoSize = true;
            this.m_sringRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_sringRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_sringRadio.Location = new System.Drawing.Point(148, 58);
            this.m_sringRadio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_sringRadio.Name = "m_sringRadio";
            this.m_sringRadio.Size = new System.Drawing.Size(76, 28);
            this.m_sringRadio.TabIndex = 9;
            this.m_sringRadio.Text = "String";
            this.toolTip1.SetToolTip(this.m_sringRadio, "Show as a string");
            this.m_sringRadio.UseVisualStyleBackColor = true;
            this.m_sringRadio.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // m_ringRadio
            // 
            this.m_ringRadio.AutoSize = true;
            this.m_ringRadio.Checked = true;
            this.m_ringRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_ringRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ringRadio.Location = new System.Drawing.Point(148, 32);
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
            // m_displayArrowCheckBox
            // 
            this.m_displayArrowCheckBox.AutoSize = true;
            this.m_displayArrowCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_displayArrowCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_displayArrowCheckBox.Location = new System.Drawing.Point(230, 58);
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
            // m_copyrightLabel
            // 
            this.m_copyrightLabel.AutoSize = true;
            this.m_copyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.m_copyrightLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
           this.m_copyrightLabel.Name = "m_copyrightLabel";
            this.m_copyrightLabel.Size = new System.Drawing.Size(251, 22);
            this.m_copyrightLabel.TabIndex = 15;
            this.m_copyrightLabel.Text = "© Eyal Maoz, Tomer Goldberg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(644, 568);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(660, 350);
            this.Name = "MainForm";
            this.Text = "Dijkstra\'s 3rd Algorithm Simulation";
            this.Resize += new System.EventHandler(this.ResizeForm);
            this.m_procPanel.ResumeLayout(false);
            this.m_procPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.m_copyrightLabel.Location = new System.Drawing.Point(this.Width / 2 - System.Windows.Forms.TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Width / 2,
               m_procPanel.Height - System.Windows.Forms.TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Height - 10);


        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

