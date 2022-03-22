using System;
using System.Collections;
using System.Net.Mime;
using Player;
using UnityEngine;
using UnityEngine.UI;

public class CoinsScoreboard : MonoBehaviour
{
    private Text _coinsCounter;
    
    private void OnEnable() => PlayerPurse.CoinCollected += UpdateCounter;
    
    private void Start()
    {
        _coinsCounter = GetComponent<Text>();
        UpdateCounter(0);
    }

    private void UpdateCounter(int number) => _coinsCounter.text = number.ToString();

    private void OnDisable() => PlayerPurse.CoinCollected -= UpdateCounter;

}