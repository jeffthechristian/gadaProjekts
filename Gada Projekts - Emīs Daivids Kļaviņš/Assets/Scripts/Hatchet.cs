using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatchet : MonoBehaviour
{
    //What should happen when player is near the hatchet
    void OnTriggerEnter(Collider other) {
        HatchetFound.hatchet += 1;
        Destroy(gameObject);
    }
}
