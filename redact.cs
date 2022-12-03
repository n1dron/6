using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss
{
    internal class redact
    {
        public string[] text(string[] txt)
        {
            Console.Clear();
            int x = 0;
            string line;
            string line1 = "";
            Console.WriteLine("Введите тип данных: ");
            foreach (string s in txt)
            {
                x++;
                Console.WriteLine(s);
            }
            int num = 2;
            int num2 = 0;
            Console.SetCursorPosition(0, num);
            ConsoleKeyInfo cl = Console.ReadKey();
            while (true)
            {
                if (cl.Key == ConsoleKey.UpArrow)
                {
                    num--;
                    if (num <= 1)
                    {
                        num = 5;
                    }
                }
                else if (cl.Key == ConsoleKey.DownArrow)
                {
                    num++;

                    if (num >= 6)
                    {
                        num = 2;
                    }
                }
                else if (cl.Key == ConsoleKey.LeftArrow)
                {
                    num2--;
                }
                else if (cl.Key == ConsoleKey.RightArrow)
                {
                    num2++;
                }
                else if (cl.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    line = txt[num - 2];
                    txt[num - 2] = "";
                    for (int i = 0; i < num2; i++)
                    {
                        if (i == line.Length)
                        {
                            break;
                        }
                        line1 = line1 + line[i];
                    }
                    if (cl.Key != ConsoleKey.Backspace)
                    {
                        line1 = line1 + Convert.ToString(cl.KeyChar);
                    }
                    else if (cl.Key == ConsoleKey.Backspace)
                    {
                        line1 = line1 + "";
                    }
                    for (int j = num2 + 1; j < line.Length; j++)
                    {
                        if (num2 > line.Length)
                        {
                            break;
                        }
                        else
                        {
                            line1 = line1 + line[j];
                        }
                    }
                    txt[num - 2] = line1 + " ";
                    line1 = "";
                    if (cl.Key == ConsoleKey.Backspace)
                    {
                        num2--;
                        if (num2 < 0)
                        {
                            num2 = 0;
                        }
                    }
                    else
                    {
                        num2++;
                    }
                }
                Console.Clear();
                Console.WriteLine("После редактирования нажмите Enter, чтобы сохранить: ");
                foreach (string ele in txt)
                {
                    Console.WriteLine(ele);
                }
                Console.SetCursorPosition(num2, num);
                cl = Console.ReadKey();
            }
            return txt;
        }
    }
}
