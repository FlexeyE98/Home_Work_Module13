using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel.Design;
using System.Security.Cryptography;

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

        public static Dictionary<string,int> Counter(string text)
        {
            var myDictionary = new Dictionary<string, int>();
            char[] separators = new char[] { ' ', '.', '-', ','};
            string[] arrayText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;


            for (int i = 0; i < arrayText.Length; i++)
            {
                for (int j = i + 1; j < arrayText.Length; j++)
                {
                    if (arrayText[i] == arrayText[j])
                    {
                        counter++;
                        if (!myDictionary.ContainsKey(arrayText[i]))
                            myDictionary.Add(arrayText[i], counter);
                        else
                        {
                            myDictionary[arrayText[i]]++;
                        }
                    }
                }
                counter = 1;
            }
            var sortedDict = myDictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var result = new Dictionary<string, int>();
            int counter2 = 0;

            foreach (var i in sortedDict)
            {
                if (counter2 <= 10)
                {
                    result.Add(i.Key, i.Value);
                    counter2++;
                }
            }
            return result;
        }

    }
}




