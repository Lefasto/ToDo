namespace ToDo;

public class TaskItem
{
    public int Id { get; set; }
    public string? Title  { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted  { get; set; }
    
    public void MarkAsDone()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        string status = IsCompleted ? "✓ erledigt" : "✗ offen";
        return $"[{Id}]: {Title}\n" +
               $"     Status         : {status}\n" +
               $"     Beschreibung   : {Description} ";
    }
}