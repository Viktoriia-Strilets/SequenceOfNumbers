using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfNumbers
{
   public class Fibonacci : SequenceOfNumbers
    {
        private double second { get; set; }
        public Fibonacci(double n, double f, double s)
        {
            num = n;
            first = f;
            second = s;
        }
        public override List<double> Generate(double n)
        {
            num = n;
            sequence = new List<double> { first, second };
            for (int i = 2; i < n; i++)
            {
                sequence.Add(sequence[i - 1] + sequence[i - 2]);
            }
            return sequence;
        }
        public override double SumN(double n)
        {
            if (n <= 0)
                return 0;
            first = 0;
            double b = 1, sum = first + b;

            for (int i = 2; i < n; i++)
            {
                double next = first + b;
                sum += next;
                first = b;
                b = next;
            }

            return sum;
        }
        public override string ToString()
        {
            if (sequence == null || sequence.Count == 0)
            {
                sequence = Generate(num);
            }

            string sequenceStr = string.Join(", ", sequence.Select(x => x.ToString("F2")));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fibonacci Sequence ({num} elements):");
            sb.AppendLine(sequenceStr);
            return sb.ToString();
        }
    }
}
