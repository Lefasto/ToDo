namespace ToDo;
using System.IO;

public class NotebookManager
{
    private string _basePath = ".";

    public string[] GetNotebooks()
    {
        return Directory.GetFiles(_basePath, "*.json");
    }
    
    public IJsonRepository CreateRepository(string notebookName)
    {
        string filePath = notebookName.ToLower() + ".json";

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "[]");
        }
        
        return new JsonRepository(filePath);
    }
}