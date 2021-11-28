namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки строк.
    /// Исходные условия: Метод принимает исходный массив строк, и возвращает результат обработки
    /// </summary>
    public class HomeWork2
    {
        /// <summary>
        /// Найти самую короткую и самую длинную строки. Вернуть найденные строки и их длину.
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Самая длинная строка, ее длина, самая маленькая трока и ее длина. Пример вывода return ("max1", 4, "min", 3);</returns>
        public static (string max, int lengthMax, string min, int lengthMin) Variant1(string[] temp)
        {
            int LengthMax = 0;
            int LengthMin = int.MaxValue;
            string max = "MaxString";
            string min = "MinString";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Length <= LengthMin)
                {
                    LengthMin = temp[i].Length;
                    min = temp[i];
                }
                if (temp[i].Length >= LengthMax)
                {
                    LengthMax = temp[i].Length;
                    max = temp[i];
                }
            }
            return (max, LengthMax, min, LengthMin);
        }

        /// <summary>
        /// Найти слово, состоящее только из цифр. Если таких слов больше одного, найти второе из них
        /// </summary>
        /// <param name="temp">Исходный массив строк</param>
        /// <returns>Слово состоящее только из цифр.</returns>
        public static string Variant2(string[] temp)
        {
            bool flag = false;
            string number = null;
            foreach (string s in temp)
            {
                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    number = s;
                }
            }
            return number;
        }
    }
}