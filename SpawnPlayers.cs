using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(-12.297f, 6.89f, 0.13f);
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
