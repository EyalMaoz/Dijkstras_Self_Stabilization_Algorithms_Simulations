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
        #region Constants
        private const int k = 3;
        private const int buttonWidth = 70;
        private readonly Color notPriviligedButtonColor = Color.LightYellow;
        private readonly Color priviligedButtonColor = Color.LightGreen;
        #endregion
        
        #region Members
        private int N = 0;
        private List<Button> buttons;
        private List<Label> labels;
        private List<Label> leftArrows;
        private List<Label> rightArrows;
        private Dictionary<Button, int> states;
        private int numOfLeft = 0;
        private int numOfRight = 0;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            m_copyrightLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Width / 2,
                m_procPanel.Height - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Height - 10);
            buttons = new List<Button>();
            labels = new List<Label>();
            states = new Dictionary<Button, int>();
            leftArrows = new List<Label>();
            rightArrows = new List<Label>();
            this.ForeColor = Color.WhiteSmoke;
            UpdatePriviliged();
        }
        #endregion

        #region Events
        private void S_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickOnButton(sender as Button);
                return;
            }
            Button button = sender as Button;
            if (button.BackColor == notPriviligedButtonColor) return;
            states[button] = ((states[button] + 1)) % k;
            button.Text = states[button].ToString();
            UpdatePriviliged();
        }

        private void P0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickOnButton(sender as Button);
                return;
            }
            Button button = sender as Button;
            if (button.BackColor == notPriviligedButtonColor) return;
            states[button] = ((states[button] - 1) + k) % k;
            button.Text = states[button].ToString();
            UpdatePriviliged();
        }

        private void PN_1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClickOnButton(sender as Button);
                return;
            }
            Button button = sender as Button;
            if (button.BackColor == notPriviligedButtonColor) return;
            states[button] = (states[buttons[0]] + 1) % k;
            button.Text = states[button].ToString();
            UpdatePriviliged();
        }

        private void RightClickOnButton(Button button)
        {
            states[button] = (states[button] + 1) % k;
            button.Text = states[button].ToString();
            UpdatePriviliged();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(m_ringRadio))
                m_sringRadio.Checked = !m_ringRadio.Checked;
            if (sender.Equals(m_sringRadio))
                m_ringRadio.Checked = !m_sringRadio.Checked;

            UpdateGUI();
            SetLocation();
        }

        private void DisplayArrowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateArrows();
            UpdateGUI();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int n_tmp = 0;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                N = 0;
                GenerateProcessors();
                return;
            }
            else if (!int.TryParse(textBox1.Text, out n_tmp))
            {
                textBox1.TextChanged -= TextBox1_TextChanged;
                textBox1.Text = N.ToString();
                textBox1.TextChanged += TextBox1_TextChanged;
                return;
            }
            if (n_tmp > 0 && n_tmp < 2) n_tmp = 2;
            N = n_tmp;
            textBox1.TextChanged -= TextBox1_TextChanged;
            textBox1.Text = N.ToString();
            textBox1.TextChanged += TextBox1_TextChanged;
            GenerateProcessors();
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            SetLocation();
            m_copyrightLabel.Location = new Point(this.Width / 2 - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Width / 2,
                m_procPanel.Height - TextRenderer.MeasureText(m_copyrightLabel.Text, m_copyrightLabel.Font).Height-10);
        }

        private void Random_Click(object sender, EventArgs e)
        {
            var rand = new Random();

            foreach (Button b in buttons)
            {
                states[b] = rand.Next(0, 3);
                b.Text = states[b].ToString();
            }
            UpdatePriviliged();
        }

        private void AllEqual_Click(object sender, EventArgs e)
        {
            if (states.Count == 0) return;
            var state = (states.First().Value + 1) % k;
            foreach (Button b in buttons)
            {
                states[b] = state;
                b.Text = states[b].ToString();
            }
            UpdatePriviliged();
        }
        #endregion

        #region Private Methods
        private void GenerateProcessors()
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
                button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
                button.FlatAppearance.BorderSize = 0;
                Label nameLabel = new Label()
                {
                    Text = "P" + i.ToString(),
                    AutoSize = true,
                    Font = new Font(this.Font.FontFamily, 14),
                };

                if (i == 0)
                {
                    button.MouseDown += P0_MouseClick;
                }
                else if (i == N - 1)
                {
                    button.MouseDown += PN_1_MouseClick;

                }
                else
                {
                    button.MouseDown += S_MouseClick;
                }

                m_procPanel.Controls.Add(button);
                m_procPanel.Controls.Add(nameLabel);
                m_procPanel.Controls.Add(leftArrow);
                m_procPanel.Controls.Add(rightArrow);
                leftArrows.Add(leftArrow);
                rightArrows.Add(rightArrow);
                states.Add(button, 0);
                buttons.Add(button);
                labels.Add(nameLabel);
            }
            SetLocation();
            Random_Click(null, EventArgs.Empty);
        }

        private void UpdatePriviliged()// set who is priviliged
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == 0)
                {

                    buttons[0].BackColor = ((states[buttons[0]] + 1) % k ==
                        states[buttons[1]]) ? priviligedButtonColor : notPriviligedButtonColor;
                }
                else if (i == buttons.Count - 1)
                {
                    buttons[i].BackColor = (states[buttons[i - 1]] == states[buttons[0]]) &&
                        (states[buttons[i]] != (states[buttons[0]] + 1) % k) ? priviligedButtonColor : notPriviligedButtonColor;
                }
                else
                {
                    buttons[i].BackColor = ((states[buttons[i]] + 1) % k == states[buttons[i - 1]]) ||
                        ((states[buttons[i]] + 1) % k == states[buttons[i + 1]]) ? priviligedButtonColor : notPriviligedButtonColor;
                }
            }
            if (m_sringRadio.Checked) UpdateArrows();
        }

        private void SetLocation()
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
                    rightArrows[i].Visible = false;
                    leftArrows[i].Visible = false;
                    m_deltaYLabel.Visible = false;
                }
                else// as a string
                {
                    m_deltaYLabel.Visible = m_displayArrowCheckBox.Checked;
                    x = ((m_procPanel.Width - 40) / N) * i;
                    y = m_procPanel.Height / 2;
                    // add arrows
                    if (i != N - 1)
                    {
                        rightArrows[i].Visible = m_displayArrowCheckBox.Checked;
                        leftArrows[i].Visible = m_displayArrowCheckBox.Checked;
                        rightArrows[i].Location = new Point(x + buttonWidth, y + buttonWidth);
                        leftArrows[i].Location = new Point(x + buttonWidth, y + buttonWidth);
                    }
                }
                buttons[i].Location = new Point(x, y);
                labels[i].Location = new System.Drawing.Point(x + buttonWidth / 2, y - buttonWidth / 2);
            }
        }

        private void UpdateArrows()
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
                    if ((states[buttons[i]] + 1) % k == states[buttons[i + 1]])
                    {
                        leftArrows[i].Visible = true;
                        numOfLeft++;
                    }
                    else if (states[buttons[i]] == (states[buttons[i + 1]] + 1) % k)
                    {
                        rightArrows[i].Visible = true;
                        numOfRight++;
                    }
                }
            }
            m_deltaYLabel.Text = "Y = " + (numOfLeft + 2 * numOfRight) + ", ΔY = " + ((numOfLeft + 2 * numOfRight) - oldY);// Maybe add Δy also
        }

        private void UpdateGUI()
        {
            m_displayArrowCheckBox.Visible = m_sringRadio.Checked;
            m_deltaYLabel.Visible = m_displayArrowCheckBox.Checked;
            m_noArrowsButton.Visible = m_displayArrowCheckBox.Checked && m_sringRadio.Checked;
        }
        #endregion

    }
}
