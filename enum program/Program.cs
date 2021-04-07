using System;
using System.Linq;
using System.Collections.Generic;

public class Example
{
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    public static void Main()
    {
        List<Days> days = Enum.GetValues(typeof(Days))
                            .Cast<Days>()
                            .ToList();

        Console.WriteLine(String.Join(Environment.NewLine, days));
    }
}
