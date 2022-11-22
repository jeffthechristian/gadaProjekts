using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatchetFound : MonoBehaviour {

    public static int hatchet;
    public bool IsDestroyed = false;

    public GameObject hatchetText;
    public GameObject SideQuest1Finished;
    public GameObject SideQuest2Finished;
    public GameObject SideQuest1;
    public GameObject SideQuest2;
    public GameObject CurrentSidequest;
    public GameObject CrossObject;
    public GameObject CrossInteraction1;
    public GameObject InstructionCross;

    //Set all UI texts as false at start
    void Start()
    {
        CrossInteraction1.SetActive(false);
        SideQuest2.SetActive(false);
        SideQuest1.SetActive(false);
        CurrentSidequest.SetActive(false);
        SideQuest1Finished.SetActive(false);
        SideQuest2Finished.SetActive(false);
        hatchetText.SetActive(false);
        InstructionCross.SetActive(false);
    }

    void OnTriggerEnter(Collider collision) {
        //If player collides with the trigger make first side quest active
        if (collision.gameObject.tag == "Player") {
            SideQuest1.SetActive(true);
            //If player has a hatchet active instructions to destroy the cross,
            //disable info text
            if (hatchet == 1) {
                InstructionCross.SetActive(true);
                CrossInteraction1.SetActive(false);
            //If player doesn't have a hatchet activate:
            //info text when near cross
            //current sidequest
            //UI telling if player has a hatchet or not
            } else {
                CrossInteraction1.SetActive(true);
                CurrentSidequest.SetActive(true);
                hatchetText.SetActive(true);
            // If cross is destroyed then:
            //Info text, side quest 2 and instruction how to destroy cross is disabled
            } if (IsDestroyed == true) {
                InstructionCross.SetActive(false);
                CrossInteraction1.SetActive(false);
                SideQuest2.SetActive(false);
            }
        }
    }
    //If player leaves triggeer area then disable:
    //Info text, Instruction how to destroy cross
    void OnTriggerExit(Collider collision) {
        CrossInteraction1.SetActive(false);
        InstructionCross.SetActive(false);
    }

    void Update() {
        //UI for player to see if they have a hatchet or not
        hatchetText.GetComponent<Text>().text = "Hatchet: " + hatchet;
        //If player has a hatchet:
        //Activate Side Quest 2
        //Disable first side quest and activate side quest 1 finished text
        if (hatchet == 1) {
            SideQuest2.SetActive(true);
            SideQuest1.SetActive(false);
            SideQuest1Finished.SetActive(true);
            //If player presses E and has a hatchet:
            //Corss falling animation, remove hatchet and set as true isDestroyed
            //Set according UI texts as false or true depending
            //Which quests are finished and which texts shouldn't appear anymore
            if (Input.GetKeyDown(KeyCode.E)) {
                IsDestroyed = true;
                CrossInteraction1.SetActive(true);
                SideQuest2.SetActive(false);
                SideQuest2Finished.SetActive(true);
                hatchet--;
                hatchetText.SetActive(false);
                CrossObject.GetComponent<Animator>().Play("CrossFalling");
            }
        }
    }
}