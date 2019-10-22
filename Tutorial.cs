using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject tutorial;
    public GameObject pauseScreen;

    public void back(){
        tutorial.SetActive(false);
        mainScreen.SetActive(true);
    }
    public void tutorialOn(){
        tutorial.SetActive(true);
        pauseScreen.SetActive(false);
    }
    void Awake(){
        if (string.Compare(PlayerPrefs.GetString("tut","first"),"first") == 0){
            PlayerPrefs.SetString("tut", "done");
            tutorial.SetActive(true);
            mainScreen.SetActive(false);
        }
    }
}
