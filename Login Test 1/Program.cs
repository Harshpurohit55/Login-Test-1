using System;

using System;

class Program
{
    static void Main()
    {
       
        Dictionary<string, string> credentials = new Dictionary<string, string>();
        credentials.Add("Admin", "admin@123");
        credentials.Add("Harsh", "hp@123");

        Console.WriteLine("Login System");

        
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        
        if (credentials.ContainsKey(username) && credentials[username] == password)
        {
            Console.WriteLine("Login successful!");

           
            StringOperations stringOperations = new StringOperations();
            MathOperations mathOperations = new MathOperations();

            
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. String");
            Console.WriteLine("2. Math");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    Console.WriteLine("String operations selected.");
                    stringOperations.PerformStringOperations();
                    break;
                case "2":
                  
                    Console.WriteLine("Math operations selected.");
                    mathOperations.PerformMathOperations();
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid username or password. Press Enter to try again.");
            Console.ReadLine();
            Main();
        }

        Console.ReadLine();
    }
}

class StringOperations
{
    public void PerformStringOperations()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        int length = text.Length;
        Console.WriteLine("Length: " + length);

       
        string upperCase = text.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);

        
        string lowerCase = text.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);

       


        
        string[] words = text.Split(' ');
        Console.WriteLine("Words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

class MathOperations
{
    public void PerformMathOperations()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


        int sum = num1 + num2;
        Console.WriteLine("Sum: " + sum);

        
        int difference = num1 - num2;
        Console.WriteLine("Difference: " + difference);

        
        int product = num1 * num2;
        Console.WriteLine("Product: " + product);

        
        int quotient = num1 / num2;
        Console.WriteLine("Quotient: " + quotient);

        
        int remainder = num1 % num2;
        Console.WriteLine("Remainder: " + remainder);
    }
}
