using System;
using System.Collections.Generic;
using System.Text;

namespace VishanovA_40_GUNPC
{
   
        public class DoublyLinkedListTask
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
            private int _count;

            public DoublyLinkedListTask()
            {
                _head = null;
                _tail = null;
                _count = 0;
            }

            public void TaskLoop()
            {
                Console.WriteLine("\n=== Задание 3: Двусвязный список ===");
                Console.WriteLine("Для выхода введите '--exit'");
                Console.WriteLine("Создайте список из 3 до 6 элементов.");

                _head = null;
                _tail = null;
                _count = 0;

                int elementCount = 0;

                while (true)
                {
                    if (elementCount < 3)
                    {
                        Console.Write($"Введите элемент {elementCount + 1} (минимум 3 элемента): ");
                    }
                    else if (elementCount < 6)
                    {
                        Console.Write($"Введите элемент {elementCount + 1} (или '--done' для завершения, максимум 6): ");
                    }
                    else
                    {
                        Console.WriteLine("Достигнут максимум 6 элементов.");
                        break;
                    }

                    string input = Console.ReadLine() ?? "";

                    if (input.ToLower() == "--exit")
                    {
                        Console.WriteLine("Выход из задания 3.");
                        return;
                    }

                    if (elementCount >= 3 && input.ToLower() == "--done")
                    {
                        break;
                    }

                    AddToEnd(input);
                    elementCount++;

                    if (elementCount >= 6)
                    {
                        Console.WriteLine("Достигнут максимум 6 элементов.");
                        break;
                    }
                }

                Console.WriteLine("\nСписок создан!");

                while (true)
                {
                    Console.WriteLine("\nМеню:");
                    Console.WriteLine("1. Вывести список в прямом порядке");
                    Console.WriteLine("2. Вывести список в обратном порядке");
                    Console.WriteLine("3. Добавить новый элемент");
                    Console.WriteLine("4. Выход");
                    Console.Write("Выберите действие: ");

                    string choice = Console.ReadLine() ?? "";

                    if (choice == "1")
                    {
                        Console.WriteLine("\nСписок в прямом порядке:");
                        PrintForward();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\nСписок в обратном порядке:");
                        PrintBackward();
                    }
                    else if (choice == "3")
                    {
                        if (_count >= 6)
                        {
                            Console.WriteLine("Достигнут максимум 6 элементов.");
                            continue;
                        }

                        Console.Write("Введите новый элемент: ");
                        string newElement = Console.ReadLine() ?? "";

                        if (newElement.ToLower() == "--exit")
                        {
                            Console.WriteLine("Выход из задания 3.");
                            break;
                        }

                        AddToEnd(newElement);
                        Console.WriteLine($"Элемент '{newElement}' добавлен.");
                    }
                    else if (choice == "4" || choice.ToLower() == "--exit")
                    {
                        Console.WriteLine("Выход из задания 3.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                    }
                }
            }

            private void AddToEnd(string data)
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

                _count++;
            }

            private void PrintForward()
            {
                if (_head == null)
                {
                    Console.WriteLine("Список пуст.");
                    return;
                }

                Node current = _head;
                int index = 0;
                while (current != null)
                {
                    Console.WriteLine($"[{index}] {current.Data}");
                    current = current.Next;
                    index++;
                }
            }

            private void PrintBackward()
            {
                if (_tail == null)
                {
                    Console.WriteLine("Список пуст.");
                    return;
                }

                Node current = _tail;
                int index = _count - 1;
                while (current != null)
                {
                    Console.WriteLine($"[{index}] {current.Data}");
                    current = current.Previous;
                    index--;
                }
            }
        }
    }

