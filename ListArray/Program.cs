using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using static ListArray.Program;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Xml.Linq;
using System;
using System.Text;
using System.Text.Unicode;

namespace ListArray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance); //Для кодировки из 1251 to UTF8
            string path = @"C:\Users\Привет\Desktop\text.txt";
            var read = File.ReadAllText(path);
            var correctRead = CheckProcessing.ConvertWin1251ToUTF8(read);
            var myList = CheckProcessing.CheckTimeList(correctRead); //(1)  Метод проверки выполнения затраченного времени коллекцией List<>
            Console.WriteLine();
            Console.WriteLine();
            var myLinkedList = CheckProcessing.CheckTimeLinkedList(correctRead); //(2)   Метод проверки выполнения затраченного времени коллекцией LinkedList<>


        }



    

    }




}

