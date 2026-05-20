namespace ToDo;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> _tasks;
    private JsonRepository _repository;

    public TaskManager()
    {
        _repository = new JsonRepository();
    }
    
    public List<TaskItem> GetAllTasks()
    {
        return _tasks;
    }

    public void AddTask(string title, string description)
    {
        throw new NotImplementedException();
    }

    public bool RemoveTask(int id)
    {
        throw new NotImplementedException();
    }

    public bool MarkTaskAsDone(int id)
    {
        throw new NotImplementedException();
    }
}