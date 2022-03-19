using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayersInRoom : MonoBehaviourPunCallbacks
{
    List<PlayerName> playerNamesList = new List<PlayerName>();
    [SerializeField] private PlayerName playerNamePrefab;
    [SerializeField] private Transform playerNameParent;

    void Start()
    {
        UpdatePlayerList();
    }
    void UpdatePlayerList()
    {
        foreach (PlayerName item in playerNamesList)
        {
            Destroy(item.gameObject);
        }
        playerNamesList.Clear();

        if (PhotonNetwork.CurrentRoom == null)
        {
            return;
        }
        foreach (KeyValuePair<int, Player> player in PhotonNetwork.CurrentRoom.Players)
        {
            PlayerName newPlayerName = Instantiate(playerNamePrefab, playerNameParent);
            newPlayerName.SetPlayerInfo(player.Value);
            playerNamesList.Add(newPlayerName);
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        UpdatePlayerList();
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        UpdatePlayerList();
    }
}
