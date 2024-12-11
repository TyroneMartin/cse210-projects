# Basic Calculator Application

**Author:** Tyrone Martin, students in CSE 210.

## Overview


This project was created as part of my final project assessment. I had developed a basic calculator application to demonstrate the principles taught within this course for object-oriented programming, in C#. These principles include, but are not limited to, inheritance, encapsulation, and polymorphism. Below you find the UML design that was used for this project, along with other startup details and information that are relevant to project.

![ULM Diagram](../FinalProject/basic_calculator_uml_design.png)

## Features

This project is a simple calculator application that performs basic arithmetic operations. It allows users to enter numbers and select an operation, and then the calculator displays the result.


## Project Structure

The project is structured as follows:

- `Program.cs`: The main entry point of the application.
- `Operation`: Contains the `abstract base class Operation`, which performs the arithmetic operations.
- `OperationManager.cs`: Contains the `OperationManager` class, which manages the available operations.
- `Calculator.cs`: Contains the `Calculator` class, which performs the actual arithmetic operations.
- `CalculationRecord.cs`: Contains the `CalculationRecord` class, which stores the calculation history.
- `ModuloValidator.cs`: Contains the `ModuloValidator` class, which validates the input for the modulo operation.
- `AdditionOperation.cs`: Contains the `AdditionOperation` subclass, which performs the addition operation.
- `SubtractionOperation.cs`: Contains the `SubtractionOperation` subclass, which performs the subtraction operation.
- `MultiplicationOperation.cs`: Contains the `MultiplicationOperation` subclass, which performs the multiplication operation.
- `DivisionOperation.cs`: Contains the `DivisionOperation` subclass, which performs the division operation.
- `ModuloOperation.cs`: Contains the `ModuloOperation` subclass, which performs the modulo operation.






## How to Use

1. Open the project in your preferred IDE (e.g., Visual Studio Code).
2. Download the .NET SDK if you haven't already done so.
3. Download this repository.
4. Navigate to the project folder.
5. Open the project in Visual Studio Code.
6. Import the project into Visual Studio Code.
7. Open terminal and navigate to the project folder.
7. Build the project by running the `dotnet build` command. [***Additional help below***](#additional-help)
8. Run the project by running the `dotnet run` command.
9. Run the program by pressing F5 or selecting "Debug" from the menu.
10. The calculator will display a welcome message. Select an option from the menu.
10. Enter the first number, select an operation, and enter the second number.
11. The calculator will display the result.
12. Return to the main menu to perform additional operations.
13. Select "Quit" to exit the program.

## Additional help for installation

### Compiling on Your Local Machine
## Additional Help
Follow these steps to compile the project using the .NET SDK:

1. **Install .NET SDK (if not already installed):**
   - Download and install the .NET SDK from the official website: [Download .NET SDK](https://dotnet.microsoft.com/download).

2. **Navigate to the Project Folder:**
   Open your terminal or command prompt and navigate to the folder containing your project files (e.g., `Learning05`). 

   ```bash
   cd path/to/your/project/Learning05
   ```

3. **Compile the Project:**
   Use the following command to build the project:

   ```bash
   dotnet build OR dotnet new console

   ```

4. **Run the Program:**
   If the build is successful, you can run the program with:

   ```bash
   dotnet run
   ```


## System Requirements

- **Operating System:** Windows, macOS, or Linux
- **IDE:** Visual Studio Code
- **.NET SDK:** [Download .NET SDK](https://dotnet.microsoft.com/download)


## Future Improvements

- Add more features  
- Add more unit tests  
- Add more error handling  
- Add more validation  
- Add more security  
- Add more performance optimization  
- Add more accessibility 














