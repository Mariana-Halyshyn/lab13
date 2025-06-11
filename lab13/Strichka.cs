using lab13;
using System;

public class Strichka : IMyInterface
{
    protected string str;
    protected byte length;

    public Strichka()
    {
        str = string.Empty;
        length = 0;
    }

    public Strichka(string s)
    {
        str = s ?? string.Empty;
        length = (byte)(str.Length * sizeof(char)); // приблизно байти (UTF-16)
    }

    public Strichka(char c)
    {
        str = c.ToString();
        length = (byte)(sizeof(char));
    }

    public byte GetLength()
    {
        return length;
    }

    public void Clear()
    {
        str = string.Empty;
        length = 0;
    }

    public override string ToString()
    {
        return str;
    }

    public virtual int CompareTo(object obj)
    {
        if (obj == null) return 1;
        if (obj is Strichka other)
            return string.Compare(this.str, other.str, StringComparison.Ordinal);
        throw new ArgumentException("Object is not a Strichka");
    }

    public virtual object Clone()
    {
        return new Strichka(this.str);
    }
}
