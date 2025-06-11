// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create an array of objects with clones
            ComplexNumber[] numbers = new ComplexNumber[6];
            numbers[0] = new ComplexNumber("3i4");
            numbers[1] = new ComplexNumber("-2i5");
            numbers[2] = new ComplexNumber("1i-1");

            // Fill second half with clones
            for (int i = 3; i < 6; i++)
            {
                numbers[i] = (ComplexNumber)numbers[i - 3].Clone();
            }

            // Display original array
            Console.WriteLine("Original array:");
            DisplayArray(numbers);

            // Sort the array
            Array.Sort(numbers);
            Console.WriteLine("\nSorted array:");
            DisplayArray(numbers);

            // Demonstrate ComplexCollection
            ComplexCollection collection = new ComplexCollection();
            foreach (var num in numbers)
            {
                collection.AddToCollection(num);
            }

            Console.WriteLine("\nCollection contents:");
            collection.DisplayAll();

            Console.WriteLine("\nDisplay specific elements:");
            collection.DisplayElement(2);
            collection.DisplayGenericElement(3);

            // Demonstrate operations
            Console.WriteLine("\nOperations demonstration:");
            ComplexNumber a = new ComplexNumber("2i3");
            ComplexNumber b = new ComplexNumber("1i4");

            Console.WriteLine($"a + b = {a.Add(b)}");
            Console.WriteLine($"a * b = {a.Multiply(b)}");
            Console.WriteLine($"a == b? {a.Equals(b)}");

            // Menu demonstration
            Console.WriteLine("\nMenu demonstration:");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Add complex number to collection");
                Console.WriteLine("2. Display all numbers");
                Console.WriteLine("3. Display specific element");
                Console.WriteLine("4. Perform addition");
                Console.WriteLine("5. Perform multiplication");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter complex number (format: realiimaginary): ");
                        string input = Console.ReadLine();
                        try
                        {
                            ComplexNumber num = new ComplexNumber(input);
                            collection.AddToCollection(num);
                            Console.WriteLine("Number added successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "2":
                        collection.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Enter index: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            try
                            {
                                collection.DisplayElement(index);
                                collection.DisplayGenericElement(index);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter first number (format: realiimaginary): ");
                        string input1 = Console.ReadLine();
                        Console.Write("Enter second number (format: realiimaginary): ");
                        string input2 = Console.ReadLine();
                        try
                        {
                            ComplexNumber num1 = new ComplexNumber(input1);
                            ComplexNumber num2 = new ComplexNumber(input2);
                            Console.WriteLine($"Result: {num1.Add(num2)}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "5":
                        Console.Write("Enter first number (format: realiimaginary): ");
                        input1 = Console.ReadLine();
                        Console.Write("Enter second number (format: realiimaginary): ");
                        input2 = Console.ReadLine();
                        try
                        {
                            ComplexNumber num1 = new ComplexNumber(input1);
                            ComplexNumber num2 = new ComplexNumber(input2);
                            Console.WriteLine($"Result: {num1.Multiply(num2)}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void DisplayArray(ComplexNumber[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}]: {array[i]}");
        }
    }
}
