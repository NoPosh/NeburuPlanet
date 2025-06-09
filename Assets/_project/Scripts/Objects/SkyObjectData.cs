using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class SkyObjectData : ScriptableObject
{
    public string Name;
    [TextArea(3, 5)]
    public string Description;
    public Sprite zoomIcon;
    public List<string> observationNotes;
    //+ ������ ����� ����� ���-�� ���� ������
}
