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
