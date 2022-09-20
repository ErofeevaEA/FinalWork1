using System;

class Program
{
    static void Main(string[] args)

    {
         string[] massiv;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
            massiv = stroka.Split(' ');
            var result = new string[massiv .Length];
            var realSize = 0;
            foreach (var value in massiv )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);
    }
}