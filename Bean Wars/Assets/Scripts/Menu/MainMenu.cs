using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private NetworkManager networkManagerLobby;
    [Header("Menu UI")]
    [SerializeField] private GameObject landingPanelUI;


    public void HostLobby()
    {
        networkManagerLobby?.StartHost();
        Debug.Log("Host started");
        landingPanelUI.SetActive(false);
    }
}
