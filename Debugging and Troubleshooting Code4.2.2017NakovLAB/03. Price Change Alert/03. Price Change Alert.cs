using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        double border = double.Parse(Console.ReadLine());


        double last = double.Parse(Console.ReadLine());

        for (int row = 0; row < n - 1; row++)
        {
            double newNumber = double.Parse(Console.ReadLine());
            double diff = percent(last, newNumber); bool isSignificantDifference = ifDIff(diff, border);



            string message = Get(newNumber, last, diff, isSignificantDifference);
            Console.WriteLine(message);

            last = newNumber;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double difference, bool trueOrFalse)

    {
        string stringFormat = string.Empty;
        if (difference == 0)
        {
            stringFormat = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!trueOrFalse)
        {
            stringFormat = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (trueOrFalse && (difference > 0))
        {
            stringFormat = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (trueOrFalse && (difference < 0))
            stringFormat = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return stringFormat;
    }
    private static bool ifDIff(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double percent(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
