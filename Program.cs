using System;

class Program
{
    static void Main(string[] args)
    {
        string contents = "";

        System.Console.WriteLine("Byrålådan...");

        while (true)
        {
            System.Console.WriteLine("Välj en låda: ");
            System.Console.WriteLine("[A] - översta lådan");
            System.Console.WriteLine("[B] - mittersta lådan");
            System.Console.WriteLine("[C] - nedersta lådan");
            System.Console.WriteLine("[Q] - Avsluta programmet");
            string input = Console.ReadLine();

            if (input.ToLower() == "q" || input.ToLower() == "inget")
            {
                Console.WriteLine("Stänger byrån...");
                Environment.Exit(0);
            }
            else if (input.ToLower() == "t" || input.ToLower() == "töm")
            {
                System.Console.WriteLine("Tömmer byrån på " + contents);
                contents = "";
            }
            else
            {
                if (contents.Length == 0)
                {
                    contents = input.Trim();
                }
                else
                {
                    contents = contents + " och " + input.Trim();
                }
            }

            Console.WriteLine($"Byrån innehåller nu {contents}");
        }
    }
}