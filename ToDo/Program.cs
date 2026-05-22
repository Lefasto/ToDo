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
                    Console.WriteLine("Funktion wird noch implentiert");
                    break;
                
                case "4":
                    Console.WriteLine("Funktion wird noch implentiert");
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

    static void ShowTasks(TaskManager manager)
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

    static void AddTask(TaskManager manager)
    {
        Console.WriteLine("Titel: ");
        string? title = Console.ReadLine();

        Console.WriteLine("Beschreibung: ");
        string? description = Console.ReadLine();
        
        manager.AddTask(title, description);
        Console.WriteLine("Aufgabe wurde hinzugefügt");
    }
}