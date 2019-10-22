using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    Image sr;
    public Sprite blue;
    public Sprite red;
    public GameObject gm;
    public AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<Image>();
    }
    public void OnMouseDown() {
        if (sr.sprite == blue){
            sr.sprite = red;
        }
        else if (sr.sprite == red){
            sr.sprite = blue;
        }
        clickSound.Play();
        gm.GetComponent<GM>().rules(Int32.Parse(this.name));
        gm.GetComponent<GM>().movesInc();
        gm.GetComponent<GM>().checkWin();
    }
}
