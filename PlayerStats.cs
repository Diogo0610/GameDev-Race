using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerStats : MonoBehaviour
{
    //private ExitGames.Client.Photon.Hashtable gameConclusion = new ExitGames.Client.Photon.Hashtable();

    [SerializeField] private Choice choice;

    [HideInInspector] public int money;
    [SerializeField] private Text moneyText;
    
    private float timer;

    public int moodValue;
    private int maxMoodValue;
    private int minMoodValue;

    private float productivity;
    public float productivityBonus;
    private float progressSpeed;
    [SerializeField] private Text productivityText;

    private float gameDevProgressDay;
    private float gameProgress;
    [SerializeField] private Text gameProgressText;
    private int gamesDeveloped = 0;
    private int totalGamesDeveloped;
    private bool added;

    [SerializeField] private GameObject androidButtons;

    public int dayCount;

    void Start()
    {
        money = 4250;
        timer = 0;

        moodValue = 50;
        maxMoodValue = 100;
        minMoodValue = 0;

        productivityBonus = 0;

        gameDevProgressDay = 7.35f;
        gameProgress = 0;

        dayCount = 1;

        added = false;

        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.SetFloat("GameProgress", 0);
    }

    void Update()
    {
        GameplayStats();
        MoodSlider();
        ProductivityStats();
        AndroidBuild();
        TotalGames();

        progressSpeed = productivity + (productivityBonus);

        moneyText.text = money.ToString();
        productivityText.text = progressSpeed.ToString();
        gameProgressText.text = gameProgress.ToString("F2") + "%";

        //Debug.Log(PlayerPrefs.GetInt("TotalGamesDeveloped"));
    }

    void GameplayStats()
    {
        if (timer <= 25)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 25)
        {
            if (money >= 320)
            {
                money -= 320;
            }
            gameProgress += gameDevProgressDay * progressSpeed;
            dayCount++;
            timer = 0;
        }
        if (dayCount > 10)
        {
            //SetCustomProperties();
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetFloat("GameProgress", gameProgress);
        }

        if (productivityBonus > 0.4f)
        {
            productivityBonus = 0.4f;
        }

        if (money < 320)
        {
            gameDevProgressDay = 0;
        }
        else
        {
            gameDevProgressDay = 7.35f;
        }

        if (money <= 0)
        {
            money = 0;
        }

        if (gameProgress >= 100)
        {
            gameProgress = 100;
        }
    }
    void MoodSlider()
    {
        if (moodValue > maxMoodValue)
        {
            moodValue = 100;
        }
        if (moodValue < minMoodValue)
        {
            moodValue = 0;
        }
    }
    void ProductivityStats()
    {
        if (moodValue >= 35 && moodValue <= 65)
        {
            productivity = 1;
        }
        else if (moodValue >= 1 && moodValue <= 34)
        {
            productivity = 0.7f;
        }
        else if (moodValue >= 66 && moodValue <= 90)
        {
            productivity = 1.3f;
        }
        else if (moodValue == 0)
        {
            productivity = 0.4f;
        }
        else
        {
            productivity = 1.4f;
        }

        if (productivityBonus <= 0)
        {
            productivityBonus = 0;
        }
    }
    void AndroidBuild()
    {
    #if UNITY_STANDALONE
        androidButtons.SetActive(false);
    #endif

    #if UNITY_ANDROID
        androidButtons.SetActive(true);
    #endif
    }

    void TotalGames()
    {
        if (gameProgress >= 100 && added == false)
        {
            gamesDeveloped++;
            totalGamesDeveloped = PlayerPrefs.GetInt("TotalGamesDeveloped");
            totalGamesDeveloped += gamesDeveloped;
            PlayerPrefs.SetInt("TotalGamesDeveloped", totalGamesDeveloped);
            added = true;

            
        }
    }

    /*void SetCustomProperties()
    {
        gameConclusion["GameConclusion"] = gameProgress;
        PhotonNetwork.LocalPlayer.CustomProperties = gameConclusion;
    }*/
}
