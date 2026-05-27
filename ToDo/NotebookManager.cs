namespace ToDo;

public class NotebookManager
{
    private const string prefix = "notebook_";
    private string _basePath = ".";

    public string[] GetNotebooks()
    {
        return Directory.GetFiles(_basePath, prefix + "*.json");
    }
    
    public IJsonRepository CreateRepository(string notebookName)
    {
        string filePath = prefix + notebookName.ToLower() + ".json";

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "[]");
        }
        
        return new JsonRepository(filePath);
    }

    public IJsonRepository LoadNotebook(string filePath)
    {
        return new JsonRepository(filePath);
    }
}