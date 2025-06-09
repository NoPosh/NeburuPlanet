using System;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //����� ���� ������ � ������� � ����
    public static LevelManager Instance;

    [SerializeField] private GameObject _approximateObj;
    [SerializeField] private SpriteRenderer _objImage;

    private SkyObject _currentObj;

    public int nightIndex { get; private set; }
    public int researchCount { get; private set; }

    //���-�� ���������� ��������� ������������ �� ����

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Instance != this)
            Destroy(this);

        if (TextbookHandler.Instance == null)
        TextbookHandler.Instance = new TextbookHandler();


        nightIndex = 1;
        researchCount = 1;
    }

    public void ShowApproximate(Sprite image)
    {
        _approximateObj.SetActive(true);
        _objImage.sprite = image;
        UILevelManager.Instance.ShowApproximatePopup();
    }

    public void SetCurrentObject(SkyObject obj)
    {
        _currentObj = obj;
    }

    public void WriteNote()
    {
        //����� ���� ��������� ������ � ��������� �������� ����� ����
        if (researchCount > 0)
        {
            TextbookHandler.Instance.AddNote(_currentObj.SkyObjectData.Name, new NoteObject(nightIndex, _currentObj.GetCurrentNote()));
            researchCount--;
            UILevelManager.Instance.UpdateUI();
        }

             
    }

    public void EndNight()
    {
        //���������� �����
        UILevelManager.Instance.FadeInScreen();

        nightIndex++;
        researchCount = 1;

    }
}

