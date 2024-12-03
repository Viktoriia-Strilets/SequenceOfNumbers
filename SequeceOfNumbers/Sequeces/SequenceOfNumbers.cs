namespace SequenceOfNumbers
{
    public abstract class SequenceOfNumbers: ISequenceOfNumbers
    {
        protected double first;
        public double First;
        internal double num;
        public double Num;
        protected List<double>? sequence;
        public List<double>? Sequence;
        public abstract List<double> Generate(double n);
        public abstract double SumN(double n);
    }
}