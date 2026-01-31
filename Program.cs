Console.WriteLine("\nGeometry Guru lohihasiga xush kelibsiz!");
Console.WriteLine("Dasturni ishga tushirishni xohlaysizmi?\n");
Console.WriteLine("Ishga tushirish uchun 1 sonini kiriting:");
Console.Write("To'xtatish uchun istalgan son kiritng:\nJavobingiz:");
int userInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
while(userInput == 1)
{
    System.Console.WriteLine("Dastur ishga tushdi");
    Console.WriteLine("Quyidagi amallardan birini tanlang:");
    Console.WriteLine("1.To'g'ri to'rtburchakning yuzini hisoblash");
    Console.WriteLine("2.Kvadrat yuzini hisoblash");
    Console.Write("(tanlash:1/2)\nJavobingiz:");
    int userChoice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    /* 1.To‘g‘ri to‘rtburchak — Qarama-qarshi tomonlari teng va parallel
    To'g'ri to'rtburchakning yuzini hisoblash: S = a * b
    2.Kvadrat — hamma tomoni bir xil uzunlikda bo‘lgan to‘g‘ri to‘rtburchak.
    Kvadrat yuzini hisoblash: S = a * a     */
    switch (userChoice)
    {
        case 1:
            {
                Console.WriteLine("To'g'ri to'rtburchakning yuzini hisoblashni tanladingiz");
                Console.WriteLine("To'g'ri to'rtburchakning tomonlarini kiriting:");
                Console.Write("a=");
                decimal aTamon = Convert.ToDecimal(Console.ReadLine());
                Console.Write("b=");
                decimal bTamon = Convert.ToDecimal(Console.ReadLine());
                decimal resultS = aTamon * bTamon;
                Console.WriteLine("To'g'ri to'rtburchakning yuzasi:" + resultS + "\n");
                break;
            }
        

        case 2:
            {
                Console.WriteLine("Kvadrat yuzini hisoblashni tanladingiz");
                Console.Write("Kvadratning tomonini kiriting:");
                decimal kvadratTomoni = Convert.ToDecimal(Console.ReadLine());
                decimal resultS = kvadratTomoni * kvadratTomoni;
                Console.WriteLine("Kvadratning yuzasi:"+ resultS + "\n");
                break;
            }
        default:
        Console.WriteLine("Kechirasiz ikkita amaldan birini tanlashingiz kerak!\n");
        break;

    }
    Console.WriteLine("Dasturni qayta ishga tushirishni xohlaysizmi?\n");
    Console.WriteLine("Ishga tushirish uchun 1 sonini kiriting");
    Console.Write("To'xtatish uchun istalgan son kiritng\nJavobingiz:");
    userInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
}
Console.WriteLine("\nXayr salomat bo'ling\n");