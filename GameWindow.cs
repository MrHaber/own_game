using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GameWindow : Form
    {
        public static int counter = 0;
        public static CountDownTimer timer = new CountDownTimer();

        public static float t_size = 27;
        public GameWindow()
        {
            InitializeComponent();
            //this.TopMost = true;
            int time = SettingsWindow.gameTimer;

            team_1.Visible = false;
            team_2.Visible = false;
            team_3.Visible = false;
            team_4.Visible = false;
            team_5.Visible = false;
            p_1.Visible = false;
            p_2.Visible = false;
            p_3.Visible = false;
            p_4.Visible = false;
            p_5.Visible = false;
            //set to 30 mins
            timer.SetTime(time, 0);

            timer.Start();

            //update label text
            timer.TimeChanged += () => time_lbl.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () =>
            {
                timer.Stop();

                SettingsWindow.teams[0].Points = Int32.Parse(p_1.Text.Replace("Счёт: ", ""));
                SettingsWindow.teams[1].Points = Int32.Parse(p_2.Text.Replace("Счёт: ", ""));
                SettingsWindow.teams[2].Points = Int32.Parse(p_3.Text.Replace("Счёт: ", ""));
                SettingsWindow.teams[3].Points = Int32.Parse(p_4.Text.Replace("Счёт: ", ""));
                SettingsWindow.teams[4].Points = Int32.Parse(p_5.Text.Replace("Счёт: ", ""));

                new WinWindow().Show();

                this.Close();
                
            };
        }
        public void updateCheck()
        {
        }
        private void button_1_Click(object sender, EventArgs eventArgs)
        {
            
            
            string[] coors = ((Guna2Button)sender).Name.Split('_');
            if (coors[0] == "g")
            {
                int y = int.Parse(coors[1])-1;
                int x = Int32.Parse(coors[2])-1;

                JsonDeserialize json = list[y];

                Question qq = json.QuestionElement[x];

                ((Guna2Button)sender).Hide();
                new QuestionAnswerWindow(qq,this).Show();

                counter += 1;

            }
        }
        public static List<Guna2HtmlLabel> themes = new List<Guna2HtmlLabel>();

        public static Dictionary<int, int> teams = new Dictionary<int, int>()
        {
            {1,0},
            {2,0},
            {3,0},
            {4,0},
            {5,0}
        };

        public static int selected_team = 1;

        public static List<ToolStripStatusLabel> scores = new List<ToolStripStatusLabel>();

        public static List<JsonDeserialize> list = JsonDeserialize.build(SettingsWindow.fileDestination);
        public void updateScore()
        {
            if (GameWindow.selected_team > SettingsWindow.commandsCount)
            {
                GameWindow.selected_team = 1;
            }
            switch (selected_team)
            {
                case 1:
                    updateNames();
                    team_1.Text += " [ходит]";
                    break;
                case 2:
                    updateNames();
                    team_2.Text += " [ходит]";
                    break;
                case 3:
                    updateNames();
                    team_3.Text += " [ходит]";
                    break;
                case 4:
                    updateNames();
                    team_4.Text += " [ходит]";
                    break;
                case 5:
                    updateNames();
                    team_5.Text += " [ходит]";
                    break;

            }
            p_1.Text = "Счёт: " + teams[1].ToString();
            p_2.Text = "Счёт: " + teams[2].ToString();
            p_3.Text = "Счёт: " + teams[3].ToString();
            p_4.Text = "Счёт: " + teams[4].ToString();
            p_5.Text = "Счёт: " + teams[5].ToString();
            SettingsWindow.teams[0].Points = Int32.Parse(teams[1].ToString());
            SettingsWindow.teams[1].Points = Int32.Parse(teams[2].ToString());
            SettingsWindow.teams[2].Points = Int32.Parse(teams[3].ToString());
            SettingsWindow.teams[3].Points = Int32.Parse(teams[4].ToString());
            SettingsWindow.teams[4].Points = Int32.Parse(teams[5].ToString());
        }

        public void updateNames()
        {
            team_1.Text = SettingsWindow.teams[0].Name;
            team_2.Text = SettingsWindow.teams[1].Name;
            team_3.Text = SettingsWindow.teams[2].Name;
            team_4.Text = SettingsWindow.teams[3].Name;
            team_5.Text = SettingsWindow.teams[4].Name;
            //MessageBox.Show((String.Equals(SettingsWindow.teams[2].Name, "Пусто -")).ToString());
            //MessageBox.Show(SettingsWindow.teams[2].Name);
            //MessageBox.Show(SettingsWindow.savedElements.ToString());
            switch (SettingsWindow.savedElements)
            {
                case 1:
                    team_1.Visible = true;
                    p_1.Visible = true;
                    break;
                case 2:
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    break;
                case 3:
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    team_3.Visible = true;
                    p_3.Visible = true;
                    break;
                case 4:
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    team_3.Visible = true;
                    p_3.Visible = true;
                    team_4.Visible = true;
                    p_4.Visible = true;
                    break;
                case 5:
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    team_3.Visible = true;
                    p_3.Visible = true;
                    team_4.Visible = true;
                    p_4.Visible = true;
                    team_5.Visible = true;
                    p_5.Visible = true;
                    break;


            }
        }
        private static bool loadedFirst = true;
        private void GameWindow_Load(object sender, EventArgs e)
        {
         updateNames();
            themes.Add(theme_1); themes.Add(theme_2); themes.Add(theme_3);
            themes.Add(theme_4); themes.Add(theme_5);
            theme_1.Text = list[0].NameOfTheme;
            theme_2.Text = list[1].NameOfTheme;
            theme_3.Text = list[2].NameOfTheme;
            theme_4.Text = list[3].NameOfTheme;
            theme_5.Text = list[4].NameOfTheme;


            scores.Add(p_1); scores.Add(p_2); scores.Add(p_3); scores.Add(p_4); scores.Add(p_5);

            updateScore();

            theme_1.MaximumSize = panel1.Size;
            theme_2.MaximumSize = panel2.Size;
            theme_3.MaximumSize = panel3.Size;
            theme_4.MaximumSize = panel4.Size;
            if (loadedFirst) {
                resize_lbl(theme_1, 20);
                resize_lbl(theme_2, 20);
                resize_lbl(theme_3, 20);
                resize_lbl(theme_4, 20);
                resize_lbl(theme_5, 20);
                loadedFirst = false;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                e.Cancel = true;
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите, закрыть и перейти к результатам игры?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    timer.Stop();

                    SettingsWindow.teams[0].Points = Int32.Parse(p_1.Text.Replace("Счёт: ", ""));
                    SettingsWindow.teams[1].Points = Int32.Parse(p_2.Text.Replace("Счёт: ", ""));
                    SettingsWindow.teams[2].Points = Int32.Parse(p_3.Text.Replace("Счёт: ", ""));
                    SettingsWindow.teams[3].Points = Int32.Parse(p_4.Text.Replace("Счёт: ", ""));
                    SettingsWindow.teams[4].Points = Int32.Parse(p_5.Text.Replace("Счёт: ", ""));


                    new WinWindow().Show();
                    Dispose();

                    this.Close();
                }
            }


        }

        private void GameWindow_Resize(object sender, EventArgs e)
        {
            theme_1.MaximumSize = panel1.Size;
            theme_2.MaximumSize = panel2.Size;
            theme_3.MaximumSize = panel3.Size;
            theme_4.MaximumSize = panel4.Size;
            resize_lbl(theme_1, 8);
            resize_lbl(theme_2, 8);
            resize_lbl(theme_3, 8);
            resize_lbl(theme_4, 8);
            resize_lbl(theme_5, 8);
        }

        /*        private void theme_1_Click(object sender, EventArgs e)
                {
                    float units = ((Guna2HtmlLabel)sender).Text.Length/5;
                    Font fonts = ((Guna2HtmlLabel)sender).Font;
                    float size = fonts.Size - units;
                    ((Guna2HtmlLabel)sender).Font = new Font(fonts.FontFamily, size);

                    ((Guna2HtmlLabel)sender).Text = ((Guna2HtmlLabel)sender).Text.Replace("\n", "");
                }*/

        private void resize_lbl(Guna2HtmlLabel lbl, float coof)
        {
            /*            if (lbl.Text.Length > 40)
                        {
                            coof /= lbl.Text.Length / 15;
                        }*/
            float units = lbl.Text.Length / coof;
            Font fonts = lbl.Font;
            if (t_size < fonts.Size - units)
            {
                t_size = fonts.Size - units;
            }
            lbl.Font = new Font(fonts.FontFamily, Math.Abs(t_size), FontStyle.Bold);

            lbl.Text = lbl.Text.Replace("\n", "");
        }

        private void EditCommand_lbl_StatusBar_Click(object sender, EventArgs e)
        {

        }

        private void PlayerAddLbl_Click(object sender, EventArgs e)
        {
            timer.Pause();
            new PlayerAddWindow().Show();
            this.Hide();
        }
        /*        public Font GetFont(string str, Graphics g, Font element, int imgWidth, int imgHeight)
                {
                    int _maxFontSize = 27;
                    int _minFontSize = 7;
                    // Measure with maximum sized font
                    var baseSize = g.MeasureString(str, _fontCache[_maxFontSize]);

                    // Downsample to actual image size
                    float widthRatio = imgWidth / baseSize.Width;
                    float heightRatio = imgHeight / baseSize.Height;
                    float minRatio = Math.Min(widthRatio, heightRatio);
                    int estimatedFontSize = (int)(_maxFontSize * minRatio);

                    // Make sure the precomputed font list is always hit
                    if (estimatedFontSize > _maxFontSize)
                        estimatedFontSize = _maxFontSize;
                    else if (estimatedFontSize < _minFontSize)
                        estimatedFontSize = _minFontSize;

                    // Make sure the estimated size is not too large
                    var estimatedSize = g.MeasureString(str, _fontCache[estimatedFontSize]);
                    bool estimatedSizeWasReduced = false;
                    while (estimatedSize.Width > imgWidth || estimatedSize.Height > imgHeight)
                    {
                        if (estimatedFontSize == _minFontSize)
                            break;
                        --estimatedFontSize;
                        estimatedSizeWasReduced = true;

                        estimatedSize = g.MeasureString(str, _fontCache[estimatedFontSize]);
                        ++counter;
                    }

                    // Can we increase the size a bit?
                    if (!estimatedSizeWasReduced)
                    {
                        while (estimatedSize.Width < imgWidth && estimatedSize.Height < imgHeight)
                        {
                            if (estimatedFontSize == _maxFontSize)
                                break;
                            ++estimatedFontSize;

                            estimatedSize = g.MeasureString(str, _fontCache[estimatedFontSize]);
                        }

                        // We increase the size until it is larger than the image, so we need to go back one step afterwards
                        if (estimatedFontSize > _minFontSize)
                            --estimatedFontSize;
                    }

                    return _fontCache[estimatedFontSize];
                }*/
    }
}
