using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalObjective : MonoBehaviour
{

    public GameObject breadItem1;
    public GameObject CurrentObjective2Finished;
    public GameObject CurrentObjective2;
    public GameObject GameOver;
    public GameObject breadInfo2;
    public GameObject infoToStealBread;

    public static int breadAmount;

    //Set according UI texts as false at start
    void Start()
    {
        CurrentObjective2Finished.SetActive(false);
        GameOver.SetActive(false);
        breadInfo2.SetActive(false);
        infoToStealBread.SetActive(false);
    }

    // If player has collected bread, update UI texts
    void Update()
    {
        if (breadAmount == 1) {
            CurrentObjective2Finished.SetActive(true);
            CurrentObjective2.SetActive(false);
            GameOver.SetActive(true);
            breadInfo2.SetActive(false);
            infoToStealBread.SetActive(false);
        }
    }
}
