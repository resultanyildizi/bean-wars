using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinowarsScoreBoard : MonoBehaviour
{
    [SerializeField] private Text teamAScore;
    [SerializeField] private Text teamBScore;
    [SerializeField] private TeamScoreCard[] teamAScoreCards;
    [SerializeField] private TeamScoreCard[] teamBScoreCards;

    private void OnEnable() => UpdateScoreCards();

    private void UpdateScoreCards()
    {
        ResetCards();

        for (int i = 0; i < DinowarsNetworkManager.Instance.TeamAGamePlayers.Count; i++)
        {
            var gamePlayer = DinowarsNetworkManager.Instance.TeamAGamePlayers[i];
            teamAScoreCards[i].UpdateCard(gamePlayer.DisplayName, gamePlayer.Killed, gamePlayer.Death);
        }

        for (int i = 0; i < DinowarsNetworkManager.Instance.TeamBGamePlayers.Count; i++)
        {
            var gamePlayer = DinowarsNetworkManager.Instance.TeamBGamePlayers[i];
            teamBScoreCards[i].UpdateCard(gamePlayer.DisplayName, gamePlayer.Killed, gamePlayer.Death);
        }

    }

    public void ResetCards()
    {
        foreach (var card in teamAScoreCards) card.ResetCard();
        foreach (var card in teamBScoreCards) card.ResetCard();
    }

    // void Start()
    // {

    // }


    // void Update()
    // {

    // }
}
