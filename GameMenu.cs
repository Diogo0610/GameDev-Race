using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private GameObject playerStatus;
    private bool showPlayerStatus;
    [SerializeField] private MoodSlider MS;

    private void Start()
    {
        playerStatus.SetActive(false);
        showPlayerStatus = false;
    }
    void Update()
    {
    #if UNITY_STANDALONE
        if (Input.GetMouseButtonDown(2))
        ShowGameMenu();
    #endif
    }

    public void ShowGameMenu()
    {
        if (showPlayerStatus == false)
        {
            playerStatus.SetActive(true);
            showPlayerStatus = true;
        }
        else
        {
            playerStatus.SetActive(false);
            showPlayerStatus = false;
        }
    }
}
