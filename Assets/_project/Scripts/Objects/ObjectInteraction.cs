using Unity.VisualScripting;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    //Отвечает за нажатие на объект
    private SkyObject _skyObject;

    private void Start()
    {
        _skyObject = GetComponent<SkyObject>();
    }

    private void OnMouseDown()
    {
        //Можно сделать проверку на то, можно ли взаимодействовать с этим объектом
        Debug.Log("Вы нажали на:" + _skyObject.SkyObjectData.Name);
        LevelManager.Instance.ShowApproximate(_skyObject.SkyObjectData.zoomIcon);
        LevelManager.Instance.SetCurrentObject(_skyObject);
    }
}
