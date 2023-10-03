using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateApp : MonoBehaviour
{
    public GameObject GameObject;

    private void Start()
    {
        GameObject.SetActive(PlayerPrefs.GetInt("Rate", 0) == 0);
    }

    public void OnClickRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
        PlayerPrefs.SetInt("Rate", 1);
    }

    public void OnClickPrivacy()
    {
        Application.OpenURL("");
    }
}