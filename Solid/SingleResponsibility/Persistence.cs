namespace SOLID.SingleResponsibilityPrinciple;

public class Persistence
{
    public void SaveToFile(Entry entry, string path, string fileName, bool overwrite = false)
    {
        if (overwrite || !File.Exists(fileName))
        {
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory ?? throw new InvalidOperationException());
            }

            File.WriteAllText(fileName, entry.ToString());
        }
    }
}