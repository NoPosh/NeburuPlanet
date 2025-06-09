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
            return "��� ������";
    }


    //������� �� ������ ��������� ����������� � ������ � ����������� �������� �� ��, ��� � Data
    //����� ������� �������� UI ��� ������

    //� ����������� � �������� ����� ���-�� ����������� (�� ���� �������� ��� ����� ������ ����� Animator � ��� ������)
    //������ � ����� (��������� ������ � �������� ������ (���� ������ ���, �� ��� � ��������� ��������� � ���������, ��������� � ���������))
}


//����� ������� ����� �������, ������� ����� ����������� �������� � ������� <string, Note>
public class NoteObject
{
    public int Date; //����� ���� ����������� � ����������� �� ������ ���
    public string Note; //������� �� ������ �������

    public NoteObject(int date, string note)
    {
    Date = date; Note = note; 
    }

}