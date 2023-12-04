//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class IntroToLINQ
{
    public static IEnumerable<int>? numQuery { get; private set; }

    static void Main(string[] args)
    {
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

       
    numQuery =  from num in
    numbers
    where
    (num % 2) == 0
    select num;
        // 3. Query execution.
        foreach
        (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
            Console.WriteLine("\n ");
        }
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
    }
}