namespace lab1_Gorishniy_Yashin_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");
            //int n = 10;
            //Console.WriteLine(n);
            //Console.Write("имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Введите имя :{name}");
            //Console.Write("возвраст:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Введите возраст :{age}");

            //int number = 250;
            //long number2 = (byte)(number + 10);
            //Console.WriteLine(number2);

            //bool alive = true;
            //bool isdead = false;

            //char symbol = '2';

            //double yNumber = 3.4;
            //float inumber = 3.4f;
            //decimal kNumber = 3.4m;

            //object lNumber = 3.4;

            //var gNumber = 10;

            //самостоятельные задания 1 лаб

            //1 
            string z1 = "Форсаж";
            int z2 = 3;
            double z3 = Math.PI;
            char z4 = 'G';

            Console.WriteLine($"Любимое кино: {z1}");
            Console.WriteLine($"Любимая цифра: {z2}");
            Console.WriteLine($"Число Пи: {z3:F6}");
            Console.WriteLine($"Любимая буква: {z4}");

            //2
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");

            //3
            Console.WriteLine("Hello There");

            //4
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int ms = int.Parse(Console.ReadLine());

            int total = (m + s + k + ms) * 3;

            Console.WriteLine(total);

            //5
            Console.WriteLine("a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double b = double.Parse(Console.ReadLine());
            double c = 3 * Math.Pow(a + b, 3) + Math.Pow(275 * b, 2) - 127 * a - 41;
            Console.WriteLine(c);

            //6
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"Сейчас тебе {age} лет.");
            Console.WriteLine($"В следующем году тебе будет {age + 1}.");

            //7
            string name = "Andrey and Diman";
            int age = 18;
            string city = "Volzhskiy";
            Console.WriteLine($"{name}");
            Console.WriteLine($" тебе {age}");
            Console.WriteLine($"лет и ты живешь в городе {city}");

            //8
            Console.Write("Введите темп в градусах Цельсия:");
            double cel = double.Parse(Console.ReadLine());
            double fah = (cel * 9 / 5) + 32;
            Console.WriteLine($"Темп: {fah:F2}°F");
        }
    }
