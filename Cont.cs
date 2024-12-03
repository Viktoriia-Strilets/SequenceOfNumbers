using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SequenceOfNumbers
{
    public class Cont : ICont
    {

        private Element? first;
        public Element? First
        {
            get => first;
            set=> first = value;
            }
        private TextBox tBox;
        public TextBox TBox
        {
            get => tBox;
            set => tBox = value;
        }
        public Cont(TextBox t)
        {
            tBox = t;
            first = null;
        }
        public void AddSequence(SequenceOfNumbers sn)
        {
            if (sn == null)
            {
                throw new ArgumentNullException(nameof(sn), "Sequence cannot be null");
            }

            Element temp = new Element
            {
                item = sn,
                next = first
            };

            first = temp;
        }

        public bool RemoveSequence(int index)
        {
            if (first == null) return false;

            if (index == 0)
            {
                first = first.next;
                return true;
            }

            Element? current = first;
            int currentIndex = 0;

            while (current?.next != null)
            {
                if (currentIndex + 1 == index)
                {
                    current.next = current.next.next;
                    return true;
                }
                current = current.next;
                currentIndex++;
            }

            return false; 
        }
        public string Output()
        {
            StringBuilder output = new StringBuilder();
            Element? temp = first;
            tBox.Clear();

            if (temp == null)
            {
                tBox.Text = "No sequences in container.";
                return "No sequences in container.";
            }
           
            output.AppendLine("Sequence in container:");
            while (temp != null)
            {
                if (temp.item != null)
                {
                    output.AppendLine(temp.item.ToString());
                }

                temp = temp.next;
            }
            tBox.Text += output.ToString();
            return tBox.Text;
        }
        public double SumAllSequences()
        {
            double totalSum = 0;
            Element? current = first;

            while (current != null)
            {
                if (current.item != null)
                {
                    totalSum += current.item.SumN(current.item.num); 
                }
                current = current.next;
            }

            return totalSum;
        }
        public SequenceOfNumbers? FindSequenceWithMaxSum()
        {
            SequenceOfNumbers? maxSumSequence = null;
            double maxSum = double.MinValue;
            Element? current = first;

            while (current != null)
            {
                if (current.item != null)
                {
                    double currentSum = current.item.SumN(current.item.num); 
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumSequence = current.item;
                    }
                }
                current = current.next;
            }

            return maxSumSequence;
        }
    }
}
