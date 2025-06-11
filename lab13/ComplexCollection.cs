using System;
using System.Collections;
using System.Collections.Generic;

public class ComplexCollection
{
    private Stack stackNonGeneric = new Stack();
    private Stack<ComplexNumber> stackGeneric = new Stack<ComplexNumber>();

    // Метод, що додає число в обидва стеки
    public void AddToCollection(ComplexNumber c)
    {
        stackNonGeneric.Push(c);
        stackGeneric.Push(c);
    }

    // Витягуємо елемент із негенеричного стеку
    public ComplexNumber PopNonGeneric()
    {
        return (ComplexNumber)stackNonGeneric.Pop();
    }

    // Витягуємо елемент із генеричного стеку
    public ComplexNumber PopGeneric()
    {
        return stackGeneric.Pop();
    }

    // Відображення негенеричного стеку
    public void DisplayStackNonGeneric()
    {
        Console.WriteLine("Non-Generic Stack:");
        foreach (ComplexNumber c in stackNonGeneric)
        {
            Console.WriteLine(c);
        }
    }

    // Відображення генеричного стеку
    public void DisplayStackGeneric()
    {
        Console.WriteLine("Generic Stack:");
        foreach (var c in stackGeneric)
        {
            Console.WriteLine(c);
        }
    }

    // Відображення всіх елементів — обидва стеку
    public void DisplayAll()
    {
        DisplayStackNonGeneric();
        Console.WriteLine();
        DisplayStackGeneric();
    }

    // Повертає елемент із негенеричного стеку за індексом
    public ComplexNumber GetElementFromNonGeneric(int index)
    {
        if (index < 0 || index >= stackNonGeneric.Count)
            throw new IndexOutOfRangeException();

        ComplexNumber[] arr = new ComplexNumber[stackNonGeneric.Count];
        stackNonGeneric.CopyTo(arr, 0);
        return arr[index];
    }

    // Повертає елемент із генеричного стеку за індексом (враховуючи порядок ToArray)
    public ComplexNumber GetElementFromGeneric(int index)
    {
        if (index < 0 || index >= stackGeneric.Count)
            throw new IndexOutOfRangeException();

        ComplexNumber[] arr = stackGeneric.ToArray();
        return arr[stackGeneric.Count - 1 - index];
    }

    // Відображення елемента негенеричного стеку за індексом
    public void DisplayElement(int index)
    {
        ComplexNumber c = GetElementFromNonGeneric(index);
        Console.WriteLine($"NonGeneric[{index}] = {c}");
    }

    // Відображення елемента генеричного стеку за індексом
    public void DisplayGenericElement(int index)
    {
        ComplexNumber c = GetElementFromGeneric(index);
        Console.WriteLine($"Generic[{index}] = {c}");
    }
}

