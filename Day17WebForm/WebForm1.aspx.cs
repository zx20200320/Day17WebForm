using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day17WebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //获取输入的字符串
            string str = tbInput.Text;
            //字符串分割成字符串数组
            var arr1 = str.Split(',');
            //定义一个空数组用于存放排序后的单词
            string[] arr2 = new string[arr1.Length];
            //for循环给arr2赋值
            for (int i = 0; i < arr1.Length; i++)
            {
                //把arr1字符串数组的对应项转换为字符数组
                char[] c = arr1[i].ToCharArray();
                //排序
                Array.Sort(c);
                //arr2对应项赋值成排序后的字符数组拼接成的字符串
                arr2[i] = string.Concat(c);
            }
            //定义一个字典key是排好序的每一项字符串,value存放分
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < arr2.Length; i++)
            {
                //通过key去筛选有没有相同的
                if (dic.ContainsKey(arr2[i]))
                {
                    //有相同的key,对应字典项的值的集合添加对应的项
                    dic[arr2[i]].Add(arr1[i]);
                }
                else
                {
                    //如果key不存在,字典新增一项
                    dic.Add(arr2[i], new List<string>() { arr1[i] });
                }
            }
            string result = "";
            foreach (var item in dic.Values)
            {
                result += string.Join(",", item.Distinct()) + "\n";
            }
            tbOutput.Text = result;
        }
    }
}