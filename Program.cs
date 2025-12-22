using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            private readonly List<string> _listOfStrings;

            public ListTask()
            {
                _listOfStrings = new List<string> { "Первая строка", "Вторая строка", "Третья строка" };
            }

            public void TaskLoop()
            {
                Console.WriteLine("=== Задание 1: Работа со списком строк ===");
                Console.WriteLine("Для выхода введите '--exit'");

                while (true)
                {
                    Console.WriteLine("\nТекущее содержимое списка:");
                    foreach (var item in _listOfStrings)
                    {
                        Console.WriteLine($"- {item}");
                    }

                    Console.Write("\nВведите новую строку для добавления в конец списка: ");
                    string input = Console.ReadLine();

                    if (input == "--exit")
                    {
                        Console.WriteLine("Выход из задания 1.");
                        break;
                    }

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        _listOfStrings.Add(input);
                        Console.WriteLine($"Строка '{input}' добавлена в конец списка.");
                    }

                    Console.Write("\nВведите строку для добавления в середину списка: ");
                    string middleInput = Console.ReadLine();

                    if (middleInput == "--exit")
                    {
                        Console.WriteLine("Выход из задания 1.");
                        break;
                    }

                    if (!string.IsNullOrWhiteSpace(middleInput))
                    {
                        int middleIndex = _listOfStrings.Count / 2;
                        _listOfStrings.Insert(middleIndex, middleInput);
                        Console.WriteLine($"Строка '{middleInput}' добавлена в середину списка (индекс {middleIndex}).");
                    }
                }
            }
        }

        private class DictionaryTask
        {
            private readonly Dictionary<string, double> _studentsGrades;

            public DictionaryTask()
            {
                _studentsGrades = new Dictionary<string, double>
                {
                    { "Иван Иванов", 4.5 },
                    { "Мария Петрова", 3.8 },
                    { "Алексей Сидоров", 4.2 }
                };
            }

            public void TaskLoop()
            {
                Console.WriteLine("=== Задание 2: Словарь студентов и оценок ===");
                Console.WriteLine("Для выхода введите '--exit'");

                while (true)
                {
                    Console.WriteLine("\nТекущий список студентов:");
                    foreach (var student in _studentsGrades)
                    {
                        Console.WriteLine($"- {student.Key}: {student.Value}");
                    }

                    Console.Write("\nВведите имя студента для добавления/обновления: ");
                    string name = Console.ReadLine();

                    if (name == "--exit")
                    {
                        Console.WriteLine("Выход из задания 2.");
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Имя не может быть пустым!");
                        continue;
                    }

                    Console.Write("Введите оценку студента (от 2 до 5): ");
                    string gradeInput = Console.ReadLine();

                    if (gradeInput == "--exit")
                    {
                        Console.WriteLine("Выход из задания 2.");
                        break;
                    }

                    if (double.TryParse(gradeInput, out double grade) && grade >= 2 && grade <= 5)
                    {
                        _studentsGrades[name] = grade;
                        Console.WriteLine($"Студент '{name}' добавлен/обновлен с оценкой {grade}.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: оценка должна быть числом от 2 до 5!");
                        continue;
                    }

                    Console.Write("\nВведите имя студента для поиска оценки: ");
                    string searchName = Console.ReadLine();

                    if (searchName == "--exit")
                    {
                        Console.WriteLine("Выход из задания 2.");
                        break;
                    }

                    if (_studentsGrades.TryGetValue(searchName, out double foundGrade))
                    {
                        Console.WriteLine($"Студент '{searchName}' имеет оценку: {foundGrade}");
                    }
                    else
                    {
                        Console.WriteLine($"Студент с именем '{searchName}' не найден в словаре.");
                    }
                }
            }
        }

        private class LinkedListTask
        {
            private class Node
            {
                public string Data { get; set; }
                public Node Next { get; set; }
                public Node Previous { get; set; }

                public Node(string data)
                {
                    Data = data;
                    Next = null;
                    Previous = null;
                }
            }

            private Node _head;
            private Node _tail;

            public LinkedListTask()
            {
                _head = null;
                _tail = null;
            }

            public void Add(string data)
            {
                Node newNode = new Node(data);

                if (_head == null)
                {
                    _head = newNode;
                    _tail = newNode;
                }
                else
                {
                    _tail.Next = newNode;
                    newNode.Previous = _tail;
                    _tail = newNode;
                }
            }

            public void PrintForward()
            {
                Console.WriteLine("\nСписок в прямом порядке:");
                Node current = _head;
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            public void PrintBackward()
            {
                Console.WriteLine("Список в обратном порядке:");
                Node current = _tail;
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Previous;
                }
                Console.WriteLine();
            }

            public void TaskLoop()
            {
                Console.WriteLine("=== Задание 3: Двусвязный список ===");
                Console.WriteLine("Для выхода введите '--exit'");
                Console.WriteLine("Введите от 3 до 6 элементов для создания списка:");

                int count = 0;

                while (true)
                {
                    if (count < 3)
                    {
                        Console.Write($"Введите элемент {count + 1}: ");
                    }
                    else if (count < 6)
                    {
                        Console.Write($"Введите элемент {count + 1} (или '--exit' для завершения): ");
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимум элементов (6).");
                        break;
                    }

                    string input = Console.ReadLine();

                    if (input == "--exit")
                    {
                        if (count < 3)
                        {
                            Console.WriteLine("Необходимо ввести минимум 3 элемента!");
                            continue;
                        }
                        break;
                    }

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        Add(input);
                        count++;
                    }

                    if (count == 6) break;
                }

                if (count >= 3)
                {
                    PrintForward();
                    PrintBackward();
                }

                Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задание для выполнения:");
                Console.WriteLine("1 - Работа со списком строк");
                Console.WriteLine("2 - Словарь студентов и оценок");
                Console.WriteLine("3 - Двусвязный список");
                Console.WriteLine("0 - Выход из программы");
                Console.Write("Введите номер задания: ");

                if (!int.TryParse(Console.ReadLine(), out int task))
                {
                    Console.WriteLine("Ошибка ввода! Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    continue;
                }

                if (task == 0)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                switch (task)
                {
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
                        Console.WriteLine("Неверный номер задания! Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
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
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}