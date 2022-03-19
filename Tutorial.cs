using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    private int textNumber = 1;
    [SerializeField] private GameObject[] tutorialText;
    [SerializeField] private Text numberText;

    private void Start()
    {
        tutorialText[0].SetActive(true);
        tutorialText[1].SetActive(false);
        tutorialText[2].SetActive(false);
        tutorialText[3].SetActive(false);
        tutorialText[4].SetActive(false);
        tutorialText[5].SetActive(false);
        tutorialText[6].SetActive(false);
        tutorialText[7].SetActive(false);
        tutorialText[8].SetActive(false);
        tutorialText[9].SetActive(false);
        tutorialText[10].SetActive(false);
        
    }

    void Update()
    {
        if (textNumber == 1)
        {
            tutorialText[10].SetActive(false);
            tutorialText[0].SetActive(true);
        }
        else if (textNumber == 2)
        {
            tutorialText[0].SetActive(false);
            tutorialText[1].SetActive(true);
        }
        else if (textNumber == 3)
        {
            tutorialText[1].SetActive(false);
            tutorialText[2].SetActive(true);
        }
        else if (textNumber == 4)
        {
            tutorialText[2].SetActive(false);
            tutorialText[3].SetActive(true);
        }
        else if (textNumber == 5)
        {
            tutorialText[3].SetActive(false);
            tutorialText[4].SetActive(true);
        }
        else if (textNumber == 6)
        {
            tutorialText[4].SetActive(false);
            tutorialText[5].SetActive(true);
        }
        else if (textNumber == 7)
        {
            tutorialText[5].SetActive(false);
            tutorialText[6].SetActive(true);
        }
        else if (textNumber == 8)
        {
            tutorialText[6].SetActive(false);
            tutorialText[7].SetActive(true);
        }
        else if (textNumber == 9)
        {
            tutorialText[7].SetActive(false);
            tutorialText[8].SetActive(true);
        }
        else if (textNumber == 10)
        {
            tutorialText[8].SetActive(false);
            tutorialText[9].SetActive(true);
        }
        else if (textNumber == 11)
        {
            tutorialText[9].SetActive(false);
            tutorialText[10].SetActive(true);
        }
        /*else if (textNumber == 12)
        {
            tutorialText.text = "GameDev Race é um jogo com fins acadêmicos. Foi desenvolvido por: Diogo B. Brandon, Eric M. Washimi, " +
                "Leandro S. Moreira, Mercio de Castro e Wesley Murilo M. Silva";
        }
        else if (textNumber == 13)
        {
            tutorialText.text = "Músicas por: Bart (Jump and Run), PlayOnLoop (Upbeat Music Loop 05 e Funny Music Loop 02) e " +
                "Nicole Marie T (SPY). Todos os efeitos sonoros por Nicole Marie T.";
        }*/
        if (textNumber > 11)
        {
            textNumber = 1;
        }

        numberText.text = $"{textNumber}/11";
    }

    public void OnClickNext()
    {
        textNumber++;
    }
}
