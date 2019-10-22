using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    //UI Screens
    public GameObject pauseUI;
    public GameObject mainScreen;
    public GameObject winUI;

    //Audio
    public AudioSource winSound;

    //Buttons and related
    public Button[] buttons = new Button[9];
    public int[] tiles;
    public GameObject buttonUI;
    public Sprite blue;
    public Sprite red;
    //Moves
    public Text moves;
    public Text moves2;
    public Text minText;
    private int moveCount = 0;

    void Awake() {
        setUp();
        pauseUI.SetActive(false);
    }
    private void setUp(){
        moveCount = 0;
        moves.text = "moves";
        for (int i = 0;i < tiles.Length;i ++){
            buttons[tiles[i]].image.sprite = blue;
        }
    }
    public void reset(){
        PlayerPrefs.DeleteAll();
    }
    //UI STUFF
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //setUp();
        //mainScreen.SetActive(true);
        //winUI.SetActive(false);
    }
    public void pauseButton(){
        pauseUI.SetActive(true);
        mainScreen.SetActive(false);
    }
    public void back(){
        pauseUI.SetActive(false);
        mainScreen.SetActive(true);
    }
    public void home(){
        SceneManager.LoadScene("Menu");
    }
    public void nextLevel(){
        Debug.Log("test");
        SceneManager.LoadScene(1 + SceneManager.GetActiveScene().buildIndex);
    }
    public void winScreen(){
        checkMin();
        mainScreen.SetActive(false);
        winUI.SetActive(true);
    }

    //BUTTON STUFF
    public void checkWin(){
        if (buttons[0].image.sprite == blue && buttons[1].image.sprite == blue && buttons[2].image.sprite == blue && buttons[3].image.sprite == blue && buttons[4].image.sprite == blue &&
        buttons[5].image.sprite == blue && buttons[6].image.sprite == blue && buttons[7].image.sprite == blue && buttons[8].image.sprite == blue){
            winSound.Play();
            winScreen();
        }
    }
    private void switchColor(int ind){
        if (buttons[ind].image.sprite == blue){
            buttons[ind].image.sprite = red;
        }
        else if (buttons[ind].image.sprite == red){
            buttons[ind].image.sprite = blue;
        }
    }
    public void rules(int ind){
        switch (ind){
            case 0:
                switchColor(1);
                switchColor(3);
                break;
            case 1:
                switchColor(0);
                switchColor(2);
                break;
            case 2:
                switchColor(1);
                switchColor(5);
                break;
            case 3:
                switchColor(0);
                switchColor(6);
                break;
            case 4:
                switchColor(1);
                switchColor(3);
                switchColor(5);
                switchColor(7);
                break;
            case 5:
                switchColor(2);
                switchColor(8);
                break;
            case 6:
                switchColor(3);
                switchColor(7);
                break;
            case 7:
                switchColor(6);
                switchColor(8);
                break;
            case 8:
                switchColor(7);
                switchColor(5);
                break;
            
        }
    }

    //MOVES STUFF
    public void movesInc(){
        moveCount ++;
        moves.text = "moves: " + moveCount;
    }
    public void checkMin(){
        if (PlayerPrefs.GetInt("min" + SceneManager.GetActiveScene().buildIndex, 10000) > moveCount){
            PlayerPrefs.SetInt("min" + SceneManager.GetActiveScene().buildIndex, moveCount);
        }
        moves2.text = "moves: " + moveCount;
        minText.text = "best: " + PlayerPrefs.GetInt("min" + SceneManager.GetActiveScene().buildIndex);
    }
}
