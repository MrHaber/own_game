using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class PlayerAddWindow : Form
    {
        private List<Guna2TextBox> textboxElements = new List<Guna2TextBox>();
        public PlayerAddWindow()
        {
            InitializeComponent();

            textboxElements.Add(guna2TextBox1Players);
            textboxElements.Add(guna2TextBox2Players);
            textboxElements.Add(guna2TextBox3Players);
            textboxElements.Add(guna2TextBox4Players);
            textboxElements.Add(guna2TextBox5Players);

            Team1Name.Text = SettingsWindow.teams[0].Name;
            Team2Name.Text = SettingsWindow.teams[1].Name;
            Team3Name.Text = SettingsWindow.teams[2].Name;
            Team4Name.Text = SettingsWindow.teams[3].Name;
            Team5Name.Text = SettingsWindow.teams[4].Name;

            for (int i = 0; i<=SettingsWindow.teams.Count - 1; i++)
            {
                textboxElements[i].Text = SettingsWindow.teams[i].Units.Replace(", ","\r\n");
            }
            if (guna2TextBox3Players.Text == "")
            {
                guna2TextBox3Players.Enabled = false;
                Team3Name.Visible = false;
            }
            if (guna2TextBox4Players.Text == "")
            {
                guna2TextBox4Players.Enabled = false;
                Team4Name.Visible = false;
            }
            if (guna2TextBox5Players.Text == "")
            {
                guna2TextBox5Players.Enabled = false;
                Team5Name.Visible = false;
            }


        }
        public bool checkEmptyPlayers()
        {
            for (int i = 0; i <= SettingsWindow.commandsCount - 1; i++)
            {
                if (textboxElements[i].Text == "")
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkDuplicatePlayers()
        {
            for (int i = 0; i<=SettingsWindow.commandsCount - 1; i++)
            {
                for (int k = 0; k < textboxElements[i].Lines.Length - 1; k++)
                if (textboxElements[i].Lines[k] == textboxElements[i].Lines[k+1])
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkRepeatPlayers()
        {
            for (int i = 0; i < SettingsWindow.commandsCount - 1; i++)
            {
                for (int j = i + 1; j < SettingsWindow.commandsCount; j++)
                {
                    for (int k = 0; k < textboxElements[i].Lines.Length; k++)
                    {
                        for (int h = 0; h < textboxElements[j].Lines.Length; h++)
                        {
                            if (textboxElements[i].Lines[k] == textboxElements[j].Lines[h])
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void UpdateTeam()
        {
            for (int i = 0; i<=SettingsWindow.commandsCount - 1; i++)
            {
                SettingsWindow.teams[i].Units = textboxElements[i].Text.Replace("\r\n", ", ");
            }
        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
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

            if (checkDuplicatePlayers())
            {
                MessageBox.Show("Участники не могут повторяться");
                return;
            }
            UpdateTeam();
            GameWindow.timer.Start();
            Application.OpenForms["GameWindow"].Show();
            this.Hide();
            
        }

        private void PlayerAddWindow_Load(object sender, EventArgs e)
        {

        }
    }

}
