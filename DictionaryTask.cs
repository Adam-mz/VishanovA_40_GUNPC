using System;
using System.Collections.Generic;
using System.Text;

namespace VishanovA_40_GUNPC
{
    
        public class DictionaryTask
        {
            private readonly Dictionary<string, double> _studentGrades;

            public DictionaryTask()
            {
                _studentGrades = new Dictionary<string, double>
                {
                    ["Иван"] = 4.5,
                    ["Мария"] = 4.8,
                    ["Петр"] = 3.9,
                    ["Анна"] = 4.2
                };
            }

            public void TaskLoop()
            {
                Console.WriteLine("\n=== Задание 2: Словарь студентов и оценок ===");
                Console.WriteLine("Для выхода введите '--exit'");

                while (true)
                {
                    Console.WriteLine("\nТекущий список студентов:");
                    PrintDictionary();

                    // Добавление нового студента
                    Console.Write("\nВведите имя нового студента (или '--exit' для выхода): ");
                    string name = Console.ReadLine() ?? "";

                    if (name.ToLower() == "--exit")
                    {
                        Console.WriteLine("Выход из задания 2.");
                        break;
                    }

                    double grade;
                    while (true)
                    {
                        Console.Write($"Введите оценку для {name} (от 2 до 5): ");
                        string gradeInput = Console.ReadLine() ?? "";

                        if (!double.TryParse(gradeInput, out grade) || grade < 2 || grade > 5)
                        {
                            Console.WriteLine("Ошибка! Оценка должна быть числом от 2 до 5.");
                            continue;
                        }
                        break;
                    }

                    if (_studentGrades.ContainsKey(name))
                    {
                        _studentGrades[name] = grade;
                        Console.WriteLine($"Оценка студента {name} обновлена.");
                    }
                    else
                    {
                        _studentGrades[name] = grade;
                        Console.WriteLine($"Студент {name} добавлен с оценкой {grade}.");
                    }

                    // Поиск студента
                    Console.Write("\nВведите имя студента для поиска оценки: ");
                    string searchName = Console.ReadLine() ?? "";

                    if (searchName.ToLower() == "--exit")
                    {
                        Console.WriteLine("Выход из задания 2.");
                        break;
                    }

                    if (_studentGrades.TryGetValue(searchName, out double foundGrade))
                    {
                        Console.WriteLine($"Студент {searchName}: оценка {foundGrade:F1}");
                    }
                    else
                    {
                        Console.WriteLine($"Студент {searchName} не найден в словаре.");
                    }
                }
            }

            private void PrintDictionary()
            {
                foreach (var student in _studentGrades)
                {
                    Console.WriteLine($"{student.Key}: {student.Value:F1}");
                }
            }
        }
    }

