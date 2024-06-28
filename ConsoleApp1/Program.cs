int T = 5;


for (int i = 1; i <= T; i++)
{
    
    for (int k = 1; k <= T - i; k++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

   
    for (int spc = 1; spc <= 10; spc++)
    {
        Console.Write(" ");
    }

   
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}


for (int i = T - 1; i >= 1; i--)
{
   
    for (int k = 1; k <= T - i; k++)
    {
        Console.Write(" ");
    }

   
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    
    for (int spc = 1; spc <= 10; spc++)
    {
        Console.Write(" ");
    }

    
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
