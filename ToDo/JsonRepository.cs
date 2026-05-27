using System.Text.Json;
namespace ToDo;

public class JsonRepository : IJsonRepository
{
    private string _filePath;

    public JsonRepository(string filePath)
    {
        _filePath = filePath;
    }
    public List<TaskItem> Load()
    {
        if (!File.Exists(_filePath))
        {
            return new List<TaskItem>();
        }
        
        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
    }
    
    public void Save(List<TaskItem> tasks)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        
        string json = JsonSerializer.Serialize(tasks, options);
        File.WriteAllText(_filePath, json);
    }
}