using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
   [SerializeField] private TMP_Text _winText;
    private int coinCount = 0;
    private int totalCoins;
    private bool gameEnded = false;

    private void Awake()
    {
        instance = this;

        totalCoins = FindObjectsOfType<Coin>().Length;
        Debug.Log("Всего монет: " + totalCoins);
    }

    public void AddCoin()
    {
      if (gameEnded) return;

        coinCount++;
        Debug.Log("Монет собрано: " + coinCount);

        if (coinCount >= totalCoins)
        {
         EndGame(true);
        }
    }

    public void EndGame(bool win)
    {
        if (gameEnded) return;

        gameEnded = true;

        Time.timeScale = 0f; 

        if (_winText != null)
        {
            _winText.gameObject.SetActive(true);
            _winText.text = win ? "Поздравляем, вы победили!" : "Время вышло! Вы проиграли!";
        }
    }

    public bool IsGameEnded()
    {
        return gameEnded;
    }
}
