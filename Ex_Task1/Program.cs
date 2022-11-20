using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            do
            {
                Console.WriteLine("Для выхода наберите EXIT");

                Console.WriteLine("Введите строку: ");
                string str = Console.ReadLine();
                if (str == "EXIT")
                {
                    f = true;
                    break;
                }
                Console.WriteLine(Check(str));
            }
            while (f == false);

            Console.ReadKey();
        }
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                {'(',')' },
                {'[',']' },
                {'{','}' },
            };
            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(dic[c]);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }

            }
            if (stack.Count == 0)
                return true;
            else
                return false;
            
        }
    }
}

