using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GridTraveller(50, 50));
    }

    public static long GridTraveller(int x, int y , Dictionary<Points , long> memo = null)
    {
        if (memo == null) memo = new Dictionary<Points, long>();


        if (x == 0 || y == 0)
        {
            return 0;
        }
        if(x == 1 && y == 1)
        {
            return 1;
        }

        Points current = new Points() { X = x, Y = y };

        var searchCase1 = memo.Where(x => x.Key.X == current.X && x.Key.Y == current.Y).ToList();
        var searchCase2 = memo.Where(x => x.Key.X == current.Y && x.Key.Y == current.X).ToList();

        if (searchCase1.Count > 0 )
        {
            return searchCase1[0].Value;
        }

        if( searchCase2.Count > 0)
        {
            return searchCase2[0].Value;

        }

        long value = GridTraveller(x - 1, y , memo) + GridTraveller(x, y - 1 , memo);

        memo.Add(current, value);

        return memo[current];
        

    }

    
}

public class Points
{
    public int X;
    public int Y;
}

