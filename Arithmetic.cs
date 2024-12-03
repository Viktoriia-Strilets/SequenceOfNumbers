using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfNumbers
{
    public class Arithmetic : SequenceOfNumbers
    {

        private double difference { get; set; }

        public Arithmetic(double n, double f, double d)
        {
            num = n;
            first = f;
            difference = d;
        }
        public override List<double> Generate(double n)
        {
            num = n;
            sequence = new List<double>();

            for (int i = 0; i < n; i++)
            {
                sequence.Add(first + i * difference);
            }

            return sequence;
        }
        public override double SumN(double n)
        {
            if (n <= 0)
                return 0;
            return ((2*first + difference*(n-1))/2)*n;
        }

        public override string ToString()
        {
            if (sequence == null || sequence.Count == 0)
            {
                 sequence = Generate(num);
            }

            string sequenceStr = string.Join(", ", sequence.Select(x => x.ToString("F2")));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Arithmetic Sequence ({num} elements):");
            sb.AppendLine(sequenceStr);
            return sb.ToString();
        }
    }
}
