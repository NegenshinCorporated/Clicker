using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveResult : MonoBehaviour
{
    private int balance;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Balance"))
        {
            PlayerPrefs.SetInt("Balance", 0);
        }
        else
        {
            balance = PlayerPrefs.GetInt("Balance");
        }
    }
}
