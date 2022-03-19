using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidButtons : MonoBehaviour
{
    [SerializeField] private GameMenu GM;
    [SerializeField] private CameraPlayer CP;
    [SerializeField] private GameChoicesPanel GCP;
    public void OnClickCameraButton()
    {
        CP.camCount++;
    }
    public void OnClickListButton()
    {
        if (GCP.showPlayerStatsPanel == true)
        {
            GM.ShowGameMenu();
        }    
    }
}
