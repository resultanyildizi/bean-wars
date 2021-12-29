using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DinowarsNetworkGamePlayer : NetworkBehaviour
{
    [SyncVar]
    private string displayName = "Loading...";
    [SyncVar]
    private DinowarsNetworkRoomPlayer.Dino dino = DinowarsNetworkRoomPlayer.Dino.None;
    [SyncVar]
    private DinowarsNetworkRoomPlayer.Team team = DinowarsNetworkRoomPlayer.Team.None;
    [SyncVar] private int killed = 0;

    [SyncVar] private int death = 0;


    public DinowarsNetworkRoomPlayer.Team Team { get => team; set => team = value; }
    public DinowarsNetworkRoomPlayer.Dino Dino { get => dino; set => dino = value; }
    public string DisplayName { get => displayName; set => displayName = value; }
    public int Killed { get => killed; }
    public int Death { get => death; }

    public override void OnStartClient()
    {
        DontDestroyOnLoad(this);
        DinowarsNetworkManager.Instance.AddGamePlayer(this);

    }

    [Server]
    public void SetPlayer(string displayName, DinowarsNetworkRoomPlayer.Team team, DinowarsNetworkRoomPlayer.Dino dino)
    {
        Debug.Log("Setting player");
        this.displayName = displayName;
        this.team = team;
        this.dino = dino;
        this.death = 0;
        this.killed = 0;
    }

    public void IncreaseKill() => CmdUpdateKill(killed + 1);
    public void IncreaseDeath() => CmdUpdateDeath(death + 1);


    [Command(requiresAuthority = false)]
    private void CmdUpdateKill(int newKilled)
    {
        killed = newKilled;
    }
    [Command(requiresAuthority = false)]
    private void CmdUpdateDeath(int newDeath)
    {
        death = newDeath;
    }
}
