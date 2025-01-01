
using var reader = new StreamReader("vgsak.txt");
var searchText = "e";
var matchingLineCount = 0;
var totalLineCount = 0;
var line = reader.ReadLine();
while (line != null)
{
    if (line.Contains(searchText))
    {
        matchingLineCount++;
    }

    totalLineCount++;
    line = reader.ReadLine();
}

Console.WriteLine($"{matchingLineCount} av {totalLineCount} linjer inneholder {searchText}");