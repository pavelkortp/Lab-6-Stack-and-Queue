namespace Stack_and_Queue;

/// <summary>
/// Checks if the brackets are placed correctly in the string by rules:
/// 1) Each opening bracket must have a closing bracket on its right.
/// parenthesis. The converse must also be true.
/// 2) Opening and closing pairs of brackets of different types must be
/// correctly positioned according to each other.
/// </summary>
public class BracketChecker
{
    /// <summary>
    /// Checks if expression is correct and returns the number of successfully
    /// processed characters of the string using the method parameter.
    /// </summary>
    /// <param name="input">Expression which we check.</param>
    /// <param name="processedChars">Count of successfully processed symbols.</param>
    /// <returns>True if expression is correct, otherwise false.</returns>
    public static bool IsCorrect(string input, out int processedChars)
    {
        processedChars = 0;
        if (!input.EndsWith(';'))
        {
            return false;
        }
        Stack<char> bracketStack = new Stack<char>();
        foreach (char c in input)
        {
            processedChars++;
            if (IsBracket(c))
            {
                if (IsOpeningBracket(c))
                {
                    bracketStack.Push(c);
                }
                else if (!IsOpeningBracket(c))
                {
                    if (bracketStack.Count == 0 || !AreMatchingBrackets(bracketStack.Peek(), c))
                    {
                        
                        return false;
                    }

                    bracketStack.Pop();
                }
            }
        }

        return bracketStack.Count == 0;
    }

    /// <summary>
    /// Checks if current symbol is opening bracket.
    /// </summary>
    /// <param name="c">symbol.</param>
    /// <returns>True if symbol is opening bracket, otherwise false.</returns>
    private static bool IsOpeningBracket(char c)
    {
        return c is '(' or '[' or '{' or '<';
    }
    

    /// <summary>
    /// Checks if current symbol is bracket.
    /// </summary>
    /// <param name="c"> symbol</param>
    /// <returns>True if symbols is bracket o</returns>
    private static bool IsBracket(char c)
    {
        return c is '(' or ')' or '[' or ']' or '{' or '}' or '<' or '>';
    }


    /// <summary>
    /// Checks if 2 symbols are opening and closing brackets the same type.
    /// </summary>
    /// <param name="opening"> First symbol.</param>
    /// <param name="closing"> Second symbol.</param>
    /// <returns>True if 2 symbols are opening and closing brackets of same type, otherwise False</returns>
    private static bool AreMatchingBrackets(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}') ||
               (opening == '<' && closing == '>');
    }
}