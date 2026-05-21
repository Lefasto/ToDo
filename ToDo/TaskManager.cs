namespace ToDo;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> _tasks;

    public TaskManager()
    {
        _tasks = new List<TaskItem>();
    }
    
    public List<TaskItem> GetAllTasks()
    {
        return _tasks;
    }

    public void AddTask(string title, string description)
    {
        int newId = _tasks.Count + 1;

        TaskItem task = new TaskItem();
        task.Title = title;
        task.Description = description;
        task.Id = newId;
        task.IsCompleted = false;
        
        _tasks.Add(task);
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