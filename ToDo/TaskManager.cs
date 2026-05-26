namespace ToDo;
using System.Collections.Generic;

public class TaskManager
{
    private List<TaskItem> _tasks;
    private JsonRepository _repository;

    public TaskManager()
    {
        _repository = new JsonRepository();
        _tasks = _repository.Load();
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
        _repository.Save(_tasks);
    }

    public void RemoveTask(int id)
    {
        for(int i = 0; i < _tasks.Count; i++){
            
            if(_tasks[i].Id == id){
                _tasks.RemoveAt(i);
                _repository.Save(_tasks);
                return;
            }
        }
    }

    public void MarkTaskAsDone(int id)
    {
        foreach (var task in _tasks)
        {
            if (task.Id == id)
            {
                task.IsCompleted = true;
                _repository.Save(_tasks);
                return;
            }
        }
    }
}