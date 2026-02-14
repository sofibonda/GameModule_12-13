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
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _timerText.text = "Время: " + Mathf.Round(_timeLeft).ToString();
        }
        else
        {
            Debug.Log("Время вышло, вы проиграли!");
            _timeLeft = 0;
        }
    }
}
