using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator!");

        while (true)
        {
            // قراءة الرقم الأول
            Console.Write("Enter the first number (or 'exit' to quit): ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit")
                break;

            double num1;
            if (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            // قراءة إشارة العملية
            Console.Write("Enter the operator (+, -, *, /): ");
            string operation = Console.ReadLine();

            // قراءة الرقم الثاني
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            double num2;
            if (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            double result = 0;
            bool validOperation = true;

            // تنفيذ العملية بناءً على الإشارة
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }

            Console.WriteLine(); // فصل بين العمليات
        }

        Console.WriteLine("Thank you for using the calculator!");
    }
}
