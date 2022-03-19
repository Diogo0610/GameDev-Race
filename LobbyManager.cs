using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private InputField roomInputField;
    [SerializeField] private GameObject lobbyPanel, roomPanel;
    public Text roomName;

    [SerializeField] private RoomSelect roomSelectPrefab;
    List<RoomSelect> roomItemsList = new List<RoomSelect>();
    [SerializeField] private Transform contentObject;

    float timeUpdate = 1.5f;
    float nextUpdateTime;

    [SerializeField] private GameObject playButton;
    [SerializeField] private Text errorPlayButton;

    public List<PlayerName> playerNamesList = new List<PlayerName>();
    public PlayerName playerNamePrefab;
    public Transform playerNameParent;

    public Text playButtonText;
    private bool canClickPlayButton;
    
    void Start()
    {
        PhotonNetwork.JoinLobby();
        canClickPlayButton = true;
    }

    private void Update()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            errorPlayButton.text = "";
            playButton.SetActive(true);
        }
        else if ((PhotonNetwork.IsMasterClient && PhotonNetwork.CurrentRoom.PlayerCount <= 2))
        {
            playButton.SetActive(false);
        }
        else
        {
            playButton.SetActive(false);
        }
    }

    public void OnClickCreate()
    {
        if (roomInputField.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(roomInputField.text, new RoomOptions { MaxPlayers = 4 });
        }
    }

    public void OnClickPlay()
    {
        if (canClickPlayButton)
        {
            PhotonNetwork.LoadLevel("Gameplay");
            playButtonText.text = Lean.Localization.LeanLocalization.GetTranslationText("Connect");
            canClickPlayButton = false;
        }
        
    }

    public override void OnJoinedRoom()
    {
        lobbyPanel.SetActive(false);
        roomPanel.SetActive(true);
        roomName.text = PhotonNetwork.CurrentRoom.Name;
        UpdatePlayerList();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        if (Time.time >= nextUpdateTime)
        {
            UpdateRoomList(roomList);
            nextUpdateTime = Time.time + timeUpdate;
        }
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        foreach (RoomSelect item in roomItemsList)
        {
            Destroy(item.gameObject);
        }
        roomItemsList.Clear();

        foreach (RoomInfo room in list)
        {
            RoomSelect newRoom = Instantiate(roomSelectPrefab, contentObject);
            newRoom.SetRoomName(room.Name);
            roomItemsList.Add(newRoom);
        }
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

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    public void OnClickLeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        roomPanel.SetActive(false);
        lobbyPanel.SetActive(true);
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
}
