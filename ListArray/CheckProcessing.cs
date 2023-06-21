using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;

namespace ListArray
{
    public static class CheckProcessing
    {
        readonly static System.Text.Encoding WINDOWS1251 = Encoding.GetEncoding(1251);
        readonly static System.Text.Encoding UTF8 = Encoding.UTF8;

        public static string ConvertWin1251ToUTF8(string inString)
        {
            return UTF8.GetString(WINDOWS1251.GetBytes(inString));
        }

        public static List<string> CheckTimeList(string text)
        {
            var stopWatch = Stopwatch.StartNew();

            var myList = new List<string>();

            string temp = "";

            for (int i = 0; i < text.Length; i++)
            {

                if (Char.IsPunctuation(text[i]) == false && Char.IsWhiteSpace(text[i]) == false)
                {
                    temp += text[i];
                }

                else
                {
                    myList.Add(temp);
                    temp = "";
                }
            }
            Console.WriteLine($"В коллекции: {myList.Count} слов");
            Console.WriteLine($"Затраченное время List: {stopWatch.Elapsed.TotalSeconds}");
            return myList;

        }

        public static LinkedList<string> CheckTimeLinkedList(string text)
        {
            var stopWatch = Stopwatch.StartNew();

            var myList = new LinkedList<string>();

            string temp = "";

            for (int i = 0; i < text.Length; i++)
            {

                if (Char.IsPunctuation(text[i]) == false && Char.IsWhiteSpace(text[i]) == false)
                {
                    temp += text[i];
                }

                else
                {
                    myList.AddFirst(temp);
                    temp = "";
                }
            }
            Console.WriteLine($"В коллекции: {myList.Count} слов");
            Console.WriteLine($"Затраченное время LinkedList: {stopWatch.Elapsed.TotalSeconds}");
            return myList;

        }

    }


}

