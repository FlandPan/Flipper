using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject levelsUI;
    public GameObject optionsUI;
    public GameObject mainUI;

    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        System.Console.WriteLine("s");
    }
    public void levels(){
        mainUI.SetActive(false);
        levelsUI.SetActive(true);
    }
    public void options(){
        mainUI.SetActive(false);
        optionsUI.SetActive(true);
    }
}
