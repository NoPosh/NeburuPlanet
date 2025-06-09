using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILevelManager : MonoBehaviour
{
    //Синглтон
    public static UILevelManager Instance;

    //Через него будем работать с UI
    [SerializeField] private GameObject ApproximatePanel;

    [SerializeField] private TMP_Text nightNumber;
    [SerializeField] private TMP_Text researchText;

    [SerializeField] private Image Fade;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Instance != this)
            Destroy(this);
    }

    public void ShowApproximatePopup()
    {
        ApproximatePanel.SetActive(true);
    }

    public void UpdateUI()
    {
        nightNumber.text = "Ночь " + LevelManager.Instance.nightIndex.ToString();
        researchText.text = "Доступно записей: " + LevelManager.Instance.researchCount.ToString();
    }

    public void FadeInScreen()
    {
        StartCoroutine(ChangeFade(Fade, 0, 1, 2f));
        StartCoroutine(WaitTime(2f));
    }



    private IEnumerator ChangeFade(Image img, float startAlpha, float endAlpha, float time)
    {
        img.gameObject.SetActive(true);
        float elapsedTime = 0f;

        Color color = img.color;

        while (elapsedTime < time)
        {
            float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / time);

            color.a = alpha;
            img.color = color;

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        color.a = endAlpha;
        img.color = color;
        img.gameObject.SetActive(false);

        UpdateUI();

    }

    private IEnumerator WaitTime(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(ChangeFade(Fade, 1, 0, 2f));
    }
}
