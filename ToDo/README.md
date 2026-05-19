# 📝 SE-GL Projekt – To-Do Konsolenanwendung (C#)

## 📌 Projektbeschreibung

Im Rahmen des SE-GL Projekts wurde eine Konsolenanwendung in C# entwickelt, die als To-Do-App zur Verwaltung von Aufgaben dient.

Die Anwendung ermöglicht es dem Benutzer, Aufgaben zu:
- erstellen
- anzeigen
- als erledigt markieren
- löschen

Die Daten werden persistent in einer JSON-Datei gespeichert.

---

## 🎯 Ziel des Projekts

Ziel des Projekts ist es, grundlegende Konzepte der Softwareentwicklung praxisnah umzusetzen, insbesondere:

- Objektorientierte Programmierung (OOP)
- Trennung von Verantwortlichkeiten (Schichtenarchitektur)
- Dateiverarbeitung
- JSON-Serialisierung mit `System.Text.Json`
- Fehlerbehandlung

---

## ⚙️ Funktionen

Die Anwendung bietet folgende Funktionalitäten:

- ➕ Aufgabe hinzufügen
- 📋 Aufgaben anzeigen
- ✅ Aufgabe als erledigt markieren
- 🗑️ Aufgabe löschen
- 💾 Automatische Speicherung in JSON-Datei

---

## 🧱 Projektstruktur

```text
ToDoApp/
│
├── Program.cs           # Benutzeroberfläche (Konsole)
├── TaskItem.cs          # Datenmodell einer Aufgabe
├── TaskManager.cs       # Geschäftslogik (CRUD)
└── JsonRepository.cs    # Datenhaltung (JSON)