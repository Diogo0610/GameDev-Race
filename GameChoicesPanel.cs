using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameChoicesPanel : MonoBehaviour
{
    [SerializeField] private Choice choice;

    [SerializeField] private GameObject buttonsGO;
    [SerializeField] private GameObject choicePanel;
    [SerializeField] private GameObject playerStatus;
    [SerializeField] private GameObject timer;
    [SerializeField] private Transform gameChoicePanel;

    private float timerChoice;
    private int days;
    private bool hasSpawnedChoicePrefab;
    public bool showPlayerStatsPanel;

    void Start()
    {
        hasSpawnedChoicePrefab = false;
        choicePanel.SetActive(false);
        buttonsGO.SetActive(false);
        days = 1;
        showPlayerStatsPanel = true;
    }
    void Update()
    {
        TimerChoice();
    }
    
    void TimerChoice()
    {
        if (timerChoice <= 25)
        {
            timerChoice += Time.deltaTime;
        }
        else if (timerChoice >= 25)
        {
            timerChoice = 0;
            days++;
            hasSpawnedChoicePrefab = false;
            choice.hideButtons = false;
            choice.hasChosen = false;
        }

        if (timerChoice >= 5 && hasSpawnedChoicePrefab == false)
        {
            playerStatus.SetActive(false);
            buttonsGO.SetActive(true);
            choicePanel.SetActive(true);
            Instantiate(timer, gameChoicePanel);
            hasSpawnedChoicePrefab = true;
            showPlayerStatsPanel = false;
        }
        else if (timerChoice >= 20.1f)
        {
            if (timerChoice >= 20.1f && choice.hasChosen == false)
            {
                choice.ChoiceTimeOut();
                choice.hasChosen = true;
            }
            buttonsGO.SetActive(false);
            choicePanel.SetActive(false);
            Destroy(GameObject.Find("Timer(Clone)"));
            showPlayerStatsPanel = true;
        }

        if (choice.hideButtons)
        {
            buttonsGO.SetActive(false);
        }

        if (days > 10) 
        {
            timerChoice = 0;
        }

    }
}
