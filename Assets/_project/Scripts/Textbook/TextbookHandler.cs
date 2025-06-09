

using System.Collections.Generic;

public class TextbookHandler
{
    //�������� ������ � ������
    public static TextbookHandler Instance;
    //������� {���, ������[]}
    public Dictionary<string, List<NoteObject>> objectsDictionary = new Dictionary<string, List<NoteObject>>();

    //���������� ������
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
