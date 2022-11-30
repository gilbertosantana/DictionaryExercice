Dictionary<string, int> candidates = new Dictionary<string, int>();

Console.Write("Enter full path: ");

string path = @Console.ReadLine()!;

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] votingRecord = sr.ReadLine()!.Split(',');
            string candidate = votingRecord[0];
            int votes = int.Parse(votingRecord[1]);

            if (!candidates.ContainsKey(candidate))
            {
                candidates.Add(candidate, votes);
            }
            else
            {
                candidates[candidate] += votes;
            }
        }
    }
    foreach(var item in candidates)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}