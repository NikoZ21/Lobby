using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBannerItems : MonoBehaviour
{
    [SerializeField] RectTransform[] bannerItems;

    void OnEnable()
    {
        DisableItems();
        StartCoroutine(LoadItems());
    }

    private void DisableItems()
    {
        foreach (var item in bannerItems)
        {
            item.gameObject.SetActive(false);
        }
    }

    private IEnumerator LoadItems()
    {
        foreach (var item in bannerItems)
        {
            item.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
