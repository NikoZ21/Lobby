using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LoadPages : MonoBehaviour
{
    [SerializeField] RectTransform PageOne;
    [SerializeField] RectTransform PageTwo;
    [SerializeField] RectTransform PageAll;
    [SerializeField] RectTransform InGamePage;

    public void OnPageOneLoad()
    {
        PageOne.gameObject.SetActive(true);
        PageTwo.gameObject.SetActive(false);
        PageAll.gameObject.SetActive(false);
        InGamePage.gameObject.SetActive(false);
    }

    public void OnPageTwoLoad()
    {
        PageOne.gameObject.SetActive(false);
        PageTwo.gameObject.SetActive(true);
        PageAll.gameObject.SetActive(false);
        InGamePage.gameObject.SetActive(false);
    }

    public void OnPageAllLoad()
    {
        PageOne.gameObject.SetActive(false);
        PageTwo.gameObject.SetActive(false);
        PageAll.gameObject.SetActive(true);
        InGamePage.gameObject.SetActive(false);
    }

    public void InGamePageLoad(string name)
    {
        PageOne.gameObject.SetActive(false);
        PageTwo.gameObject.SetActive(false);
        PageAll.gameObject.SetActive(false);
        InGamePage.gameObject.SetActive(true);
        InGamePage.GetComponentInChildren<TextMeshProUGUI>().text = name;
    }

    public void BackToLobby()
    {
        PageOne.gameObject.SetActive(false);
        PageTwo.gameObject.SetActive(false);
        PageAll.gameObject.SetActive(false);
        InGamePage.gameObject.SetActive(false);
    }
}
