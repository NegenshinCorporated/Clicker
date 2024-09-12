using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private int clicks;
    private int clicksrate = 1;
    public TextMeshProUGUI clicksText;
    private int upgradeClick = 500;
    private int upgradeHamster = 1;
    public GameObject hamster1;
    public GameObject hamster2;
    public GameObject hamster3;
    public GameObject hamster4;
    void Start()
    {
        clicks = PlayerPrefs.GetInt("Clicks");
        PlayerPrefs.SetInt("Clicks", clicks);
        clicksText.text = "Balance:" + clicks.ToString();
        if (PlayerPrefs.GetInt("ClickRate") == 0)
        {
            clicksrate = 1;
        }
        else
        {
            clicksrate = PlayerPrefs.GetInt("ClickRate");
        }
        if (PlayerPrefs.GetInt("upgradeClick") == 0)
        {
            upgradeClick = 500;
        }
        else
        {
            upgradeClick = PlayerPrefs.GetInt("upgradeClick");
        }
        
    }
    void Update()
    {
        clicksText.text = "Balance:" + clicks.ToString();
    }
    public void Click()
    {
        clicks += clicksrate;
        PlayerPrefs.SetInt("Clicks", clicks);
    }
    public void UpgradeClick()
    {
        if (clicks >= upgradeClick)
        {
            clicks -= upgradeClick;
            clicksrate += 1;
            upgradeClick *= 2;
            PlayerPrefs.SetInt("ClickRate", clicksrate);
            PlayerPrefs.SetInt("upgradeClick", upgradeClick);
        }
    }
    public void UpgradeHamsters()
    {
        if (clicks >= 100)
        {
            clicks -= 100;
            upgradeHamster++;
        }
        if (upgradeHamster == 2)
        {
            hamster1.SetActive(false);
            hamster2.SetActive(true);
        }
        else if (upgradeHamster == 3)
        {
            hamster2.SetActive(false);
            hamster3.SetActive(true);
        }
        else if (upgradeHamster == 4)
        {
            hamster3.SetActive(false);
            hamster4.SetActive(true);
        }
    }

    public void CheckClicks()
    {
        PlayerPrefs.SetInt("Clicks", clicks);
    }
}
