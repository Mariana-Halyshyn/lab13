using lab13;
using System;
using System.Text.RegularExpressions;

public class ComplexNumber : Strichka, IMyInterface
{
    public double Real { get; private set; }
    public double Imaginary { get; private set; }

    public ComplexNumber() : base()
    {
        Real = 0;
        Imaginary = 0;
    }

    public ComplexNumber(string s) : base(s)
    {
        if (!TryParseComplex(s, out double real, out double imag))
        {
            Real = 0;
            Imaginary = 0;
            str = "0+0i";
            length = (byte)(str.Length * sizeof(char));
        }
        else
        {
            Real = real;
            Imaginary = imag;
        }
    }

    private bool TryParseComplex(string s, out double real, out double imag)
    {
        real = 0; imag = 0;
        if (string.IsNullOrWhiteSpace(s))
            return false;

        // Очікуємо формат "a+bi" або "a-bi"
        var pattern = @"^\s*([+-]?\d+)([іi])([+-]?\d+)\s*$";
        var match = Regex.Match(s, pattern, RegexOptions.IgnoreCase);

        if (!match.Success)
            return false;

        // Парсимо дійсну і уявну частини
        if (!double.TryParse(match.Groups[1].Value, out real))
            return false;
        if (!double.TryParse(match.Groups[3].Value, out imag))
            return false;

        return true;
    }

    public bool Equals(ComplexNumber other)
    {
        if (other == null) return false;
        return Real == other.Real && Imaginary == other.Imaginary;
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber($"{Real + other.Real}і{Imaginary + other.Imaginary}");
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        double r = Real * other.Real - Imaginary * other.Imaginary;
        double i = Real * other.Imaginary + Imaginary * other.Real;
        return new ComplexNumber($"{r}і{i}");
    }

    public override int CompareTo(object obj)
    {
        if (obj == null) return 1;
        if (obj is ComplexNumber other)
        {
            double thisMag = Math.Sqrt(Real * Real + Imaginary * Imaginary);
            double otherMag = Math.Sqrt(other.Real * other.Real + other.Imaginary * other.Imaginary);
            return thisMag.CompareTo(otherMag);
        }
        throw new ArgumentException("Object is not a ComplexNumber");
    }

    public override object Clone()
    {
        return new ComplexNumber(this.str);
    }

    public override string ToString()
    {
        return $"{Real}і{Imaginary}";
    }
}
