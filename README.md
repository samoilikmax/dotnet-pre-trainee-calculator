# Dotnet Pre-Trainee Calculator

A simple, robust, and crash-resistant console calculator built with C# and .NET. This project was developed as a practical task to demonstrate basic programming concepts, input validation, and proper object-oriented application architecture.

## About
This application allows users to perform standard arithmetic operations directly from the command line. The core architecture separates the user interaction logic (UI/Console input) from the actual mathematical computations, which are encapsulated in a dedicated `Calculator` class.

## Features
- **Four Basic Arithmetic Operations:** 
  - Addition (`+`)
  - Subtraction (`-`)
  - Multiplication (`*`)
  - Division (`/`)
- **Robust Input Validation:** 
  - Prevents crashes when a user enters letters, symbols, or empty spaces instead of numbers.
  - Validates arithmetic signs to ensure only supported operators are accepted.
- **Safe Error Handling:** 
  - Explicitly handles division by zero errors without breaking the application execution flow.
- **Repeat Calculation Loop:** 
  - Allows the user to perform multiple operations continuously during a single session until they choose to exit.

## How to Run

### Prerequisites
Make sure you have the **.NET SDK** installed on your computer. You can verify it by running:
```bash
dotnet --version
```

### Steps to Run locally
1. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com
   ```
2. **Navigate to the project directory** where the `.csproj` file is located:
   ```bash
   cd dotnet-pre-trainee-calculator/Calculator
   ```
3. **Build and run the project** using the .NET CLI:
   ```bash
   dotnet run
   ```

## Example Application Flow
```text
=== Console Calculator ===
Enter the first number: 10
Chose an operation (+, -, *, /): *
Enter the second number: 5

Result: 10 * 5 = 50
Would you like to perform another calculation? (y/n)
y
```
