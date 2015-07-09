using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence; //Введенное предложение
            Console.Write("Введите предложение: ");
            sentence = Console.ReadLine();

            sentence = sentence.TrimEnd(new char[] { '.', '!', '?' }); //Удаляем знак препинания в конце предложения.
            //Разделяем предложение на слова и помещаем их в массив
            string[] words = sentence.Split(
                new string[] { " ", ", ", ". ", " - ", ": ", "; " }, System.StringSplitOptions.RemoveEmptyEntries);

            //Сортируем слова по возрастанию кол-ва символов
            IEnumerable<string> query = from word in words //Берем слова из массива words
                                        orderby word.Length descending //Сортируем по убыванию по длине слова
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str); //Выводим итог

            Console.ReadKey();
        }
    }
}