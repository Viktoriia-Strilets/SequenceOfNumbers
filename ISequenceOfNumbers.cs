using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfNumbers
{
    internal interface ISequenceOfNumbers
    {
         double First { get; set; }
         double Num { get; set; }
         List<double>? Sequence { get; set; }
         abstract List<double> Generate(double n);
         abstract double SumN(double n);
    }
}
