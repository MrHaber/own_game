using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuestionAnswerWindow : Form
    {
        public static float t_size = 27;
        public static CountDownTimer timer = new CountDownTimer();
        private Question qe;
        private GameWindow wd;
        public static bool isStarted = false;
        public QuestionAnswerWindow(Question qe,GameWindow wd)
        {
            InitializeComponent();

            guna2Button1.Enabled = false;
            //this.TopMost = true;

            this.qe = qe;
            this.wd = wd;

            this.theme.Text = this.qe.Theme;

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

            this.quest.Text = this.qe.Quest;

            this.ans_1.Text = this.qe.Ans[0];

            this.ans_2.Text = this.qe.Ans[1];

            this.ans_3.Text = this.qe.Ans[2];



            updateScore();

            wd.updateScore();

            List<int> times = SettingsWindow.questionTimers;

            int time = 1;

            int team = GameWindow.selected_team;

            if (team > SettingsWindow.commandsCount)
            {
                GameWindow.selected_team = 1;
            }
            team = GameWindow.selected_team;
            int result_of_team = GameWindow.teams[team];

            switch (qe.Cost)
            {
                case 100:
                    time = times[0];
                    break;
                case 200:
                    time = times[1];
                    break;
                case 300:
                    time = times[2];
                    break;
                case 400:
                    time = times[3];
                    break;
                case 500:
                    time = times[4];
                    break;
                default:
                    time = 1;
                    break;
            }
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
                    isStarted = true;
            //MessageBox.Show(time.ToString());
            //set to 30 mins
            timer.SetTime(time, 0);

            timer.Start();
            //update label text
            timer.TimeChanged += () => t_time.Text = timer.TimeLeftMsStr;

            // show messageBox on timer = 00:00.000
            timer.CountDownFinished += () =>
            {
                
                timer.Stop();
/*                GameWindow.teams[team] = result_of_team - qe.Cost;
                GameWindow.selected_team = team + 1;
                wd.updateScore();*/
                Close();
                check();
            };
        }
        private static bool loadedFirst = true;
        private void QuestionAnswerWindow_Load(object sender, EventArgs e)
        {
            theme.MaximumSize = panel2.Size;
            quest.MaximumSize = panel1.Size;
            ans_1.MaximumSize = panel3.Size;
            ans_2.MaximumSize = panel4.Size;
            ans_3.MaximumSize = panel5.Size;
            if (loadedFirst)
            {
                resize_lbl(theme, 20);
                resize_lbl(quest, 20);
                resize_lbl(ans_1, 20);
                resize_lbl(ans_2, 20);
                resize_lbl(ans_3, 20);
                loadedFirst = false;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int team = GameWindow.selected_team;

            if (team > SettingsWindow.commandsCount)
            {
                GameWindow.selected_team = 1;
            }
            team = GameWindow.selected_team;
            int result_of_team = GameWindow.teams[team];
            int tr = this.qe.Pos;
            if (this.a_1.Checked && tr == 1)
            {
                
                GameWindow.teams[team] = result_of_team + qe.Cost;
                conguations(team,qe.Cost);
                //this.theme.Text = "a" + qe.Cost;

            }
            else if (this.a_2.Checked && tr == 2)
            {
                GameWindow.teams[team] = result_of_team + qe.Cost;
                conguations(team, qe.Cost);
                //this.theme.Text = "b" + qe.Cost;
            }
            else if (this.a_3.Checked && tr == 3)
            {
                GameWindow.teams[team] = result_of_team + qe.Cost;
                conguations(team, qe.Cost);
                //this.theme.Text = "c" + qe.Cost;
            }
            else
            {
                //MessageBox.Show("Команда: " + name + " дала неправильный ответ, и потеряла -"+cost);
                loss(team,qe.Cost);
                GameWindow.teams[team] = result_of_team - qe.Cost;
                //this.theme.Text = "d " + (a_2.Checked && tr == 2) + " " + (tr==2);
            }
            
            timer.Stop();
            isStarted = false;
            GameWindow.selected_team = team+1;

            wd.updateScore();



            check();

            this.Close();
            
        }
        private void conguations(int select,int cost)
        {
           string name = SettingsWindow.teams[select - 1].Name;
           timer.Stop();
           MessageBox.Show("Команда: " + name + " дала правильный ответ, и получила " + cost + " очков");
        }

        private void loss(int select, int cost)
        {
            string name = SettingsWindow.teams[select - 1].Name;
            timer.Stop();
            MessageBox.Show("Команда: " + name + " дала неправильный ответ, и потеряла " + cost + " очков");
        }

        private void QuestionAnswerWindow_Load_1(object sender, EventArgs e)
        {

        }
        public static void resize_lbl(Guna2HtmlLabel lbl, float coof)
        {
            //if (lbl.Text.Length < 30)
            //{
            //    return;
            //}
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
        public void check()
        {
            if (GameWindow.counter >= 25)
            {
                wd.Hide();
                new WinWindow().Show();
                
            }
        }
        public void updateScore()
        {
            if (GameWindow.selected_team > SettingsWindow.commandsCount)
            {
                GameWindow.selected_team = 1;
            }
            switch (GameWindow.selected_team)
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
            p_1.Text = GameWindow.teams[1].ToString();
            p_2.Text = GameWindow.teams[2].ToString();
            p_3.Text = GameWindow.teams[3].ToString();
            p_4.Text = GameWindow.teams[4].ToString();
            p_5.Text = GameWindow.teams[5].ToString();
        }

        public void updateNames()
        {
            team_1.Text = SettingsWindow.teams[0].Name;
            team_2.Text = SettingsWindow.teams[1].Name;
            team_3.Text = SettingsWindow.teams[2].Name;
            team_4.Text = SettingsWindow.teams[3].Name;
            team_5.Text = SettingsWindow.teams[4].Name;
        }

        private void t_time_Click(object sender, EventArgs e)
        {

        }

        private void QuestionAnswerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isStarted)
            {
                timer.Stop();

                int team = GameWindow.selected_team;

                int result_of_team = GameWindow.teams[team];

                GameWindow.teams[team] = result_of_team - qe.Cost;

                isStarted = false;

                GameWindow.selected_team = team + 1;

                updateScore();

                wd.updateScore();

                check();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void a_1_CheckedChanged(object sender, EventArgs e)
        {
            guna2Button1.Enabled = true;
        }

        private void StatusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void QuestionAnswerWindow_SizeChanged(object sender, EventArgs e)
        {
            //resize_lbl(theme, 15);

            //resize_lbl(quest, 15);

            //resize_lbl(ans_1, 5);

            //resize_lbl(ans_2, 5);

            //resize_lbl(ans_3, 5);
        }

        private void ans_1_Resize(object sender, EventArgs e)
        {

        }

        private void QuestionAnswerWindow_Resize(object sender, EventArgs e)
        {
            theme.MaximumSize = panel2.Size;
            quest.MaximumSize = panel1.Size;
            ans_1.MaximumSize = panel3.Size;
            ans_2.MaximumSize = panel4.Size;
            ans_3.MaximumSize = panel5.Size;

            resize_lbl(theme, 15);
            resize_lbl(quest, 15);
            resize_lbl(ans_1, 5);
            resize_lbl(ans_2, 5);
            resize_lbl(ans_3, 5);
        }

        private void quest_Click(object sender, EventArgs e)
        {

        }
    }
}
