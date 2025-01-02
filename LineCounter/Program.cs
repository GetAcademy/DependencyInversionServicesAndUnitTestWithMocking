
using LineCounter;using LineCounter.LineSources;

//var lineSource = new FileLineSource("vgsak.txt");
//var lineSource = new KeyboardLineSource();
var lineSource = new WebLineSource("https://www.vg.no/nyheter/i/nybAQd/lo-ber-om-at-nho-blir-med-paa-erna-solbergs-fredning-av-sykeloennsordningen");
var service = new LineCountService(lineSource);
var stats = service.GetStats("er");
stats.Show();

//using var reader = new StreamReader("vgsak.txt");
//var searchText = "er";
//var matchingLineCount = 0;
//var totalLineCount = 0;
//var line = reader.ReadLine();
//while (line != null)
//{
//    if (line.Contains(searchText))
//    {
//        matchingLineCount++;
//    }
    
//    totalLineCount++;
//    line = reader.ReadLine();
//}

//Console.WriteLine($"{matchingLineCount} av {totalLineCount} linjer inneholder {searchText}");