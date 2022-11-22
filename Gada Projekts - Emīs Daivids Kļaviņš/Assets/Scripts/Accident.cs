using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accident : MonoBehaviour
{

    public GameObject FirstObjective1;
    public GameObject Accident1;
    public GameObject Score1;

    public static int theScore;

    // Start is called before the first frame update
    void Start()
    {
        FirstObjective1.SetActive(true);
        Accident1.SetActive(false);
        Score1.SetActive(true);
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Player") {
            if (theScore == 10) {
                Accident1.SetActive(false);
            } else {
                Accident1.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider collision) {
        Accident1.SetActive(false);
    }
}
