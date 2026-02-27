using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeLeft = 60f;
    [SerializeField] private TMP_Text _timerText;

    private void Update()
    {
       if (GameManager.instance.IsGameEnded())
            return;

        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            if (_timerText != null)
                _timerText.text = "Время: " + Mathf.Round(_timeLeft).ToString();
        }
        else
        {
            _timeLeft = 0;
            GameManager.instance.EndGame(false); 
        }
    }
}
