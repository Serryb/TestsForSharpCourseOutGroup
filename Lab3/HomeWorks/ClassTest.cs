using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }
        public override bool Equals(object? obj)
        {
            ClassTest test = (ClassTest?)obj;
            if (test != null)
            {
                return this.Name == test.Name && this.Age == test.Age;
            }
            else return false;
        }

        public int CompareTo(object? obj)
        {
            ClassTest test = (ClassTest?)obj;
            if (test != null)
            {
                if (this.Age > test.Age) return 1;
                else if (this.Age < test.Age) return -1;
                else return 0;
            }

            else throw new ArgumentException();
        }
    }
}