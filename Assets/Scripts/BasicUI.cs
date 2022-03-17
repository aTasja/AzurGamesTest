using System;
using Managers;
using UnityEngine;
using UnityEngine.UI;

public class BasicUI : MonoBehaviour
{
    [SerializeField] private Text _counter;
    [SerializeField] private GameObject _finishPanel;

    private void Start() => _finishPanel.SetActive(false);

    public void UpdateCounter(int number) => _counter.text = number.ToString();

    public void ShowFinishPanel() => _finishPanel.SetActive(true);

    public void NextLevelButtonHandler() => GameManager.LoadNextLevel();
}
