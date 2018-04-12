using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork__04_01
{
    public class Listt : Interface1
    {
        virtual public void Sortt(List<int> tabnumb)
        {
            Console.WriteLine("Сортировка по возрастанию:");
            tabnumb.Sort();
            foreach (int tabn in tabnumb)
            {
                Console.Write(tabn + ", ");
            }
            Console.WriteLine();
        }
        virtual public void Reverce(List<int> tabnumb)
        {
            Console.WriteLine("Сортировка по убыванию:");
            tabnumb.Reverse();
            foreach (int tabn in tabnumb)
            {
                Console.Write(tabn + ", ");
            }
            Console.WriteLine();
        }
        virtual public int Maxx(List<int> tabnumb)
        {
            Console.WriteLine("Максимальное значение в массиве:");
            int a = tabnumb.Max();
            Console.WriteLine(a);
            
            return a;
        }
        virtual public void Minn(List<int> tabnumb)
        {
            Console.WriteLine("Минимальное значение в массиве:");
            Console.WriteLine(tabnumb.Min());
        }
        virtual public void Indexx(List<int> tabnumb)
        {
            Console.WriteLine("Индекс члена массива:");
            tabnumb.Reverse();
            Console.WriteLine("Введите элемент массива: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write($"Индекс числа {a} : ");
            Console.WriteLine(tabnumb.BinarySearch(a));
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<int> tabnumb = new List<int>() { 3, 15, 9, 20, 112, 6, 339, 11, 77, 2, 4 };

                Listt list = new Listt();
                list.Sortt(tabnumb);
                list.Reverce(tabnumb);
                list.Maxx(tabnumb);
                list.Minn(tabnumb);
                list.Indexx(tabnumb);
            }
        }
    }
}
