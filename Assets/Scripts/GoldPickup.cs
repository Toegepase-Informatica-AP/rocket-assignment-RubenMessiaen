using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{

    public ScoreManager scoreManager;


    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        scoreManager.Score++;
    }
}
