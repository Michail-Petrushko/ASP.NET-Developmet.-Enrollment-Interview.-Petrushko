using System;
using System.Collections;
using System.Collections.Generic;

namespace VowelCountTask
{
    
    public class Class1
    {
        public static int CountOfVowels(string str)
        {
            int num = 0;
            char[] c = new[] { 'a', 'e', 'u', 'i', 'o' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int k = 0; k < c.Length; k++)
                {
                    if (str[i] == c[k])
                    {
                        num++;
                        break;
                    }
                }
            }
            return num;
        }

        public static string[] OrderStringsByLength(string[] str)
        {

            string[] strNew = new string[str.Length];
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < str.Length; i++)
            {
                List<int> list = new List<int> { };
                list.Add(i);
                if (!dict.ContainsKey(str[i].Length))
                    dict.Add(str[i].Length, list);
                else
                {
                    foreach (KeyValuePair<int, List<int>> c in dict)
                    {
                        if (c.Key == str[i].Length)
                        {
                            c.Value.Add(i);
                        }
                    }
                }
            }
            var sortedDict = new SortedDictionary<int, List<int>>(dict);
            int b = 0;
            foreach (KeyValuePair<int, List<int>> c in sortedDict)
            {
                foreach (int val in c.Value)
                {
                    strNew[b++] = str[val];
                }

            }
            return strNew;
        }

        public static string RemoveDuplicateWords(string str)
        {
            char[] c = new char[] { '.', ',', '!', '?', '-', ':', ';' };

            string[] words = str.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (str.IndexOf(words[i]) != str.LastIndexOf(words[i]))
                {
                    string temp = "";
                    if (words[i].LastIndexOfAny(c) == words[i].Length - 1)
                    {

                        temp = words[i].Remove(words[i].Length - 1);
                        str.Substring(str.LastIndexOf(temp), temp.Length);
                    }
                    else
                    {
                        temp = words[i];
                        str.Substring(str.LastIndexOf(temp), temp.Length);
                    }
                    i = 0;
                }
            }

            return str;
        }

    }

}
