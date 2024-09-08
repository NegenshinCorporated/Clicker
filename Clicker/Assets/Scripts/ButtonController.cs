using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonController : MonoBehaviour
{
    private int clicks;
    private int clicksrate = 1;
    public TextMeshProUGUI clicksText;
    void Start()
    {
        clicks = PlayerPrefs.GetInt("Clicks");
        clicksText.text = "Balance:" + clicks.ToString();
        CheckClicks();
    }
    void Update()
    {
        clicksText.text = "Balance:" + clicks.ToString();
    }
    public void Click()
    {
        clicks += clicksrate;
    }
    public void UpgradeClick()
    {
        if (clicks >= 500)
        {
            clicks -= 500;
            clicksrate += 1;

        }
    }
    public void CheckClicks()
    {
        PlayerPrefs.SetInt("Clicks", clicks);
    }
}
