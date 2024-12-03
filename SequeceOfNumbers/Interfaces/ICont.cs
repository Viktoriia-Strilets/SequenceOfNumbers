namespace SequenceOfNumbers
{
    public class Element
    {
        public SequenceOfNumbers? item { get; set; }
        public Element? next { get; set; }
    }

    internal interface ICont
    {
        Element? First { get; set; }
        TextBox TBox { get; set; }
        void AddSequence(SequenceOfNumbers sn);

        bool RemoveSequence(int index);
        string Output();
        double SumAllSequences();
        SequenceOfNumbers? FindSequenceWithMaxSum();

    }
}