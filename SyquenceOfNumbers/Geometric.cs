using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfNumbers
{
    public class Geometric : SequenceOfNumbers
    {

        private double ratio { get; set; }    

        public Geometric(double n, double f, double r)
        {
            num = n;
            first = f;
            ratio = r;
        }

        public override List<double> Generate(double n)
        {
            num = n;
            sequence = new List<double>();
            for (int i = 0; i < n; i++)
            {
                sequence.Add((double)(first * Math.Pow(ratio, i))); 
            }
            return sequence;
        }
        public override double SumN(double n)
        {
            if (n <= 0)
                return 0;
            return (first * (1 - Math.Pow(ratio, n))) / (1 - ratio);
        }
        public override string ToString()
        {
            if (sequence == null || sequence.Count == 0)
            {
                sequence = Generate(num);
            }

            string sequenceStr = string.Join(", ", sequence.Select(x => x.ToString("F2")));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Geometric Sequence ({num} elements):");
            sb.AppendLine(sequenceStr);
            return sb.ToString();
        }
    }
}

