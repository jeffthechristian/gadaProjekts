using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public static int theScore;

    public GameObject scoreText;
    public GameObject CurrentObjective1;
    public GameObject Score1;
    public GameObject CurrentObjectiveFinished1;
    public GameObject CurrentObjective2;

    //Set UI texts as false at start
    void Start() {
        CurrentObjectiveFinished1.SetActive(false);
        CurrentObjective2.SetActive(false);
    }

    void Update() {
        //UI for player to see how many coins they have collected
        scoreText.GetComponent<Text>().text = "Coins found: " + theScore + "/10";

        //If player has collected all coins, update UI texts
        if (theScore == 10) {
            CurrentObjective1.SetActive(false);
            CurrentObjectiveFinished1.SetActive(true);
            CurrentObjective2.SetActive(true);
        }
    }
}
