using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// Реализовать в классе метод, который бы возвращал список всех букв, использованных в переданном тексте textString. Особенности списка, который формируется на выходе метода:
        /// список не должен содержать повторяющихся элементов;
        /// буквы в списке должны быть приведены к верхнему регистру;
        /// список должен быть отсортирован в алфавитном порядке(по возрастанию).
        /// </summary>
        /// <param name="textString">В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. Текст может включать в себя произвольные символы.</param>
        /// <returns>Возвращается список символов List<char>. Список должен содержать буквы искомого текста и удовлетворять требованиям, указанным выше.</returns>
        public static List<char> GetLetters(string textString)
        {
            List<char> list = new List<char>();
            string let = new string(textString.Where(Char.IsLetter).ToArray());
            char[] charArray = let.ToCharArray();

            foreach (char c in charArray)
            {
                list.Add(char.ToUpper(c));
            }
            List<char> result =list.Distinct().ToList();
            result.Sort();

            return result   ;
        }
    }
}
