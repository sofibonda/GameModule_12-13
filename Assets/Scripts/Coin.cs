using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _coin;

    private static int coinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coinCount++;
            Debug.Log($"Вы собрали {coinCount} монету!");
            Destroy(gameObject);
        }
    }
}
