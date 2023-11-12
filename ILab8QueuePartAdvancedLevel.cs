namespace Stack_and_Queue;

/// <summary>
/// Interface also implement IEnumerable, that iterate via sequence, generating elements in
/// MoveNext() method
/// </summary>
interface ILab8QueuePartAdvancedLevel : ILab8QueuePartBasicLevel, IEnumerable<int>
{
    /// <summary>
    /// Method returns list of elements, that can be divided by A, B or C in ascending order
    /// </summary>
    /// <param name="N">Lenght of sequence (number of elements)</param>
    /// <param name="startIndex">Number of element, from which sequence starts (0 - sequence
    /// will not skip elements)</param>
    /// <returns>List of elements, that can be divided by A, B or C in ascending order</returns>
    public List<int> GetSequence(int startIndex, int N);
}