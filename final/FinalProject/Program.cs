using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("======================================");

        OperationManager operationManager = new OperationManager();
        Calculator calculator = new Calculator();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nMain Menu Options:");
            Console.WriteLine(" 1. Addition");
            Console.WriteLine(" 2. Subtraction");
            Console.WriteLine(" 3. Multiplication");
            Console.WriteLine(" 4. Division");
            Console.WriteLine(" 5. Modulo");
            Console.WriteLine(" 6. View Session History");
            Console.WriteLine(" 7. Clear Session History");
            Console.WriteLine(" 8. Quit");
            Console.Write("\nSelect an option: ");
            string userChoice = Console.ReadLine();

            double calculationResult = 0;
            switch (userChoice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.Write("~~ Note: Match format: 1st number eg. 2; then 2nd number eg. 3 ~~\n");
                    Console.Write("\n-> Enter the first number: ");
                    calculator.OperandA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("-> Enter the second number: ");
                    calculator.OperandB = Convert.ToDouble(Console.ReadLine());

                    // switch (userChoice)
                    // {
                    //     case "1":
                    //         operation = operationManager.AddOperation;
                    //         break;
                    //     case "2":
                    //         operation = operationManager.SubtractOperation;
                    //         break;
                    //     case "3":
                    //         operation = operationManager.MultiplyOperation;
                    //         break;
                    //     case "4":
                    //         operation = operationManager.DivideOperation;
                    //         break;
                    //     case "5":
                    //         operation = operationManager.ModuloOperation;
                    //         break;
                    //     default:
                    //         operation = null;
                    //         break;
                    // }


                    Operation operation = userChoice switch
                    {
                        "1" => operationManager.AddOperation,
                        "2" => operationManager.SubtractOperation,
                        "3" => operationManager.MultiplyOperation,
                        "4" => operationManager.DivideOperation,
                        "5" => operationManager.ModuloOperation,
                        _ => null
                    };

                    if (operation != null)
                    {
                        Console.Clear();
                        calculationResult = calculator.PerformOperation(operation, calculator.OperandA, calculator.OperandB);
                        Console.WriteLine($"\nThe {operation.GetName()} result is: [{calculator.OperandA} {operation.GetSign()} {calculator.OperandB}] = {calculationResult}");
                    }
                    break;

                case "6":
                    Console.Clear();
                    if (calculator.GetCalculationHistory().Count == 0)
                    {
                        Console.WriteLine("No calculation history to clear.\n");
                        Console.WriteLine("Please make a calculation first.");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("~~Calculation History~~\n");
                        foreach (var record in calculator.GetCalculationHistory())
                        {
                            Console.WriteLine($"Operation: {record.GetName()}, Result: {record.Result}");
                        }
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case "7":
                    Console.Clear();
                    calculator.ClearHistory();
                    Console.WriteLine("Calculation history cleared!");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;

                case "8":
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("~~ Thanks for using the Calculator! ~~");
                    Console.WriteLine("\nProgram was exited. Goodbye!\n");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again. Select a number between 1 and 8.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}