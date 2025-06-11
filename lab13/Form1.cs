using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        private Stack nonGenericStack = new Stack();
        private Stack<ComplexNumber> genericStack = new Stack<ComplexNumber>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ComplexNumber.TryParse(txtInput.Text, out ComplexNumber cn))
            {
                nonGenericStack.Push(cn);
                genericStack.Push(cn);

                listBoxNonGeneric.Items.Add(cn.ToString());
                listBoxGeneric.Items.Add(cn.ToString());
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Невірний формат комплексного числа. Приклад: 2+3i");
            }
        }

        private void btnShowElement_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index))
            {
                if (index >= 0 && index < genericStack.Count)
                {
                    ComplexNumber[] array = genericStack.ToArray();
                    ComplexNumber element = array[index];
                    string result = $"Елемент за індексом {index}: {element}";

                    Form2 resultForm = new Form2(result);
                    resultForm.Show();
                }
                else
                {
                    MessageBox.Show("Невірний індекс.");
                }
            }
            else
            {
                MessageBox.Show("Введіть числовий індекс.");
            }
        }


        private void btnShowSorted_Click(object sender, EventArgs e)
        {
            List<ComplexNumber> list = new List<ComplexNumber>(genericStack);
            list.Sort(); // Потрібна реалізація IComparable у ComplexNumber

            string result = "Відсортований стек:\n" + string.Join("\n", list);

            // Показати результат у новій формі
            Form2 resultForm = new Form2(result);
            resultForm.Show();
        }

    }

    public class ComplexNumber : IComparable<ComplexNumber>
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real}{sign}{Math.Abs(Imaginary)}i";
        }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public int CompareTo(ComplexNumber other)
        {
            return this.Modulus.CompareTo(other.Modulus);
        }

        public static bool TryParse(string input, out ComplexNumber result)
        {
            result = null;
            input = input.Replace(" ", "").ToLower();

            try
            {
                int indexOfI = input.IndexOf("i");
                if (indexOfI == -1)
                    return false;

                input = input.Substring(0, indexOfI);
                string[] parts = input.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
                double real = 0, imaginary = 0;

                if (input.Contains("+"))
                {
                    var split = input.Split('+');
                    real = double.Parse(split[0]);
                    imaginary = double.Parse(split[1]);
                }
                else
                {
                    int minusIndex = input.IndexOf("-", 1);
                    if (minusIndex > 0)
                    {
                        var split = new string[]
                        {
                            input.Substring(0, minusIndex),
                            input.Substring(minusIndex + 1)
                        };
                        real = double.Parse(split[0]);
                        imaginary = -double.Parse(split[1]);
                    }
                    else
                    {
                        return false;
                    }
                }

                result = new ComplexNumber(real, imaginary);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

