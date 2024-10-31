public class Program
{
    public static void Main(string[] args)
    {
        //Write1ThroughN_While
        ThroughN_While(-1);
        ThroughN_While(5);
        ThroughN_While(0);

        //Write1ThroughN_For
        ThroughN_For(-1);
        ThroughN_For(5);
        ThroughN_For(0);

        //WriteNThrough1_While
        Through1_While(-1);
        Through1_While(5);
        Through1_While(0);

        //WriteNThrough1_For
        Through1_for(-1);
        Through1_for(5);
        Through1_for(0);

        //eEvensThrough100
        EvensThrough100(100);

        //FindSum
        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        //FindSumOfEvenNumbers
        SumOfEvenNumbers(10);
        SumOfEvenNumbers(-5);
        SumOfEvenNumbers(2);
        SumOfEvenNumbers(0);
        SumOfEvenNumbers(1);
        SumOfEvenNumbers(25);
        SumOfEvenNumbers(-25);

        //FindSumOfOddNumbers
        SumOfOddNumbers(10);
        SumOfOddNumbers(-5);
        SumOfOddNumbers(1);
        SumOfOddNumbers(2);
        SumOfOddNumbers(25);
        SumOfOddNumbers(-25);

        //OutputRightTriangle
        RightTriangle(4);
        RightTriangle(6);
        RightTriangle(-4);
        RightTriangle(-6);
        RightTriangle(0);

    }

    //Write1ThroughN_While
    public static void ThroughN_While(int x)
    {
        int count = 1;
        if (x < 1)
        {
            Console.WriteLine(x + " is out of range");
        }
        else if (x > 0)
        {
            while (count <= x)
            {
                Console.Write(" " + count);
                count++;
            }
            Console.WriteLine();
        }
    }

    //Write1ThroughN_For
    public static void ThroughN_For(int x)
    {
        if (x > 0)
            for (int i = 1; i <= x; i++)
            {
                Console.Write(" " + i);
            }
        else
        {
            Console.WriteLine();
            Console.WriteLine(x + " is out of range");
        }
    }

    //WriteNThrough1_While
    public static void Through1_While(int x)
    {
        int count = x;
        if (x < 1)
        {
            Console.WriteLine(x + " is out of range");
        }
        else if (x > 0)
        {
            while (count > 0)
            {
                Console.Write(" " + count);
                count--;
            }
            Console.WriteLine();
        }
    }

    //WriteNThrough1_For
    public static void Through1_for(int x)
    {
        if (x > 0)
            for (int i = x; i > 0; i--)
            {
                Console.Write(" " + i);
            }
        else
        {
            Console.WriteLine();
            Console.WriteLine(x + " is out of range");
        }
    }

    //eEvensThrough100
    public static void EvensThrough100(int x)
    {
        for (int i = 1; i < x; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine();
                continue;
            }
            Console.Write(i);
        }
    }

    //FindSum
    public static void FindSum(int x)
    {
        int sum = 0;
        if (x > 1)
            for (int i = 0; i <= x; i++)
            {
                sum = sum + i;
            }
        else
        {
            for (int i = x; i <= 1; i++)
                if (i % 1 == -0 || i % 1 == 0)
                {
                    sum = sum + i;
                }
        }
        Console.WriteLine(sum);
    }

    //FindSumOfEvenNumbers
    public static void SumOfEvenNumbers(int x)
    {
        int sum = 0;
        if (x > 1)
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
        else
        {
            for (int i = x; i <= 1; i++)
                if (i % 2 == -0 || i % 2 == 0)
                {
                    sum = sum + i;
                }
        }
        Console.WriteLine(sum);
    }

    //FindSumOfOddNumbers
    public static void SumOfOddNumbers(int x)
    {
        int sum = 0;
        if (x > 1)
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
            }
        else
        {
            for (int i = x; i <= 1; i++)
                if (i % 2 == -1 || i % 2 == 1)
                {
                    sum = sum + i;
                }
        }
        Console.WriteLine(sum);
    }

    //OutputRightTriangle
    public static void RightTriangle(int x)
    {
        if (x == 0)
        {
            Console.WriteLine("0 is out of range.");
        }
        else if (x > 1)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = x; i < 0; i++)
            {
                for (int j = i; j < 0; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
