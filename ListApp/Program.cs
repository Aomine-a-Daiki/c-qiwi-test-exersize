using System;
using System.Linq;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPersonalData = new LinkedList<string>();
            Console.WriteLine("Добавление\n");
            myPersonalData.Add("Amir");
            myPersonalData.Add("Batyrov");
            myPersonalData.Add("26.11.1996");
            myPersonalData.Add("I want to study and work for programming at Qiwi Company");
            myPersonalData.Add("temp");

            foreach (var items in myPersonalData)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine($"\nКоличество элементов в списке: {myPersonalData.Count()}");
            Console.WriteLine("\nЧтобы продолжить нажмите любую клавишу\n");
            Console.ReadKey();


            Console.WriteLine($"\nЭлемент по индексу 3: {myPersonalData.ElementAt(3)}");
            Console.WriteLine("\nЧтобы продолжить нажмите любую клавишу\n");
            Console.ReadKey();


            myPersonalData.InsertOf(3, ".Net");
            Console.WriteLine("\nПроверка вставки по индексу 3\n");
            foreach (var items in myPersonalData)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine($"\nКоличество элементов в списке: {myPersonalData.Count()}");
            Console.WriteLine("\nЧтобы продолжить нажмите любую клавишу\n");
            Console.ReadKey();


            //myPersonalData.Remove("temp");
            //Console.WriteLine("Удаление\n");
            //foreach (var items in myPersonalData)
            //{
            //    Console.WriteLine(items);
            //}
            //Console.WriteLine($"\nКоличество элементов в списке: {myPersonalData.Count()}");
            //Console.WriteLine("\nЧтобы продолжить нажмите любую клавишу");
            //Console.ReadKey();

            myPersonalData.RemoveAt(3);
            Console.WriteLine("Удаление элемента по индексу 3\n");
            foreach (var items in myPersonalData)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine($"\nКоличество элементов в списке: {myPersonalData.Count()}");
            Console.WriteLine("\nЧтобы продолжить нажмите любую клавишу");
            Console.ReadKey();


            Console.WriteLine("\nИспользование Linq - Select: " + string.Join(" ", myPersonalData.Select(x => x)));
            Console.ReadKey();

        }

    }
}
