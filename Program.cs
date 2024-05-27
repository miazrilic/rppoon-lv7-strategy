namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortStrategy bubble = new BubbleSort();
            SortStrategy sequentialSort = new SequentialSort();

            NumberSequence sequence = new NumberSequence(6, bubble);
            sequence.InsertAt(0, 2);
            sequence.InsertAt(1, 4);
            sequence.InsertAt(2, 1);
            sequence.InsertAt(3, 3);
            sequence.InsertAt(4, 6);
            sequence.InsertAt(5, 5);
            sequence.Sort();
            Console.WriteLine(sequence);

            sequence.InsertAt(0, 0);



            
            sequence.SetSortStrategy(sequentialSort);
            sequence.Sort();
            
            Console.WriteLine(sequence);

            

            

            

            
        }
    }
    }
