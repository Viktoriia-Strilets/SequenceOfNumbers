using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfNumbers
{
    public abstract class SequenceOfNumbers: ISequenceOfNumbers
    {
        protected double first;
        public double First
        { 
            get => first;
            set => first = value; 
        }
        internal double num;
        public double Num
        {
            get => num;
            set => num = value;
        }
        protected List<double>? sequence;
        public List<double>? Sequence
        {
            get => sequence;
            set => sequence = value;
        }
        public SequenceOfNumbers()
        {
            num = 1;
            first = 0;
            sequence = null;
        }
        public SequenceOfNumbers(double n, double f, List<double> s)
        {
            num = n;
            first = f;
            sequence = s;
        }
        public SequenceOfNumbers(SequenceOfNumbers sn)
        {
            num = sn.num;
            first = sn.first;
            sequence = sn.sequence;
        }
        public abstract List<double> Generate(double n);
        public abstract double SumN(double n);
    }
}
