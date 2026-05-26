# To-Do Konsolenanwendung (C#)

## Projektbeschreibung

Dieses Projekt ist eine Konsolenanwendung zur Verwaltung von Aufgaben.  
Die Anwendung wurde im Rahmen der Ausbildung zum Fachinformatiker für Anwendungsentwicklung erstellt.

## Features

- Aufgaben erstellen
- Aufgaben anzeigen
- Aufgaben als erledigt markieren
- Aufgaben löschen
- Persistente Speicherung (JSON)
- Multi-Notebook-System (mehrere Aufgabenlisten als spätere Erweiterung)

## Architektur

Die Anwendung basiert auf einer Schichtenarchitektur:

- Program → Benutzeroberfläche
- TaskManager → Geschäftslogik
- JsonRepository → Persistenz

## Technologien

- C#
- .NET
- System.Text.Json
- JSON

## 📊 Architekturdiagramm

```mermaid
classDiagram

class Program {
    +Main()
}

class TaskManager {
    +AddTask()
    +RemoveTask()
    +MarkTaskAsDone()
    +GetAllTasks()
}

class JsonRepository {
    +Load()
    +Save()
}

class TaskItem {
    +Id
    +Title
    +Description
    +IsCompleted
    +MarkAsDone()
}

Programm --> TaskManager
TaskManager --> JsonRepository
TaskManager --> TaskItem
```