namespace ToDo;

class Program
{
    private static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("=== To-Do App ===");
            Console.WriteLine("1) Aufgaben anzeigen");
            Console.WriteLine("2) Aufgabe hinzufügen");
            Console.WriteLine("3) Aufgabe als erledigt markieren");
            Console.WriteLine("4) Aufgabe löchen");
            Console.WriteLine("0) Beenden");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Auswahl: ");
            
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowTasks(manager);
                    break;
                
                case "2":
                    AddTask(manager);
                    break;
                
                case "3":
                    CompleteTask(manager);
                    break;
                
                case "4":
                    DeleteTask(manager);
                    break;
                
                case "0":
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("ungültige Eingabe");
                    break;
            }
        }
    }

    private static void ShowTasks(TaskManager manager)
    {
        var tasks = manager.GetAllTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("Kein Tasks gefunden");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine($"{task}");
        }
    }

    private static void AddTask(TaskManager manager)
    {
        Console.Write("Titel: ");
        string? title = Console.ReadLine();

        Console.Write("Beschreibung: ");
        string? description = Console.ReadLine();
        
        manager.AddTask(title, description);
        Console.WriteLine("Aufgabe wurde hinzugefügt");
    }

    private static void CompleteTask(TaskManager manager)
    {
        Console.Write("ID der Aufgabe: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            manager.MarkTaskAsDone(id);
            Console.WriteLine("Aufgabe wurde als erledigt markiert.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe.");
        }
    }

    private static void DeleteTask(TaskManager manager)
    {
        Console.Write("ID der Aufgabe: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            manager.RemoveTask(id);
            Console.WriteLine("Aufgabe wurde gelöscht.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe.");
        }
    }
}