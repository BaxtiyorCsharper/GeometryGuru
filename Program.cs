using System;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GeometryGuru app = new GeometryGuru();
                app.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Umumiy xatolik: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nDastur yakunlandi.");
            }
        }
    }

    class GeometryGuru
    {
        public void Start()
        {
            PrintInfo();
            string result = EnterProgram();
            Console.WriteLine(result);
        }

        private void PrintInfo()
        {
            Console.WriteLine("\nGeometry Guru loyihasiga xush kelibsiz!");
        }

        private string EnterProgram()
        {
            Console.WriteLine("Dasturni ishga tushirishni xohlaysizmi?");
            Console.WriteLine("Ishga tushirish uchun 1 ni kiriting.");
            Console.Write("To'xtatish uchun boshqa son kiriting:\nJavobingiz: ");

            int userInput = ReadInt();

            while (userInput == 1)
            {
                Console.WriteLine("\nDastur ishga tushdi.");
                Console.WriteLine("1. To'g'ri to'rtburchak yuzasi (S = a * b)");
                Console.WriteLine("2. Kvadrat yuzasi (S = a * a)");
                Console.Write("(tanlash:1/2)\nJavobingiz: ");

                int userChoice = ReadInt();
                Console.WriteLine();

                switch (userChoice)
                {
                    case 1:
                        CalculateRectangle();
                        break;

                    case 2:
                        CalculateSquare();
                        break;

                    default:
                        Console.WriteLine("Faqat 1 yoki 2 tanlang!\n");
                        break;
                }

                Console.WriteLine("Dasturni qayta ishga tushirishni xohlaysizmi?");
                Console.Write("Ishga tushirish uchun 1 kiriting, to'xtatish uchun boshqa son:\nJavobingiz: ");
                userInput = ReadInt();
                Console.WriteLine();
            }

            return "Xayr, salomat bo'ling!";
        }

        private void CalculateRectangle()
        {
            try
            {
                Console.Write("a = ");
                decimal a = ReadDecimalPositive();

                Console.Write("b = ");
                decimal b = ReadDecimalPositive();

                decimal result = a * b;
                Console.WriteLine("To'g'ri to'rtburchak yuzasi: " + result + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xatolik: " + ex.Message);
            }
        }

        private void CalculateSquare()
        {
            try
            {
                Console.Write("Kvadrat tomoni = ");
                decimal side = ReadDecimalPositive();

                decimal result = side * side;
                Console.WriteLine("Kvadrat yuzasi: " + result + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xatolik: " + ex.Message);
            }
        }

        private int ReadInt()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Noto‘g‘ri format! Butun son kiriting: ");
                }
            }
        }

        private decimal ReadDecimalPositive()
        {
            while (true)
            {
                try
                {
                    decimal value = Convert.ToDecimal(Console.ReadLine());

                    if (value <= 0)
                    {
                        Console.Write("Musbat son kiriting: ");
                        continue;
                    }

                    return value;
                }
                catch (FormatException)
                {
                    Console.Write("Noto‘g‘ri format! Son kiriting: ");
                }
            }
        }
    }
}
