using ListArray;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _Task2__CountLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance); //Для кодировки из 1251 to UTF8
            string path = @"C:\Users\Привет\Desktop\text.txt";
            var read = File.ReadAllText(path);
            var correctRead = CheckProcessing.ConvertWin1251ToUTF8(read);
            var noPunctuationText = new string(correctRead.Where(c => !char.IsPunctuation(c)).ToArray());
            var countWordsDict = CheckProcessing.Counter(noPunctuationText);

            foreach(var i in countWordsDict)
                Console.WriteLine($"Слово: {i.Key} встречается : {i.Value} раз");
        }
    }
}