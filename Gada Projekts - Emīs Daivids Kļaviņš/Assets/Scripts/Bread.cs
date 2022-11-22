using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour
{
    public bool isStolen = false;
    
    public GameObject breadInfo2;
    public GameObject infoToStealBread;

    //If player is near bread
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            isStolen = true;
            breadInfo2.SetActive(true);
        }
    }

    //If player goes away from bread
    void OnTriggerExit(Collider other) {
        breadInfo2.SetActive(false);
        isStolen = false;
    }

    //What should happen when player is near bread
    void Update() {
        if (isStolen == true) {
            if (CoinSystem.theScore == 10) {
                infoToStealBread.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E)) {
                    FinalObjective.breadAmount += 1;
                    Destroy(gameObject);
                }
            }
        } 
    }
}
