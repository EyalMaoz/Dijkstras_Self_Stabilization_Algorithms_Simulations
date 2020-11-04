using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra_third_algorithm
{
    public partial class MainForm : Form
    {
        private enum Algorithm
        {
            Third, First
        }
        #region Constants
        private const int buttonWidth = 70;
        private const int kMaxProc = 20;
        private const int kMinProc = 2;
        private readonly Color notPriviligedButtonColor = Color.LightYellow;
        private readonly Color priviligedButtonColor = Color.LightGreen;
        #endregion

        #region Members
        private int N = 0;
        private int K = 3;
        private List<Button> buttons;
        private List<Label> labels;
        private List<Label> leftArrows;
        private List<Label> rightArrows;
        private Dictionary<Button, int> states;
        private int numOfLeft = 0;
        private int numOfRight = 0;
        private bool autoScheulder = false;
        private Timer timerScheduler;
        private Algorithm algorithmType = Algorithm.First;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            m_copyrightLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Width / 2,
                m_procPanel.Height - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Height - 10);
            m_chosenLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText("Selected Processor: P0", m_chosenLabel.Font).Width / 2,
               20);
            buttons = new List<Button>();
            labels = new List<Label>();
            states = new Dictionary<Button, int>();
            leftArrows = new List<Label>();
            rightArrows = new List<Label>();
            timerScheduler = new Timer()
            {
                Interval = 2000
            };
            timerScheduler.Tick += TimerScheduler_Tick;
            //this.ForeColor = Color.WhiteSmoke;
            UpdatePriviliged();
        }
        #endregion

        #region Events
        private void S_Third_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    RightClickOnButton(sender as Button);
                    return;
                }
                Button button = sender as Button;
                if (button.BackColor == notPriviligedButtonColor) return;
                states[button] = ((states[button] + 1)) % K;
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void P0_Third_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    RightClickOnButton(sender as Button);
                    return;
                }
                Button button = sender as Button;
                if (button.BackColor == notPriviligedButtonColor) return;
                states[button] = ((states[button] - 1) + K) % K;
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void PN_1_Third_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    RightClickOnButton(sender as Button);
                    return;
                }
                Button button = sender as Button;
                if (button.BackColor == notPriviligedButtonColor) return;
                states[button] = (states[buttons[0]] + 1) % K;
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void PN_First_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    RightClickOnButton(sender as Button);
                    return;
                }
                Button button = sender as Button;
                if (button.BackColor == notPriviligedButtonColor) return;
                int i = Math.Max(0, buttons.IndexOf(button));

                states[button] = (states[buttons[i - 1]]);
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void P0_First_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    RightClickOnButton(sender as Button);
                    return;
                }
                Button button = sender as Button;
                if (button.BackColor == notPriviligedButtonColor) return;
                states[button] = (states[button] + 1) % K;
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                m_autoSchedularCheckbox.Checked = false;

                if (sender.Equals(m_ringRadio))
                    m_sringRadio.Checked = !m_ringRadio.Checked;
                if (sender.Equals(m_sringRadio))
                    m_ringRadio.Checked = !m_sringRadio.Checked;

                UpdateGUI();
                SetLocation();
            }
            catch (Exception) { }
        }

        private void DisplayArrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateArrows();
            UpdateGUI();
        }

        private void NumOfProcTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_autoSchedularCheckbox.Checked = false;
                int n_tmp = 0;
                if (string.IsNullOrEmpty(m_numOfProcTextBox.Text))
                {
                    N = 0;
                    GenerateProcessors();
                    return;
                }
                else if (!int.TryParse(m_numOfProcTextBox.Text, out n_tmp))
                {
                    m_numOfProcTextBox.TextChanged -= NumOfProcTextBox_TextChanged;
                    m_numOfProcTextBox.Text = N.ToString();
                    m_numOfProcTextBox.TextChanged += NumOfProcTextBox_TextChanged;
                    return;
                }
                if (n_tmp > 0 && n_tmp < kMinProc) n_tmp = kMinProc;
                if (n_tmp > kMaxProc) n_tmp = kMaxProc;
                N = n_tmp;

                GenerateProcessors();
            }
            catch (Exception) { }
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            try
            {
                SetLocation();
                m_copyrightLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Width / 2,
                    m_procPanel.Height - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Height - 10);
                m_chosenLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText(m_chosenLabel.Text, m_chosenLabel.Font).Width / 2,
                   20);
            }
            catch (Exception) { }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            try
            {
                var rand = new Random();

                foreach (Button b in buttons)
                {
                    states[b] = rand.Next(0, K);
                    b.Text = states[b].ToString();
                }
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void AllEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (states.Count == 0) return;
                var state = (states.First().Value + 1) % K;
                foreach (Button b in buttons)
                {
                    states[b] = state;
                    b.Text = states[b].ToString();
                }
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void OneArrowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (states.Count == 0) return;
                var state = (states.First().Value + 1) % K;
                var rand = new Random();

                int randomIndex = rand.Next(1, buttons.Count - 1);
                for (int i = 0; i < randomIndex; i++)
                {
                    Button b = buttons[i];
                    states[b] = state;
                    b.Text = states[b].ToString();
                }
                if (state % 2 == 0) state = (state + 1) % K;
                else state = (state - 1) % K;
                for (int i = randomIndex; i < buttons.Count; i++)
                {
                    Button b = buttons[i];
                    states[b] = state;
                    b.Text = states[b].ToString();
                }

                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void AutoSchedularCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                autoScheulder = m_autoSchedularCheckbox.Checked;
                m_autoSchedularCheckbox.BackColor = autoScheulder == true ? Color.Green : Color.Red;

                if (autoScheulder)
                {
                    float interval = 0;
                    if (!float.TryParse(m_secSchedulerTextBox.Text, out interval))
                    {
                        m_secSchedulerTextBox.Text = "2";
                        interval = 2;
                    }
                    timerScheduler.Interval = (int)(interval * 1000);
                    timerScheduler.Start();
                    m_secSchedulerTextBox.Enabled = false;
                }
                else
                {
                    m_chosenLabel.Text = string.Empty;
                    timerScheduler.Stop();
                    m_secSchedulerTextBox.Enabled = true;
                }
            }
            catch (Exception) { }
        }
        #endregion

        #region Private Methods
        private void GenerateProcessors()
        {
            try
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    m_procPanel.Controls.Remove(buttons[i]);
                    m_procPanel.Controls.Remove(labels[i]);
                    if (i < leftArrows.Count)
                    {
                        m_procPanel.Controls.Remove(leftArrows[i]);
                        m_procPanel.Controls.Remove(rightArrows[i]);
                    }
                }
                buttons.Clear();
                labels.Clear();
                states.Clear();
                rightArrows.Clear();
                leftArrows.Clear();
                if (N == 0) return;

                buttons = new List<Button>();

                for (int i = 0; i < N; i++)
                {
                    RoundButton button = new RoundButton()
                    {
                        TabStop = false,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font(this.Font.FontFamily, 14),
                        Size = new Size(buttonWidth, buttonWidth),
                        TabIndex = 2,
                        UseVisualStyleBackColor = true,
                        Text = "0",
                        BackColor = notPriviligedButtonColor
                    };
                    button.MouseMove += Button_MouseHover;
                    button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
                    button.FlatAppearance.BorderSize = 0;
                    Label nameLabel = new Label()
                    {
                        Text = "P" + i.ToString(),
                        AutoSize = true,
                        Font = new Font(this.Font.FontFamily, 14),
                    };
                    if (algorithmType == Algorithm.First)
                    {

                        if (i == 0)
                        {
                            button.MouseDown += P0_First_MouseClick;
                            toolTip1.SetToolTip(button, @"IF 𝑥(0)=𝑥(" + (N - 1) + ")" + "\n THEN 𝑥(0)≔𝑥(0)+1"
                                + "\n\nRight Click - Increase state.\nLeft Click - Make a move (if priviliged)");
                        }
                        else
                        {
                            button.MouseDown += PN_First_MouseClick;
                            //toolTip1.SetToolTip(button, @"IF 𝑥(𝑛−2)=𝑥(0) AND 𝑥(𝑛−1)≠𝑥(0)+1 THEN 𝑥(𝑛−1)≔𝑥(0)+1");
                            toolTip1.SetToolTip(button, @"IF 𝑥(" + i + ")!=𝑥(" + (i - 1) + ")"
                                + "\n THEN 𝑥(" + i + ")≔𝑥(" + (i - 1) + ")"
                                + "\n\nRight Click - Increase state.\nLeft Click - Make a move (if priviliged)");
                        }
                    }
                    else if (algorithmType == Algorithm.Third)
                    {
                        Label leftArrow = new Label()
                        {
                            Text = char.ConvertFromUtf32(0x21E6),
                            AutoSize = true,
                            Font = new Font(this.Font.FontFamily, 40, FontStyle.Bold),
                            Visible = false,

                        };
                        Label rightArrow = new Label()
                        {
                            Text = char.ConvertFromUtf32(0x21E8),
                            AutoSize = true,
                            Font = new Font(this.Font.FontFamily, 40, FontStyle.Bold),
                            Visible = false
                        };

                        if (i == 0)
                        {
                            button.MouseDown += P0_Third_MouseClick;
                            toolTip1.SetToolTip(button, @"IF 𝑥(0)+1=𝑥(1)" + "\n THEN 𝑥(0)≔𝑥(0)-1"
                                + "\n\nRight Click - Increase state.\nLeft Click - Make a move (if priviliged)");
                        }
                        else if (i == N - 1)
                        {
                            button.MouseDown += PN_1_Third_MouseClick;
                            //toolTip1.SetToolTip(button, @"IF 𝑥(𝑛−2)=𝑥(0) AND 𝑥(𝑛−1)≠𝑥(0)+1 THEN 𝑥(𝑛−1)≔𝑥(0)+1");
                            toolTip1.SetToolTip(button, @"IF 𝑥(" + (N - 2) + ")=𝑥(0) AND 𝑥(" + (N - 1)
                                + ")≠𝑥(0)+1\n THEN 𝑥(" + (N - 2) + ")≔𝑥(0)+1"
                                + "\n\nRight Click - Increase state.\nLeft Click - Make a move (if priviliged)");
                        }
                        else
                        {
                            button.MouseDown += S_Third_MouseClick;
                            //toolTip1.SetToolTip(button, @"IF 𝑥(𝑖)=𝑥(𝑖−1)−1 OR 𝑥(𝑖)=𝑥(𝑖+𝑖)−1 THEN 𝑥(𝑖)≔𝑥(𝑖)+1");
                            toolTip1.SetToolTip(button, @"IF 𝑥(" + i + ")=𝑥(" + (i - 1) + ")−1 OR 𝑥("
                                + i + ")=𝑥(" + (i + 1) + ")−1 \n THEN 𝑥(" + i + ")≔𝑥(" + i + ")+1"
                                + "\n\nRight Click - Increase state.\nLeft Click - Make a move (if priviliged)");
                        }
                        leftArrows.Add(leftArrow);
                        rightArrows.Add(rightArrow);
                        m_procPanel.Controls.Add(leftArrow);
                        m_procPanel.Controls.Add(rightArrow);
                    }
                    states.Add(button, 0);
                    buttons.Add(button);
                    labels.Add(nameLabel);
                    m_procPanel.Controls.Add(button);
                    m_procPanel.Controls.Add(nameLabel);
                }
                SetLocation();
                Random_Click(null, EventArgs.Empty);
            }
            catch (Exception) { }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == priviligedButtonColor)
            {
                ((Button)sender).Cursor = Cursors.Hand;
            }
            else
            {
                ((Button)sender).Cursor = Cursors.Default;
            }
        }

        private void UpdatePriviliged()// set who is priviliged
        {
            try
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (algorithmType == Algorithm.First)
                    {
                        if (i == 0)
                        {
                            buttons[0].BackColor = (states[buttons[0]] ==
                                states[buttons[buttons.Count - 1]]) ? priviligedButtonColor : notPriviligedButtonColor;
                        }
                        else
                        {
                            buttons[i].BackColor = (states[buttons[i]] != states[buttons[i - 1]]) ?
                                priviligedButtonColor : notPriviligedButtonColor;
                        }
                    }
                    else if (algorithmType == Algorithm.Third)
                    {
                        if (i == 0)
                        {
                            buttons[0].BackColor = ((states[buttons[0]] + 1) % K ==
                                states[buttons[1]]) ? priviligedButtonColor : notPriviligedButtonColor;
                        }
                        else if (i == buttons.Count - 1)
                        {
                            buttons[i].BackColor = (states[buttons[i - 1]] == states[buttons[0]]) &&
                                (states[buttons[i]] != (states[buttons[0]] + 1) % K) ? priviligedButtonColor : notPriviligedButtonColor;
                        }
                        else
                        {
                            buttons[i].BackColor = ((states[buttons[i]] + 1) % K == states[buttons[i - 1]]) ||
                                ((states[buttons[i]] + 1) % K == states[buttons[i + 1]]) ? priviligedButtonColor : notPriviligedButtonColor;
                        }
                    }
                }
                if (m_sringRadio.Checked && algorithmType == Algorithm.Third) UpdateArrows();
            }
            catch (Exception) { }
        }

        private void SetLocation()
        {
            try
            {
                float angle = (float)(2 * Math.PI) / N;
                float radius = Math.Min(m_procPanel.Width / 4, m_procPanel.Height / 4);
                for (int i = 0; i < N; i++)
                {
                    int x;
                    int y;
                    if (m_ringRadio.Checked)
                    {
                        x = m_procPanel.Width / 2 + (int)(radius * Math.Cos(angle * i - Math.PI / 2)) - buttonWidth / 2;
                        y = m_procPanel.Height / 2 + (int)(radius * Math.Sin(angle * i - Math.PI / 2)) + buttonWidth / 3;
                        if (algorithmType == Algorithm.Third)
                        {
                            rightArrows[i].Visible = false;
                            leftArrows[i].Visible = false;
                            m_deltaYLabel.Visible = false;
                        }
                    }
                    else// as a string -only third algorithm
                    {
                        m_deltaYLabel.Visible = m_displayArrowCheckBox.Checked;
                        x = ((m_procPanel.Width - 40) / N) * i;
                        y = m_procPanel.Height / 2;
                        // add arrows
                        if (algorithmType == Algorithm.Third)
                        {
                            if (i != N - 1)
                            {
                                rightArrows[i].Visible = m_displayArrowCheckBox.Checked;
                                leftArrows[i].Visible = m_displayArrowCheckBox.Checked;
                                rightArrows[i].Location = new Point(x + buttonWidth, y + buttonWidth);
                                leftArrows[i].Location = new Point(x + buttonWidth, y + buttonWidth);
                            }
                        }
                    }
                    buttons[i].Location = new Point(x, y);
                    labels[i].Location = new System.Drawing.Point(x + buttonWidth / 2, y - buttonWidth / 2);
                }
            }
            catch (Exception) { }
        }

        private void UpdateArrows()
        {
            try
            {
                int oldY = (numOfLeft + 2 * numOfRight);
                numOfLeft = 0;
                numOfRight = 0;
                for (int i = 0; i < N - 1; i++)
                {
                    leftArrows[i].Visible = false;
                    rightArrows[i].Visible = false;
                    if (m_displayArrowCheckBox.Checked)
                    {
                        if ((states[buttons[i]] + 1) % K == states[buttons[i + 1]])
                        {
                            leftArrows[i].Visible = true;
                            numOfLeft++;
                        }
                        else if (states[buttons[i]] == (states[buttons[i + 1]] + 1) % K)
                        {
                            rightArrows[i].Visible = true;
                            numOfRight++;
                        }
                    }
                }
                m_deltaYLabel.Text = "Y = " + (numOfLeft + 2 * numOfRight) + ", ΔY = " + ((numOfLeft + 2 * numOfRight) - oldY);// Maybe add Δy also
            }
            catch (Exception) { }
        }

        private void UpdateGUI()
        {
            try
            {
                if (algorithmType == Algorithm.First)
                {
                    m_displayArrowCheckBox.Checked = false;
                    m_sringRadio.Checked = false;
                    m_ringRadio.Checked = true;
                }
                m_viewAsPanel.Visible = algorithmType == Algorithm.Third;
                m_displayArrowCheckBox.Visible = m_sringRadio.Checked && algorithmType == Algorithm.Third;
                m_deltaYLabel.Visible = m_displayArrowCheckBox.Checked && algorithmType == Algorithm.Third;
                m_noArrowsButton.Visible = m_displayArrowCheckBox.Checked && m_sringRadio.Checked && algorithmType == Algorithm.Third;
                m_oneArrowButton.Visible = m_displayArrowCheckBox.Checked && m_sringRadio.Checked && algorithmType == Algorithm.Third;
            }
            catch (Exception) { }
        }

        private void RightClickOnButton(Button button)
        {
            try
            {
                states[button] = (states[button] + 1) % K;
                button.Text = states[button].ToString();
                UpdatePriviliged();
            }
            catch (Exception) { }
        }

        private void TimerScheduler_Tick(object sender, EventArgs e)
        {
            try
            {
                if (N == 0) return;
                var rand = new Random();
                bool finished = false;
                while (!finished)
                {
                    int chosenIndex = rand.Next(0, buttons.Count);
                    if (buttons[chosenIndex].BackColor == priviligedButtonColor)
                    {
                        m_chosenLabel.Text = "Selected Processor: P" + chosenIndex;
                        MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);

                        if (algorithmType == Algorithm.First)
                        {
                            if (chosenIndex == 0)
                            {
                                P0_First_MouseClick(buttons[chosenIndex], args);
                            }

                            else
                            {
                                PN_First_MouseClick(buttons[chosenIndex], args);
                            }
                        }
                        else if (algorithmType == Algorithm.Third)
                        {
                            if (chosenIndex == 0)
                            {
                                P0_Third_MouseClick(buttons[chosenIndex], args);
                            }
                            else if (chosenIndex == buttons.Count - 1)
                            {
                                PN_1_Third_MouseClick(buttons[chosenIndex], args);
                            }
                            else
                            {
                                S_Third_MouseClick(buttons[chosenIndex], args);
                            }
                        }

                        finished = true;
                    }
                }
            }
            catch (Exception) { }
        }
        #endregion

        private void toggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (toggleSwitch1.Checked)
                {
                    algorithmType = Algorithm.Third;
                    K = 3;
                    m_kTextBox.Text = K.ToString();
                    m_kTextBox.Enabled = false;
                }
                else
                {
                    algorithmType = Algorithm.First;
                    m_kTextBox.Enabled = true;
                }
                m_autoSchedularCheckbox.Checked = false;
                m_numOfProcTextBox.Text = "0";
                UpdateGUI();
            }
            catch (Exception) { }
        }

        private void m_kTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_autoSchedularCheckbox.Checked = false;
                int k_tmp = 3;
                if (string.IsNullOrEmpty(m_kTextBox.Text))
                {
                    K = 3;
                    return;
                }
                else if (!int.TryParse(m_kTextBox.Text, out k_tmp) || k_tmp <= 0)
                {
                    m_kTextBox.TextChanged -= m_kTextBox_TextChanged;
                    m_kTextBox.Text = K.ToString();
                    m_kTextBox.TextChanged += m_kTextBox_TextChanged;
                    return;
                }
                if (k_tmp <= 0)
                {
                    k_tmp = 3;

                }
                K = k_tmp;
                GenerateProcessors();
            }
            catch (Exception) { }
        }
    }
}
