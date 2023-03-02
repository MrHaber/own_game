
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GUI
{
    public partial class DBViewer : Form
    {

        public static string choosen = "test1";

        public static string globalThemeName = "";
        public List<List<string>> values = new List<List<string>>();
        public List<string> variables = new List<string>();

        public static List<JsonDeserialize> j_list = JsonDeserialize.build(SettingsWindow.fileDestination);

        public static bool isInitialized = false;
        private List<string> gps = new List<string>()
        {
            "theme_1", "theme_2", "theme_3","theme_4","theme_5"
        };

        public static Dictionary<string, List<List<string>>> finalDict = new Dictionary<string, List<List<string>>>()
        {
            {"test1",new List<List<string>>()},
            {"test2",new List<List<string>>()},
            {"test3",new List<List<string>>()},
            {"test4",new List<List<string>>()},
            {"test5",new List<List<string>>()},
        };


        public DBViewer()
        {
            InitializeComponent();

            treeView1.Nodes.Clear();

            /*            using (var reader = new StreamReader(SettingsWindow.fileDestination))
                        using (var jsonReader = new JsonTextReader(reader))
                        {
                            var root = JToken.Load(jsonReader);
                            DisplayTreeView(root, Path.GetFileNameWithoutExtension(SettingsWindow.fileDestination));
                        }*/

            generateTree(treeView1);

            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBEditor_Load(object sender, EventArgs e)
        {

        }

        //private void fillTreeView()
        // {
        // int ims = 0;
        // foreach (JsonDeserialize qs in j_list)
        //{
        // TreeNode node = new TreeNode(qs.NameOfTheme, qs.QuestionElement.ToArray());
        // }
        //}

        //Dictionary<string, int> _values = new Dictionary<string, int>();
        private void generateTree(System.Windows.Forms.TreeView view)
        {

            view.BeginUpdate();
            //string serialized = JsonSelialize.serialize(j_list);
            //int absolute_pos = 0;
            //Console.WriteLine(serialized);
            foreach (JsonDeserialize j_d in j_list)
            {
                TreeNode c_theme = view.Nodes.Add(j_d.NameOfTheme);
                foreach (Question q in j_d.QuestionElement)
                {

                    TreeNode q_theme = c_theme.Nodes.Add(q.Quest);

                    q_theme.Nodes.Add(q.Ans[0]);

                    q_theme.Nodes.Add(q.Ans[1]);

                    q_theme.Nodes.Add(q.Ans[2]);

                    q_theme.Nodes.Add(q.Pos.ToString());



                }
            }
            view.EndUpdate();
        }
        private void DisplayTreeView(JToken root, string rootName)
        {
            treeView1.BeginUpdate();
            try
            {
                treeView1.Nodes.Clear();
                var tNode = treeView1.Nodes[treeView1.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;

                AddNode(root, tNode);

                treeView1.ExpandAll();
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }
        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                }
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }
        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

/*        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (th_1.Checked)
            {
                choosen = "test1";
                choose.Text = "Тема-1";
                variables.Clear();
            }
            if (th_2.Checked)
            {
                choosen = "test2";
                choose.Text = "Тема-2";
                variables.Clear();
            }
            if (th_3.Checked)
            {
                choosen = "test3";
                choose.Text = "Тема-3";
                variables.Clear();
            }
            if (th_4.Checked)
            {
                choosen = "test4";
                choose.Text = "Тема-4";
                variables.Clear();
            }
            if(th_5.Checked)
            {
                choosen = "test5";
                choose.Text = "Тема-5";
                variables.Clear();
            }
            
        }*/

        private void save_Click(object sender, EventArgs e)
        {
            
            //if (variables.Count < 1)
            //{
            //    variables.Add(th_n.Text);
            //}
            //else
            //{
            //    variables[0] = th_n.Text;
            //}
            //f_1.Text = variables.Count.ToString();
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Preview().Show();
            isInitialized = true;
/*            new StartWindow().Show();

            this.Hide();
            variables.Clear();
            values.Clear();
            finalDict.Clear();*/
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var copy = ObjectCopier.Clone(values);
            finalDict[choosen] = copy;

           // f_2.Text =values.Count.ToString();

            values.Clear();
            if (Preview.box != null)
            {
                Preview.box.Text = PrettyJson(JsonConvert.SerializeObject(finalDict));
            }
            //res.Text += "Test is : " + finalDict["test1"][0][0];
            
        }

/*        private void clear_Click(object sender, EventArgs e)
        {
            variables.Clear();
            f_1.Text = variables.Count.ToString();
        }*/

/*        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (q_1.Checked)
            {
                variables.Add(q_n.Text);
                q_n.Text = "";
            }
            if (q_2.Checked)
            {
                variables.Add(q_n.Text);
                q_n.Text = "";
            }
            if (q_3.Checked)
            {
                variables.Add(q_n.Text);
                q_n.Text = "";
            }
            if (q_4.Checked)
            {
                variables.Add(q_n.Text);
               
                q_n.Text = "";
            }
            if (q_5.Checked)
            {
                variables.Add(q_n.Text);
                q_n.Text = "";
            }
            f_1.Text = variables.Count.ToString();
        }*/
/*
        private void fg_Click(object sender, EventArgs e)
        {
            var copy = ObjectCopier.Clone(variables);
            values.Add(copy);
            //res.Text += values[0][0] + " ";
            f_1.Text = variables.Count.ToString();
           // f_2.Text = values.Count.ToString();
            variables.Clear();
        }*/

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //            string path = "Resources\\game.json";
            ///*            foreach (KeyValuePair<string, List<List<string>>> kvp in finalDict)
            //            {
            //                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //                res.Text += string.Format("Key = {0}, Value = {1}, Size = {2}",
            //                    kvp.Key, finalDict["test1"][0][0], kvp.Value.Count);
            //            }*/
            //            // The line below will create a file my_file.py in
            //            // the Python_Files folder in D:\ drive
            //            FileStream fs = File.Create(path);
            //            fs.Close();
            //            string jsonString = JsonConvert.SerializeObject(finalDict);
            //            File.WriteAllText(path, jsonString);

            //            MessageBox.Show(jsonString);
            //new StartWindow().Show();
            this.Close();
        }

        private void f_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            new StartWindow().Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            variables.Clear();
            values.Clear();
            finalDict.Clear();
            choosen = "test1";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var pr = new Preview();
            pr.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private enum NodeStatus
        {
            THEME,QUESTION,QUESTION_BODY
        }

        private void treeView1_DoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.GetNodeAt(e.Location);


            if (node != null)
            {
                // делаем что-то с узлом
                Form DBEditor2 = new DBEditor(node);
                DBEditor2.Show();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
