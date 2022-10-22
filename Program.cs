internal class Program
{
    /*
     *  Одноклеточная амеба каждые 3 часа делится на 2 клетки.
     *  Определить, сколько клеток будет через 3, 6, 9, …, 24 часа,
     *  если первоначально была одна амеба.
     */
    public static void AmoebaCount(int hours)
    {
        int amoeba = 1;
        for (int hoursCounter = 1; hoursCounter <= hours; hoursCounter++)
        {
            if (hoursCounter % 3 == 0)
            {
                Console.WriteLine($"{hoursCounter} hourse late: we have {amoeba = amoeba * 2} amoebas.");
            }
        }
    }
    private static void Main(string[] args)
    {
        ERROR1:
        Console.Write("Hello, there! Enter number of hours for 1 amoeba devide: ");
        try
        {            
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine();
            AmoebaCount(hours);
        }
        catch (Exception)
        {
            Console.WriteLine("You must enter integer value! Try again.");
            goto ERROR1;
            throw;
        }
    }
}