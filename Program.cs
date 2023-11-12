
using Stack_and_Queue;

var incorrectEx = "([x-y-z}*[x+2y)-{z+4x)].";
int processedChars1;
var correctEx = "({x-y-z}*[x+2y]-(z+4x));";
int processedChars2;

Console.WriteLine($"Check first expression {BracketChecker.IsCorrect(incorrectEx, out processedChars1)}, processed chars: {processedChars1}");
Console.WriteLine($"Check second expression {BracketChecker.IsCorrect(correctEx, out processedChars2)}, processed chars: {processedChars2}");

var lab = new Lab8QueuePartBasicLevel(2, 3, 5);
var list = lab.GetSequence(10);

Console.WriteLine(string.Join(',', list));


