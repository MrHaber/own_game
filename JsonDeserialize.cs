using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

    public class JsonDeserialize
    {
        private string name_of_theme;

        private List<Question> question_element;

        public static dynamic getElement(string text)
        {
            return JsonConvert.DeserializeObject(text);
        }

        public static List<JsonDeserialize> build(string filelink)
        {
            List<JsonDeserialize> list = new List<JsonDeserialize>();
            string text = File.ReadAllText(filelink);
            dynamic element = getElement(text);
            foreach (var item in element)
            {
                List<string[]> tmplist = new List<string[]>();

                foreach (var item2 in item.test1)
                {
                    int iterator_m = 0;
                    string[] a = new string[6];
                    foreach (var item3 in item2)
                    {
                        a[iterator_m] = item3;
                        iterator_m += 1;
                    }
                    tmplist.Add(a);
                }
                List<Question> quests = new List<Question>();
                int multiplier = 1;
                foreach (var item4 in tmplist)
                {
                    List<string> answers = new List<string>()
                    {
                        item4[2],item4[3],item4[4]
                    };
                    Question qq = new Question(item4[0], item4[1], answers, Int32.Parse(item4[5]),100*multiplier);
                    multiplier += 1;
                    quests.Add(qq);
                }
                JsonDeserialize json = new JsonDeserialize((string)item.test1[0][0], quests);

                //Console.WriteLine(iterator+ " Id is " + (string)item.test1[iterator][0]);

                list.Add(json);

                tmplist = new List<string[]>();

                foreach (var item2 in item.test2)
                {
                    int iterator_m = 0;
                    string[] a = new string[6];
                    foreach (var item3 in item2)
                    {
                        a[iterator_m] = item3;
                        iterator_m += 1;
                    }
                    tmplist.Add(a);
                }
                quests = new List<Question>();
                multiplier = 1;
            foreach (var item4 in tmplist)
                {
                
                List<string> answers = new List<string>()
                    {
                        item4[2],item4[3],item4[4]
                    };
                    Question qq = new Question(item4[0], item4[1], answers, Int32.Parse(item4[5]),100*multiplier);
                    quests.Add(qq);
                    multiplier += 1;
                }
                json = new JsonDeserialize((string)item.test2[0][0], quests);

                //Console.WriteLine(iterator + " Id is " + (string)item.test1[iterator][0]);
                list.Add(json);

                tmplist = new List<string[]>();

                foreach (var item2 in item.test3)
                {
                    int iterator_m = 0;
                    string[] a = new string[6];
                    foreach (var item3 in item2)
                    {
                        a[iterator_m] = item3;
                        iterator_m += 1;
                    }
                    tmplist.Add(a);
                }
                quests = new List<Question>();
            multiplier = 1;
            foreach (var item4 in tmplist)
                {
                    List<string> answers = new List<string>()
                    {
                        item4[2],item4[3],item4[4]
                    };
                    Question qq = new Question(item4[0], item4[1], answers, Int32.Parse(item4[5]), 100 * multiplier);
                    quests.Add(qq);
                multiplier += 1;
            }
                json = new JsonDeserialize((string)item.test3[0][0], quests);

                //Console.WriteLine(iterator + " Id is " + (string)item.test1[iterator][0]);
                list.Add(json);
                
                //iterator += 1;

                tmplist = new List<string[]>();

                foreach (var item2 in item.test4)
                {
                    int iterator_m = 0;
                    string[] a = new string[6];
                    foreach (var item3 in item2)
                    {
                        a[iterator_m] = item3;
                        iterator_m += 1;
                    }
                    tmplist.Add(a);
                }
                quests = new List<Question>();
            multiplier = 1;
            foreach (var item4 in tmplist)
                {
                    List<string> answers = new List<string>()
                    {
                        item4[2],item4[3],item4[4]
                    };
                    Question qq = new Question(item4[0], item4[1], answers, Int32.Parse(item4[5]), 100 * multiplier);
                    quests.Add(qq);
                multiplier += 1;
            }
                json = new JsonDeserialize((string)item.test4[0][0], quests);

                //Console.WriteLine(iterator + " Id is " + (string)item.test1[iterator][0]);
                list.Add(json);

                tmplist = new List<string[]>();

                foreach (var item2 in item.test5)
                {
                    int iterator_m = 0;
                    string[] a = new string[6];
                    foreach (var item3 in item2)
                    {
                        a[iterator_m] = item3;
                        iterator_m += 1;
                    }
                    tmplist.Add(a);
                }
                quests = new List<Question>();
            multiplier = 1;
            foreach (var item4 in tmplist)
                {
                    List<string> answers = new List<string>()
                    {
                        item4[2],item4[3],item4[4]
                    };
                    Question qq = new Question(item4[0], item4[1], answers, Int32.Parse(item4[5]), 100 * multiplier);
                    quests.Add(qq);
                multiplier += 1;
            }
                json = new JsonDeserialize((string)item.test5[0][0], quests);

                //Console.WriteLine(iterator + " Id is " + (string)item.test1[iterator][0]);
                list.Add(json);

            }
            return list;
        }

        public JsonDeserialize(string name_of_theme, List<Question> question_element)
        {
            this.name_of_theme = name_of_theme;
            this.question_element = question_element;
        }
        public string NameOfTheme
        {
            get { return name_of_theme; }

            set { name_of_theme = value; }
    }
        public List<Question> QuestionElement
        {
            get { return question_element; }

            set { question_element = value; }
    }
    }

