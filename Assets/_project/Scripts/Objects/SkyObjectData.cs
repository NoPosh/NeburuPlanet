using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class SkyObjectData : ScriptableObject
{
    public string Name;
    [TextArea(3, 5)]
    public string Description;
    public Sprite zoomIcon;
    [TextArea(3,5)]
    public List<string> observationNotes;
    //+ скорее всего нужно что-то типо этапов
}
