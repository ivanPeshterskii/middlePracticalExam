using System;

class Program
{
    static void Main()
    {
        //Четем вх. данни
        double budget = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double priceFlour = double.Parse(Console.ReadLine());
        double priceEgg = double.Parse(Console.ReadLine());
        double priceApron = double.Parse(Console.ReadLine());

        //Изчисляваме 
        int freeFlours = (students / 5);
        double finalFlour = (students - freeFlours) * priceFlour;
        double finalEggs = students * 10 * priceEgg;
        int aprons = (int)Math.Ceiling(students * 1.2);
        double finalAprons = aprons * priceApron;

        //Обща цена
        double total = finalFlour + finalEggs + finalAprons;

        //Проверки+изход
        if (total <= budget)
        {
            Console.WriteLine($"Items purchased for {total:f2}$.");
        }
        else
        {
            Console.WriteLine($"{Math.Abs(total-budget):f2}$ more needed.");
        }
    }
}
