using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endgame : MonoBehaviour
{
    private float gameProgress;
    private int money;
    private int totalGamesDeveloped;

    [SerializeField] private Text gpText, moneyText, gdText;
    private void Start()
    {
        gameProgress = PlayerPrefs.GetFloat("GameProgress");
        money = PlayerPrefs.GetInt("Money");
        totalGamesDeveloped = PlayerPrefs.GetInt("TotalGamesDeveloped");

        gpText.text = gameProgress.ToString("F2") + "%";
        moneyText.text = money.ToString();
        gdText.text = totalGamesDeveloped.ToString();
    }
}
