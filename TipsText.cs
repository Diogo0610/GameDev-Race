using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TipsText : MonoBehaviour
{
    [SerializeField] private GameObject[] tipsText;
    private float timer = 0;
    private int changeTip = 0;

    void Update()
    {
        if (timer <= 4.5f)
        {
            timer += Time.deltaTime;
        }
        else if (timer >= 4.5f)
        {
            changeTip++;
            timer = 0;
        }
        if (changeTip > 4)
        {
            changeTip = 0;
        }

        if (changeTip == 0)
        {
            tipsText[4].SetActive(false);
            tipsText[0].SetActive(true);
        }
        else if (changeTip == 1)
        {
            tipsText[0].SetActive(false);
            tipsText[1].SetActive(true);
        }
        else if (changeTip == 2)
        {
            tipsText[1].SetActive(false);
            tipsText[2].SetActive(true);
        }
        else if (changeTip == 3)
        {
            tipsText[2].SetActive(false);
            tipsText[3].SetActive(true);
        }
        else if (changeTip == 4)
        {
            tipsText[3].SetActive(false);
            tipsText[4].SetActive(true);
        }
    }
}
