using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource laugh1;

    //What should happen when player is near a coin
    void OnTriggerEnter(Collider other) {
        laugh1.Play();
        CoinSystem.theScore += 1;
        Destroy(gameObject);
    }
}
