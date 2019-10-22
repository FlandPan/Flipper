using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsScreen : MonoBehaviour
{
    private GameObject music;
    public GameObject screen;
    public GameObject main;
    public GameObject credit;
    public GameObject howto;
    public Sprite current;
    public Button i;
    private bool on = true;

    
    private void Awake() {
        screen = this.gameObject;
        music = GameObject.FindGameObjectWithTag("Music");
    }
    public void mute(Sprite imageToggle_X){
        music.GetComponent<AudioSource>().mute = !music.GetComponent<AudioSource>().mute;
        if (on){
            i.image.sprite = imageToggle_X;
            on = false;
        }
        else{
            i.image.sprite = current;
            on = true;
        }
    }
    public void back(){
        main.SetActive(true);
        screen.SetActive(false);
    }
    public void credits(){
        screen.SetActive(false);
        credit.SetActive(true);
    }
    public void help(){
        howto.SetActive(true);
        screen.SetActive(false);
    }
    public void backToCredits(){
        screen.SetActive(true);
        credit.SetActive(false);
    }
}
