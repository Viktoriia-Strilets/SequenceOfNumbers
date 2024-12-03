namespace SequenceOfNumbers
{
    public class Cont : ICont
    {
         private Element? first;
         public Element? First;
         private TextBox tBox;
        public TextBox TBox;
        public void AddSequence(SequenceOfNumbers sn);
        public bool RemoveSequence(int index);
        public string Output();
         public double SumAllSequences();
         public SequenceOfNumbers? FindSequenceWithMaxSum();
         
    }
}