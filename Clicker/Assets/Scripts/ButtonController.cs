using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonController : MonoBehaviour
{
    private int clicks;
    public TextMeshProUGUI clicksText;
    void Start()
    {
        clicks = 0;
        clicksText.text = "Balance:" + clicks.ToString();
    }
    void Update()
    {
        clicksText.text = "Balance:" + clicks.ToString();
    }
    public void Click()
    {
        clicks++;
    }
}
