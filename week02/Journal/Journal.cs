using System.IO;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (FileStream outputFile = new FileStream(file, FileMode.Open, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                foreach (Entry entry in _entries)
                {
                    DateTime day = DateTime.Today;
                    entry._date = day.ToShortDateString();

                    sw.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                    sw.WriteLine($"{entry._entryText}");
                    sw.WriteLine("------------------------------------------------------------------------------------------------------------");
                }
            }
        }
    }
    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(file);

            using (StreamWriter inputFile = new StreamWriter(file, true))
            {
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}