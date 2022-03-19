using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Realtime;
using Photon.Pun;

public class ScoreboardItem : MonoBehaviour
{
    public TMP_Text usernameText, conclusionText;

    public void Initialize(Player player)
    {
        float gameConclusion = (float)player.CustomProperties["GameConclusion"];
        usernameText.text = player.NickName;
        conclusionText.text = gameConclusion.ToString("F2") + "%";
    }
}
