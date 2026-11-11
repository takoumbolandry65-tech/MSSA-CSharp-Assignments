int User = 0;

while (User != 5)
{
    Console.WriteLine("\n1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

    Console.Write("\nEnter your choice: ");
    User = int.Parse(Console.ReadLine());

    if (User == 5)
    {
        Console.WriteLine("Exiting calculator");
        break;
    }

    if (User < 1 || User > 5)
    {
        Console.WriteLine("Invalid choice. Try again.");
        continue;
    }

    Console.Write("Enter first number: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    double num2 = double.Parse(Console.ReadLine());

    switch (User)
    {
        case 1:
            Console.WriteLine("You selected addition");
            Console.WriteLine("Result: " + (num1 + num2));
            break;

        case 2:
            Console.WriteLine("You selected subtraction");
            Console.WriteLine("Result: " + (num1 - num2));
            break;

        case 3:
            Console.WriteLine("You selected multiplication");
            Console.WriteLine("Result: " + (num1 * num2));
            break;

        case 4:
            Console.WriteLine("You selected division");

            if (num2 != 0)
            {
                Console.WriteLine("Result: " + (num1 / num2));
            } 
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            break;
    }
}