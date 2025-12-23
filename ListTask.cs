using System;
using System.Collections.Generic;
using System.Text;

namespace VishanovA_40_GUNPC
{
    public class ListTask
    {
        private readonly List<string> _listOfStrings;

        public ListTask()
        {
            _listOfStrings = new List<string> { "Яблоко", "Банан", "Апельсин", "Груша" };
        }

        public void TaskLoop()
        {
            Console.WriteLine("\n=== Задание 1: Работа со списком строк ===");
            Console.WriteLine("Для выхода введите '--exit'");

            while (true)
            {
                Console.WriteLine("\nТекущий список:");
                PrintList();

                Console.Write("\nВведите новую строку для добавления (или '--exit' для выхода): ");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "--exit")
                {
                    Console.WriteLine("Выход из задания 1.");
                    break;
                }

                // Добавление в конец
                _listOfStrings.Add(input);
                Console.WriteLine($"Строка '{input}' добавлена в конец списка.");

                Console.Write("Введите еще одну строку для добавления в середину: ");
                string input2 = Console.ReadLine() ?? "";

                if (input2.ToLower() == "--exit")
                {
                    Console.WriteLine("Выход из задания 1.");
                    break;
                }

                // Добавление в середину
                int middleIndex = _listOfStrings.Count / 2;
                _listOfStrings.Insert(middleIndex, input2);
                Console.WriteLine($"Строка '{input2}' добавлена в середину списка (индекс {middleIndex}).");
            }
        }

        private void PrintList()
        {
            for (int i = 0; i < _listOfStrings.Count; i++)
            {
                Console.WriteLine($"[{i}] {_listOfStrings[i]}");
            }
        }
    }
}
