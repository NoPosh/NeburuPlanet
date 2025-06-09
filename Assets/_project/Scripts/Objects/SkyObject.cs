using UnityEngine;

public class SkyObject : MonoBehaviour
{
    public SkyObjectData SkyObjectData;
    private int currentNote = 0;

    public string GetCurrentNote()
    {
        currentNote++;
        if (currentNote - 1 < SkyObjectData.observationNotes.Count)
            return SkyObjectData.observationNotes[currentNote-1];
        else
            return "Нет данных";
    }


    //Нажатие на объект открывает приближение и меняет в приближении картинку на ту, что в Data
    //Также нажатие включает UI про запись

    //В приближении с объектом может что-то происходить (то есть наверное это нужно делать через Animator в сам объект)
    //Запись в книгу (добавляет данные в записную книжку (если первый раз, То еще и страничку добавляет с названием, описанием и картинкой))
}


//Можно сделать класс записей, которые будут сохраняться например в словаре <string, Note>
public class NoteObject
{
    public int Date; //Будет само создаваться в зависимости от номера дня
    public string Note; //Берется из данных объекта

    public NoteObject(int date, string note)
    {
    Date = date; Note = note; 
    }

}