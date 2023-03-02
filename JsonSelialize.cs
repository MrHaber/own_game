using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public static class JsonSelialize
    {

    /*
     * 
     * Функция для серилизации объекта, собственного производства.
     * 
     */
        public static string serialize(List<JsonDeserialize> elements)
        {
            string container = "[{";
            int iterator = 1;
            foreach (JsonDeserialize j_d in elements)
            {
                container += "\"test" + iterator + "\":[";
                //TreeNode c_theme = view.Nodes.Add(j_d.NameOfTheme);
                foreach (Question q in j_d.QuestionElement)
                {
                    container += "[";

                    container += "\"" + j_d.NameOfTheme + "\"" + ",";

                    container += "\"" + q.Quest + "\"" + ",";

                    container += "\"" + q.Ans[0] + "\"" + ",";

                    container += "\"" + q.Ans[1] + "\"" + ",";

                    container += "\"" + q.Ans[2] + "\"" + ",";

                    container += "\"" + q.Pos.ToString() + "\"";
                    if (j_d.QuestionElement.LastOrDefault().Equals(q))
                    {
                        container += "]";
                    }
                    else
                    {
                        container += "],";
                    }

                }
                if (elements.LastOrDefault().Equals(j_d))
                {
                    container += "]";
                }
                else
                {
                    container += "],";
                }
                iterator += 1;

            }
            container += "}]";

            return container;
        }


    }
