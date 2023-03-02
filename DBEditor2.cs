using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class DBEditor : Form
    {
        private TreeNode nodes;
        private string previous;
        public static List<JsonDeserialize> j_list = JsonDeserialize.build(SettingsWindow.fileDestination);

        public DBEditor(TreeNode nodes)
        {

            InitializeComponent();

            this.nodes = nodes;
            guna2TextBox1.Text = nodes.Text;
            this.previous = nodes.Text;
        }

        private void DBEditor2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
            {
                if (DialogResult.No == MessageBox.Show("Вы хотите закрыть это окно не сохранив изменения, вы уверены?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                }
                else
                {
                    Dispose();
                    this.Close();
                }
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
                if (DialogResult.Yes == MessageBox.Show("Вы хотите закрыть это окно не сохранив изменения, вы уверены?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Dispose();
                    this.Close();
                }
        }

        private void DBEditor_Load(object sender, EventArgs e)
        {

        }
        private enum NodeStatus // Статус нашего выбора
        {
            THEME, QUESTION, QUESTION_BODY // Мы выбрали тему, сам вопрос, или тело вопроса(варианты ответа, и позиция правильного ответа)
        }
        private void Save_button_Click(object sender, EventArgs e)
        {

            string element = guna2TextBox1.Text; // Наш ввод


            var json_lists = j_list; // ссылка на лист с вопросами

            var parrent = nodes.Parent; // Поднимаемся чуть выше по древу записей
            TreeNode lead_parrent = null; // Поднимаемся ещё выше, null потому что может быть темой или вопросом

            NodeStatus status = NodeStatus.THEME; // По дефолту указываем какой нибудь статус, использование null Недопустимо в этом контексте, хотя вполне уместно

            if (parrent == null) // Если родителя у элемента дерева нет, то есть это тема(корень нашего древа)
            {
                parrent = nodes; // Тогда наш корень будет равен нашему выбору, логично
                status = NodeStatus.THEME; // Ставим статус
            }
            else
            {

                lead_parrent = parrent.Parent; // Роем еще глубже, если родитель не null рискнём взять еще ближе к кроне
                if (lead_parrent == null) // Если взяли, но получили null (то есть это скорее всего вопрос)
                {
                    status = NodeStatus.QUESTION; // Делаем все необходимые инициализации
                    lead_parrent = parrent;

                }
                else
                {
                    status = NodeStatus.QUESTION_BODY; // Если мы выбрали крону(самый глубокий элемент древа, укажем, что это тело вопроса)
                }
            }

            string obj = guna2TextBox1.Text; // Собственно наш ввод
            switch (status) // Статус
            {
                case NodeStatus.THEME:

                    int index = json_lists.FindIndex(s => s.NameOfTheme.Equals(nodes.Text)); // Ищем в списке индекс элемента с конкретным названием темы

                    if (index != -1) // Если вернуло -1, значит такого нет, теоритически такого быть не может, так как -1 не может быть по определению, но проверим на всякий случай
                    {
                        json_lists[index].NameOfTheme = obj; // Динамически обновляем список, устанавливая нужное имя
                    }

                    break;
                case NodeStatus.QUESTION:

                    index = json_lists.FindIndex(s => s.NameOfTheme.Equals(parrent.Text)); // тот же самый поиск,только теперь по родителю, так как наш выбор это вопрос

                    if (index != -1)
                    {
                        json_lists[index].QuestionElement[nodes.Index].Quest = obj; // Динамически обновляем список, устанавливая нужный вопрос
                    }
                    break;
                case NodeStatus.QUESTION_BODY:

                    int index_e = json_lists.FindIndex(s => s.NameOfTheme.Equals(lead_parrent.Text)); // Ищем индексы для корня


                    int index_q = json_lists[index_e]
                        .QuestionElement.FindIndex(s => s.Quest.Equals(parrent.Text)); // далее ищем индексы для директории которая чуть выше

                    if (index_e != -1 && index_q != -1)
                    {
                        if (nodes.Index > 2) { // если в наш выбор не попадают варианты ответа, значит мы пытаемся записать число, хм давайте запишем -|
                            json_lists[index_e].QuestionElement[index_q].Pos = Int32.Parse(obj);                                               //     <
                        }
                        else
                        {
                            json_lists[index_e].QuestionElement[index_q].Ans[nodes.Index] = obj; // если это не число, устанавливаем нужный нам вариант ответа
                        }
                    }

                    break;
                default:
                    break;


            }

            string value = JsonSelialize.serialize(json_lists); // Вызов статической имплементации, для сериализации списка моих объектов

            //Console.WriteLine(value);

            this.nodes.Text = guna2TextBox1.Text;


           // string text = File.ReadAllText(SettingsWindow.fileDestination);

            //var data = text.Split(new string[] { "{", "}" }, StringSplitOptions.RemoveEmptyEntries);

            

           // text = text.Replace(previous, this.nodes.Text);

            /*
             * 
             * Дальше ты все знаешь, максимально простой код
             * 
             */
            File.WriteAllText(SettingsWindow.fileDestination, value);
            this.nodes.ForeColor = Color.Black;
           if (DBViewer.isInitialized)
            {
                Preview.box.Text = value;
           }
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
