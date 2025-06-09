using Unity.VisualScripting;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    //�������� �� ������� �� ������
    private SkyObject _skyObject;

    private void Start()
    {
        _skyObject = GetComponent<SkyObject>();
    }

    private void OnMouseDown()
    {
        //����� ������� �������� �� ��, ����� �� ����������������� � ���� ��������
        Debug.Log("�� ������ ��:" + _skyObject.SkyObjectData.Name);
        LevelManager.Instance.ShowApproximate(_skyObject.SkyObjectData.zoomIcon);
        LevelManager.Instance.SetCurrentObject(_skyObject);
    }
}
