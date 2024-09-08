using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH TIM SO LON NHAT VA NHO NHAT TU 5 SO");

            int[] numbers = new int[5];

            // Nhập 5 số từ bàn phím
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhap so thu {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Tìm số lớn nhất và nhỏ nhất
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // In ra kết quả
            Console.WriteLine("So lon nhat la: " + max);
            Console.WriteLine("So nho nhat la: " + min);

        }
    }// static: phương thức
}
