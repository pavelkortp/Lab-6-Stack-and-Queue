using System.Collections;

namespace Stack_and_Queue;

public class Lab8QueuePartBasicLevel : ILab8QueuePartAdvancedLevel
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    private readonly Queue<int> sequence;

    public Lab8QueuePartBasicLevel(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
        sequence = new Queue<int>();
    }

    public List<int> GetSequence(int N)
    {
        var s = new List<int>();
        var queueA = new Queue<int>();
        var queueB = new Queue<int>();
        var queueC = new Queue<int>();

        queueA.Enqueue(A);
        queueB.Enqueue(B);
        queueC.Enqueue(C);
        while (s.Count < N)
        {
            int nextNumber = Math.Min(queueA.Peek(),
                Math.Min(queueB.Peek(), queueC.Peek()));
            if (nextNumber == queueA.Peek())
            {
                queueA.Dequeue();
            }

            if (nextNumber == queueB.Peek())
            {
                queueB.Dequeue();
            }

            if (nextNumber == queueC.Peek())
            {
                queueC.Dequeue();
            }

            s.Add(nextNumber);
            queueA.Enqueue(nextNumber * A);
            queueB.Enqueue(nextNumber * B);
            queueC.Enqueue(nextNumber * C);
        }

        return s;
    }
    

    public List<int> GetSequence(int startIndex, int N)
    {
        var result = new List<int>();
        for (int i = 0; i < startIndex && sequence.Count > 0; i++)
        {
            sequence.Dequeue();
        }

        for (int i = 0; i < N && sequence.Count > 0; i++)
        {
            result.Add(sequence.Dequeue());
        }

        return result;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return sequence.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}




