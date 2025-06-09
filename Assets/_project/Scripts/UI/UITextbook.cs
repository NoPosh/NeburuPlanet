using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITextbook : MonoBehaviour
{
    [SerializeField] private GameObject TextbookPanel;
    [SerializeField] private GameObject SlotPrefab;
    [SerializeField] private GameObject DictionaryPanel;

    [Header("Object Info Panel")]
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Image objectIcon;
    [SerializeField] private GameObject notePanel;
    [SerializeField] private GameObject contextPanel;
    [SerializeField] private GameObject notePrefab;

    public void ShowObjectList()
    {
        TextbookPanel.SetActive(true);
        DictionaryPanel.SetActive(true);
        notePanel.SetActive(false);

        foreach (Transform child in DictionaryPanel.transform)
        {
            Destroy(child.gameObject);
        }

        foreach (var obj in TextbookHandler.Instance.objectsDictionary)
        {
            GameObject slot = Instantiate(SlotPrefab, DictionaryPanel.transform);
            slot.GetComponentInChildren<TMP_Text>().text = obj.Key;
            slot.GetComponent<Button>().onClick.AddListener(() => ShowObjectInfo(obj.Key));
        }
    }

    public void ShowObjectInfo(string key)
    {
        notePanel.SetActive(true);

        foreach (Transform child in contextPanel.transform)
        {
            Destroy(child.gameObject);
        }

        var noteList = TextbookHandler.Instance.objectsDictionary[key];
        nameText.text = key;
        //objectIcon.sprite = )
        foreach (var obj in noteList)
        {
            GameObject note = Instantiate(notePrefab, contextPanel.transform);

            TMP_Text[] texts = note.GetComponentsInChildren<TMP_Text>();
            texts[0].text = obj.Date.ToString();
            texts[1].text = obj.Note;
        }
    }
}
