using System;
using System.Collections.Generic;
using System.Linq;
using VishanovA_40_GUNPC;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Домашнее задание по коллекциям ===");

            while (true)
            {
                Console.WriteLine("\nВыберите задание для выполнения:");
                Console.WriteLine("1. Работа со списком строк");
                Console.WriteLine("2. Словарь студентов и оценок");
                Console.WriteLine("3. Двусвязный список");
                Console.WriteLine("0. Выход из программы");
                Console.Write("Ваш выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int task))
                {
                    Console.WriteLine("Ошибка! Введите число от 0 до 3.");
                    continue;
                }

                switch (task)
                {
                    case 0:
                        Console.WriteLine("Выход из программы.");
                        return;
                    case 1:
                        CheckTaskFirst();
                        break;
                    case 2:
                        CheckTaskSecond();
                        break;
                    case 3:
                        CheckTaskThird();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Введите число от 0 до 3.");
                        break;
                }
            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var dictTask = new DictionaryTask();
            dictTask.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new DoublyLinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}