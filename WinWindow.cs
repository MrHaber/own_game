using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class WinWindow : Form
    {
        public List<string> elements = new List<string>();
        public WinWindow()
        {
            InitializeComponent();
            this.TopMost = true;
            team_1.Text = SettingsWindow.teams[0].Name;
            team_2.Text = SettingsWindow.teams[1].Name;
            team_3.Text = SettingsWindow.teams[2].Name;
            team_4.Text = SettingsWindow.teams[3].Name;
            team_5.Text = SettingsWindow.teams[4].Name;

            members_1.Text = SettingsWindow.teams[0].Units;
            members_2.Text = SettingsWindow.teams[1].Units;
            members_3.Text = SettingsWindow.teams[2].Units;
            members_4.Text = SettingsWindow.teams[3].Units;
            members_5.Text = SettingsWindow.teams[4].Units;

            p_1.Text = SettingsWindow.teams[0].Points.ToString();
            p_2.Text = SettingsWindow.teams[1].Points.ToString();
            p_3.Text = SettingsWindow.teams[2].Points.ToString();
            p_4.Text = SettingsWindow.teams[3].Points.ToString();
            p_5.Text = SettingsWindow.teams[4].Points.ToString();

            elements.Add(team_1.Text + " | Участники: " + members_1.Text + " | Очки: " + p_1.Text);

            elements.Add(team_2.Text + " | Участники: " + members_2.Text + " | Очки: " + p_2.Text);

            elements.Add(team_3.Text + " | Участники: " + members_3.Text + " | Очки: " + p_3.Text);

            elements.Add(team_4.Text + " | Участники: " + members_4.Text + " | Очки: " + p_4.Text);

            elements.Add(team_5.Text + " | Участники: " + members_5.Text + " | Очки: " + p_5.Text);

            resize_lbl(team_1, 20); resize_lbl(members_1, 20);

            resize_lbl(team_2, 20); resize_lbl(members_2, 20);

            resize_lbl(team_3, 20); resize_lbl(members_3, 20);

            resize_lbl(team_4, 20); resize_lbl(members_4, 20);

            resize_lbl(team_5, 20); resize_lbl(members_5, 5);
            GameWindow.timer.Stop();

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

            t_1.Visible = false;
            t_2.Visible = false;
            t_3.Visible = false;
            t_4.Visible = false;
            t_5.Visible = false;
            ps_1.Visible = false;

            ps_2.Visible = false;

            ps_3.Visible = false;

            ps_4.Visible = false;

            ps_5.Visible = false;
            switch (SettingsWindow.savedElements)
            {
                case 1:
                    t_1.Visible = true;
                    ps_1.Visible = true;
                    team_1.Visible = true;
                    p_1.Visible = true;

                    break;
                case 2:
                    t_1.Visible = true;
                    ps_1.Visible = true;
                    t_2.Visible = true;
                    ps_2.Visible = true;
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    break;
                case 3:
                    t_1.Visible = true;
                    ps_1.Visible = true;
                    t_2.Visible = true;
                    ps_2.Visible = true;
                    t_3.Visible = true;
                    ps_3.Visible = true;
                    team_1.Visible = true;
                    p_1.Visible = true;
                    team_2.Visible = true;
                    p_2.Visible = true;
                    team_3.Visible = true;
                    p_3.Visible = true;
                    break;
                case 4:
                    t_1.Visible = true;
                    ps_1.Visible = true;
                    t_2.Visible = true;
                    ps_2.Visible = true;
                    t_3.Visible = true;
                    ps_3.Visible = true;
                    t_4.Visible = true;
                    ps_4.Visible = true;
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
                    t_1.Visible = true;
                    ps_1.Visible = true;
                    t_2.Visible = true;
                    ps_2.Visible = true;
                    t_3.Visible = true;
                    ps_3.Visible = true;
                    t_4.Visible = true;
                    ps_4.Visible = true;
                    t_5.Visible = true;
                    ps_5.Visible = true;
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
        public static float t_size = 12;
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void WinWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "",
                "SvoyaIgraWinList.txt");
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сохранить результат в текстовый файл?", "Вы уверены?", MessageBoxButtons.YesNo);

            elements.RemoveAll(x => x.StartsWith(" "));

            StringBuilder bd = new StringBuilder();
            if (dialogResult == DialogResult.Yes)
            {
                elements.ForEach(x => bd.Append(x + "\n"));

                File.WriteAllText(filePath, bd.ToString());

                MessageBox.Show("Файл успешно сохранён на рабочем столе.");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
    }
}
