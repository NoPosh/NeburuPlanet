

using System.Collections.Generic;

public class TextbookHandler
{
    //Содержит записи в книжке
    public static TextbookHandler Instance;
    //Словарь {Имя, Запись[]}
    public Dictionary<string, List<NoteObject>> objectsDictionary = new Dictionary<string, List<NoteObject>>();

    //Добавление записи
    public void AddNote(string objName, NoteObject note)
    {
        if (!objectsDictionary.ContainsKey(objName))
        {
            objectsDictionary.Add(objName, new List<NoteObject>());
        }
        objectsDictionary[objName].Add(note);
    }

    public List<NoteObject> GetNotes(string objName)
    {
        if (objectsDictionary.TryGetValue(objName, out var notes))
            return notes;
        return new List<NoteObject>();
    }
}
