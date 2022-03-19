using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class DayChange : MonoBehaviour
{
    [SerializeField] private Text dayText;
    public int dayCount;
    private float timer;

    private bool hasFinished;

    [SerializeField] private GameObject dayChange;

    //[SerializeField] private GameObject scoreboardPrefab, QuitRoom;
    //private bool quitRoomSpawn;
    void Start()
    {
        dayCount = 1;
        timer = 0;
        //scoreboardPrefab.SetActive(false);
        //quitRoomSpawn = false;

        hasFinished = false;
        dayChange.SetActive(true);
    }

    void Update()
    {
        if (dayCount < 10)
        {
            dayText.text = "0" + dayCount;
        }
        else
        {
            dayText.text = "" + dayCount;
        }

        if (timer <= 25)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 25)
        {
            dayCount++;
            timer = 0;
        }

        if (dayCount > 10)
        {
            //quitRoomSpawn = true;
            timer = 0;
            dayChange.SetActive(false);
            /*if (quitRoomSpawn)
            {
                Instantiate(QuitRoom);
                quitRoomSpawn = false;
            }
            scoreboardPrefab.SetActive(true);*/

            if (PhotonNetwork.IsMasterClient && hasFinished == false)
            {
                PhotonNetwork.LoadLevel("EndGame");
                hasFinished = true;
            }
        }
    }
}
