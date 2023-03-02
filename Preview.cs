using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace GUI
{
    public partial class Preview : Form
    {
        public static string destination = "Resources\\game.json";
        public static RichTextBox box;
        
        public Preview()
        {
            InitializeComponent();

            //List<string> lines = new List<string>();
            string text = File.ReadAllText(SettingsWindow.fileDestination);
            box = this.richTextBox1;

            this.richTextBox1.Text = text;
            /*            Timer timer = new Timer();
                        timer.Interval = (3 * 1000); // 3 secs
                        timer.Tick += new EventHandler(timer_Tick);
                        timer.Start();*/


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            string text = File.ReadAllText(SettingsWindow.fileDestination);
            this.richTextBox1.Text = text;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }


        private async void StartAsync()
        {

            string text = File.ReadAllText(SettingsWindow.fileDestination);
            // do some work
            await Task.Run(() => { Thread.Sleep(1000); });

            // start more work
            var moreWork = Task.Run(() => { Thread.Sleep(1000); });

            // update the UI, based on data from “some work”
            this.richTextBox1.Text = PrettyJson(text);
            


            // wait until “more work” finishes
            await moreWork;
        }

        /*        private static string FormatJson(string json)
                {
                    dynamic parsedJson = JsonConvert.DeserializeObject(json);
                    return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
                }*/

        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        private void elements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
