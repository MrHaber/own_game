using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class SettingsWindow : Form
    {
        public static int gameTimer = 30;
        public static int commandsCount = 2;
        public static int savedElements = 0;

        public static string fileDestination = "Resources\\game.json";

        private List<Pair<Guna2TextBox, Guna2TextBox>> textboxElements = new List<Pair<Guna2TextBox, Guna2TextBox>>();

        public static List<int> questionTimers = new List<int>() { 1, 1, 1, 1, 1 };

        public static List<Team> teams = new List<Team>()
        {
            new Team("", "", 0),
            new Team("", "", 0),
            new Team("", "", 0),
            new Team("", "", 0),
            new Team("", "", 0)
        };

        public SettingsWindow()
        {
            InitializeComponent();

            textboxElements.Add(new Pair<Guna2TextBox, Guna2TextBox>(guna2TextBox1Name, guna2TextBox1Players));
            textboxElements.Add(new Pair<Guna2TextBox, Guna2TextBox>(guna2TextBox2Name, guna2TextBox2Players));
            textboxElements.Add(new Pair<Guna2TextBox, Guna2TextBox>(guna2TextBox3Name, guna2TextBox3Players));
            textboxElements.Add(new Pair<Guna2TextBox, Guna2TextBox>(guna2TextBox4Name, guna2TextBox4Players));
            textboxElements.Add(new Pair<Guna2TextBox, Guna2TextBox>(guna2TextBox5Name, guna2TextBox5Players));

            updateEnabledCommandsTextbox();
        }

        private void time_radio_button_30_CheckedChanged(object sender, EventArgs e)
        {
            gameTimer = 30;
        }

        private void time_radio_button_45_CheckedChanged(object sender, EventArgs e)
        {
            gameTimer = 45;
        }

        public void updateEnabledCommandsTextbox()
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (i < commandsCount)
                {
                    textboxElements[i].First.Enabled = true;
                    textboxElements[i].Second.Enabled = true;
                }
                else
                {
                    textboxElements[i].First.Enabled = false;
                    textboxElements[i].Second.Enabled = false;
                }
            }
        }

        private void guna2NumericUpDownCommandCount_ValueChanged(object sender, EventArgs e)
        {
            commandsCount = (int)guna2NumericUpDownCommandCount.Value;
            updateEnabledCommandsTextbox();
        }

        private void guna2TrackBar1_Scroll(object sender, EventArgs e)
        {
            questionTimers[0] = trackBar1.Value;
        }

        private void guna2TrackBar2_Scroll(object sender, EventArgs e)
        {
            questionTimers[1] = trackBar2.Value;
        }

        private void guna2TrackBar3_Scroll(object sender, EventArgs e)
        {
            questionTimers[2] = trackBar3.Value;
        }

        private void guna2TrackBar4_Scroll(object sender, EventArgs e)
        {
            questionTimers[3] = trackBar4.Value;
        }

        private void guna2TrackBar5_Scroll(object sender, EventArgs e)
        {
            questionTimers[4] = trackBar5.Value;
        }

        private void guna2ButtonLoadDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileDestination = openFileDialog.FileName;
                st.Text = Path.GetFileName(fileDestination);
                guna2ButtonStartGame.Enabled = true;
            }
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult.No == MessageBox.Show("Вы хотите закрыть программу, вы уверены?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel=true;

            }
            else
            { 
                Dispose();
                System.Windows.Forms.Application.Exit();
            }
        }


        public void getCommandsInfo()
        {
            for (int i = 0; i < commandsCount; i++)
            {
                teams[i].Name = textboxElements[i].First.Text;

                string[] temp1 = textboxElements[i].Second.Text.Split(new char[] { '\r', '\n' });
                List<string> temp2 = new List<string>();
                for (int j = 0; j < temp1.Length; j++)
                    if (temp1[j] != "")
                    {
                        temp2.Add(Regex.Replace(temp1[j], @" ?\(.*?\)", string.Empty));
                    }
                teams[i].UnitsList = temp2.ToArray();
                teams[i].Units = string.Join(", ", teams[i].UnitsList);
            }
        }

        public bool checkRepeatNames()
        {
            for (int i = 0; i < commandsCount - 1; i++)
            {
                for (int j = i + 1; j < commandsCount; j++)
                {
                    if (teams[i].Name == teams[j].Name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkDuplicatePlayers()
        {
            for (int i = 0; i < commandsCount; i++)
            {
                for (int k = 0; k < teams[i].UnitsList.Length - 1; k++)
                {
                    for (int h = k + 1; h < teams[i].UnitsList.Length; h++)
                    {
                        if (teams[i].UnitsList[k] == teams[i].UnitsList[h])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool checkRepeatPlayers()
        {
            for (int i = 0; i < commandsCount - 1; i++)
            {
                for (int j = i + 1; j < commandsCount; j++)
                {
                    for (int k = 0; k < teams[i].UnitsList.Length; k++)
                    {
                        for (int h = 0; h < teams[j].UnitsList.Length; h++)
                        {
                            if (teams[i].UnitsList[k] == teams[j].UnitsList[h])
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool checkEmptyNames()
        {
            for (int i = 0; i <= commandsCount - 1; i++)
            {
                if (teams[i].Name == "")
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkEmptyPlayers()
        {
            for (int i = 0; i <= commandsCount - 1; i++)
            {
                if (teams[i].Units == "")
                {
                    return true;
                }
            }
            return false;
        }

        private void guna2ButtonStartGame_Click(object sender, EventArgs e)
        {
            getCommandsInfo();

            if (teams[0].Name == "" || teams[1].Name == "" || teams[0].Units.Length < 1 || teams[1].Units.Length < 1)
            {
                MessageBox.Show("Необходимо заполнить информацию хотя бы о двух командах");
                return;
            }
            if (checkEmptyNames())
            {
                MessageBox.Show("Одно из названий команд не заполнено");
                return;
            }

            if (checkRepeatNames())
            {
                MessageBox.Show("Названия команд не могут совпадать");
                return;
            }
            if (checkDuplicatePlayers())
            {
                MessageBox.Show("Участники не могут повторяться");
                return;
            }
            if (checkRepeatPlayers())
            {
                MessageBox.Show("Участники не могут быть в двух командах сразу");
                return;
            }
            if (checkEmptyPlayers())
            {
                MessageBox.Show("Одна из команд не имеет участников");
                return;
            }

            savedElements = commandsCount;

            if (File.Exists(fileDestination))
            {
                new GameWindow().Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Файл базы данных не найден");
            }
        }
        public static Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

        private static bool used = false;
        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            
            //guna2ButtonStartGame.Enabled = false;
            if (dict.ContainsKey("guna2TextBox1Players"))
            {
                guna2TextBox1Players.Lines = dict["guna2TextBox1Players"];
            }
            if (dict.ContainsKey("guna2TextBox2Players"))
            {
                guna2TextBox1Players.Lines = dict["guna2TextBox2Players"];
            }
            if (dict.ContainsKey("guna2TextBox3Players"))
            {
                guna2TextBox1Players.Lines = dict["guna2TextBox3Players"];
            }
            if (dict.ContainsKey("guna2TextBox4Players"))
            {
                guna2TextBox1Players.Lines = dict["guna2TextBox4Players"];
            }
            if (dict.ContainsKey("guna2TextBox5Players"))
            {
                guna2TextBox1Players.Lines = dict["guna2TextBox5Players"];
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                guna2HtmlLabelTrackBar1Value.Text = "1 минута";
            }
            if (trackBar1.Value == 2)
            {
                guna2HtmlLabelTrackBar1Value.Text = "2 минуты";
            }
            if (trackBar1.Value == 3)
            {
                guna2HtmlLabelTrackBar1Value.Text = "3 минуты";
            }
            if (trackBar1.Value == 4)
            {
                guna2HtmlLabelTrackBar1Value.Text = "4 минуты";
            }
            if (trackBar1.Value == 5)
            {
                guna2HtmlLabelTrackBar1Value.Text = "5 минут";
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar2.Value == 1)
            {
                guna2HtmlLabelTrackBar2Value.Text = "1 минута";
            }
            if (trackBar2.Value == 2)
            {
                guna2HtmlLabelTrackBar2Value.Text = "2 минуты";
            }
            if (trackBar2.Value == 3)
            {
                guna2HtmlLabelTrackBar2Value.Text = "3 минуты";
            }
            if (trackBar2.Value == 4)
            {
                guna2HtmlLabelTrackBar2Value.Text = "4 минуты";
            }
            if (trackBar2.Value == 5)
            {
                guna2HtmlLabelTrackBar2Value.Text = "5 минут";
            }
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar3.Value == 1)
            {
                guna2HtmlLabelTrackBar3Value.Text = "1 минута";
            }
            if (trackBar3.Value == 2)
            {
                guna2HtmlLabelTrackBar3Value.Text = "2 минуты";
            }
            if (trackBar3.Value == 3)
            {
                guna2HtmlLabelTrackBar3Value.Text = "3 минуты";
            }
            if (trackBar3.Value == 4)
            {
                guna2HtmlLabelTrackBar3Value.Text = "4 минуты";
            }
            if (trackBar3.Value == 5)
            {
                guna2HtmlLabelTrackBar3Value.Text = "5 минут";
            }
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar4.Value == 1)
            {
                guna2HtmlLabelTrackBar4Value.Text = "1 минута";
            }
            if (trackBar4.Value == 2)
            {
                guna2HtmlLabelTrackBar4Value.Text = "2 минуты";
            }
            if (trackBar4.Value == 3)
            {
                guna2HtmlLabelTrackBar4Value.Text = "3 минуты";
            }
            if (trackBar4.Value == 4)
            {
                guna2HtmlLabelTrackBar4Value.Text = "4 минуты";
            }
            if (trackBar4.Value == 5)
            {
                guna2HtmlLabelTrackBar4Value.Text = "5 минут";
            }
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar5.Value == 1)
            {
                guna2HtmlLabelTrackBar5Value.Text = "1 минута";
            }
            if (trackBar5.Value == 2)
            {
                guna2HtmlLabelTrackBar5Value.Text = "2 минуты";
            }
            if (trackBar5.Value == 3)
            {
                guna2HtmlLabelTrackBar5Value.Text = "3 минуты";
            }
            if (trackBar5.Value == 4)
            {
                guna2HtmlLabelTrackBar5Value.Text = "4 минуты";
            }
            if (trackBar5.Value == 5)
            {
                guna2HtmlLabelTrackBar5Value.Text = "5 минут";
            }
        }

        private void SettingsWindow_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show(guna2TextBox1Players.Lines.Length.ToString());

        }

        private void SettingsWindow_Enter(object sender, EventArgs e)
        {
        }
    }
}