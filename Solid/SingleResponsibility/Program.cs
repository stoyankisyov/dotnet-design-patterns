using System.Diagnostics;
using SOLID.SingleResponsibilityPrinciple;

var entry = new Entry();
entry.AddEntry("Entry 1");
entry.AddEntry("Entry 2");
entry.AddEntry("Entry 3");
entry.RemoveEntry(0);

Console.WriteLine(entry);

var persistence = new Persistence();
const string path = @".\SingleResponsibilityPrinciple";
const string fileName = "entry.txt";
persistence.SaveToFile(entry, path, fileName, true);
Process.Start(new ProcessStartInfo
{
    FileName = $"{Path.GetDirectoryName(path)}\\{fileName}",
    UseShellExecute = true
});