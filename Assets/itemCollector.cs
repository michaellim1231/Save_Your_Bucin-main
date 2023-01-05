using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    [SerializeField] private AudioSource collect;
    private int coins = 0;
    [SerializeField] private Text coinScore;
   private void OnTriggerEnter2D(Collider2D collision)
   {
     if(collision.gameObject.CompareTag("Coin"))
     {
        collect.Play();
        Destroy(collision.gameObject);
        coins++;
        coinScore.text = "Coin: " + coins;

     }
   }
    
}
