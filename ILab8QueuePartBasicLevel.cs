namespace Stack_and_Queue;

public interface ILab8QueuePartBasicLevel
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    
    /// <summary>
    /// Method returns list of elements, that can be divided by A, B or C in ascending order
    /// </summary>
    /// <param name="N">Lenght of sequence (number of elements)</param>
    /// <returns>List of elements, that can be divided by A, B or C in ascending order</returns>
    public List<int> GetSequence(int N);
}
