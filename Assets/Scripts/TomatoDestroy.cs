using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TomatoDestroy : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameObject.SetActive(false);

            ScoreManager.instance.AddPoint();
            Invoke("newVoid", 3);
        }
    }
   
    void newVoid()
    {
        gameObject.SetActive(true);
    } 
}

