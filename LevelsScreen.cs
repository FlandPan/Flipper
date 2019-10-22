using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsScreen : MonoBehaviour
{
    public GameObject levelsUI;
    public GameObject main;

    private void Awake() {
        levelsUI = this.gameObject;
    }
    public void back(){
        main.SetActive(true);
        levelsUI.SetActive(false);
    }
    public void levelSelect(int levelN){
        SceneManager.LoadScene(levelN);
    }

}
