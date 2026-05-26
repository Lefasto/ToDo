namespace ToDo;

public interface IJsonRepository
{
    List<TaskItem> Load();
    void Save(List<TaskItem> tasks);
}