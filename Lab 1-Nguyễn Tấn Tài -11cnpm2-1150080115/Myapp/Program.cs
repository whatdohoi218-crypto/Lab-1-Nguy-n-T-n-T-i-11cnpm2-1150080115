using System;
using System.IO;
using System.Linq;

namespace ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU 10 BÀI THỰC HÀNH ===");
                Console.WriteLine("1. Tính chu vi và diện tích hình chữ nhật");
                Console.WriteLine("2. Tìm số lớn hơn trong 2 số nguyên");
                Console.WriteLine("3. Tìm số lớn nhất trong 3 số nguyên");
                Console.WriteLine("4. Cho biết một tháng có bao nhiêu ngày");
                Console.WriteLine("5. Kiểm tra số chẵn/lẻ và âm/không âm");
                Console.WriteLine("6. Tính chu vi và diện tích hình chữ nhật (số thực)");
                Console.WriteLine("7. Kiểm tra tam giác, tính chu vi & diện tích");
                Console.WriteLine("8. Giải phương trình bậc 2");
                Console.WriteLine("9. Tính tổng các phần tử trong mảng");
                Console.WriteLine("10. Sắp xếp tăng dần mảng (Selection Sort) từ file input_array.txt");
                Console.WriteLine("0. Thoát");
                Console.Write("\nNhập lựa chọn: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 0) break;

                switch (choice)
                {
                    case 1: Bai1(); break;
                    case 2: Bai2(); break;
                    case 3: Bai3(); break;
                    case 4: Bai4(); break;
                    case 5: Bai5(); break;
                    case 6: Bai6(); break;
                    case 7: Bai7(); break;
                    case 8: Bai8(); break;
                    case 9: Bai9(); break;
                    case 10: Bai10(); break;
                    default: Console.WriteLine("Không có bài này!"); break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey();
            }
        }

        static void Bai1()
        {
            Console.WriteLine("=== Bài 1: Chu vi và diện tích hình chữ nhật ===");
            Console.Write("Nhập chiều dài a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double P = (a + b) * 2;
            double S = a * b;

            Console.WriteLine("Chu vi = " + P);
            Console.WriteLine("Diện tích = " + S);
        }

        static void Bai2()
        {
            Console.WriteLine("=== Bài 2: Tìm số lớn hơn trong 2 số nguyên ===");
            Console.Write("Nhập số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;
            Console.WriteLine("Số lớn hơn là: " + max);
        }

        static void Bai3()
        {
            Console.WriteLine("=== Bài 3: Tìm số lớn nhất trong 3 số nguyên ===");
            Console.Write("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("Số lớn nhất là: " + max);
        }

        static void Bai4()
        {
            Console.WriteLine("=== Bài 4: Cho biết một tháng có bao nhiêu ngày ===");
            Console.Write("Nhập năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine("Tháng có 31 ngày!");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("Tháng có 30 ngày!");
                    break;
                case 2:
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                        Console.WriteLine("Tháng có 29 ngày!");
                    else
                        Console.WriteLine("Tháng có 28 ngày!");
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ!");
                    break;
            }
        }

        static void Bai5()
        {
            Console.WriteLine("=== Bài 5: Kiểm tra số chẵn/lẻ và âm/không âm ===");
            Console.Write("Nhập số nguyên n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("n là số chẵn");
            else
                Console.WriteLine("n là số lẻ");

            if (n < 0)
                Console.WriteLine("n là số âm");
            else
                Console.WriteLine("n là số không âm");
        }

        static void Bai6()
        {
            Console.WriteLine("=== Bài 6: Chu vi & diện tích hình chữ nhật (số thực) ===");
            Console.Write("Nhập chiều dài: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Chu vi = " + (2 * (a + b)));
            Console.WriteLine("Diện tích = " + (a * b));
        }

        static void Bai7()
        {
            Console.WriteLine("=== Bài 7: Kiểm tra tam giác, tính chu vi & diện tích ===");
            Console.Write("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ba cạnh lập thành tam giác.");
                double P = a + b + c;
                double p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi = " + P);
                Console.WriteLine("Diện tích = " + S);
            }
            else
            {
                Console.WriteLine("Ba cạnh không lập thành tam giác!");
            }
        }

        static void Bai8()
        {
            Console.WriteLine("=== Bài 8: Giải phương trình bậc 2 ax^2 + bx + c = 0 ===");
            Console.Write("Nhập a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine(c == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm");
                else
                    Console.WriteLine("Nghiệm x = " + (-c / b));
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                else if (delta == 0)
                    Console.WriteLine("Phương trình có nghiệm kép x = " + (-b / (2 * a)));
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm: x1 = " + x1 + ", x2 = " + x2);
                }
            }
        }

        static void Bai9()
        {
            Console.WriteLine("=== Bài 9: Tính tổng các phần tử trong mảng ===");
            Console.Write("Nhập số phần tử n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = arr.Sum();
            Console.WriteLine("Tổng các phần tử = " + sum);
        }

        static void Bai10()
        {
            Console.WriteLine("=== Bài 10: Selection Sort từ file input_array.txt ===");

            if (!File.Exists("input_array.txt"))
            {
                Console.WriteLine("Không tìm thấy file input_array.txt");
                return;
            }

            string[] lines = File.ReadAllLines("input_array.txt");
            int[] arr = lines.SelectMany(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                             .Select(int.Parse)
                             .ToArray();

            // Selection Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.WriteLine("Mảng sau khi sắp xếp:");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
