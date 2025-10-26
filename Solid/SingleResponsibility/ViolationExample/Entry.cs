namespace SOLID.SingleResponsibilityPrinciple.ViolationExample;

public class Entry
{
    private readonly List<string> _entries = [];

    private static int _count = 0;

    public int AddEntry(string entry)
    {
        _entries.Add($"{++_count}: {entry}");

        return _count;
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    // The class is no longer responsible just for adding or removing entry
    public void Save(string filename, bool overwrite = false)
    {
        File.WriteAllText(filename, ToString());
    }

    public override string ToString() => string.Join(Environment.NewLine, _entries);
}