using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    SpriteRenderer sr;
    private GameObject gm; 
    public AudioClip clip;
    public AudioSource source;

    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameController");
        source = GetComponent<AudioSource>();
        source.clip = clip;
    }
    private void OnMouseDown() {
        source.Play();
        sr = GetComponent<SpriteRenderer>();
        if (sr.color == Color.red){
            sr.color = Color.green;
        }
        else{
            sr.color = Color.red;
        }
        
        //gm.GetComponent<Group>().group(sr.sortingOrder);
        //gm.GetComponent<Logic0>().addMove();
        //gm.GetComponent<Logic0>().checkFinished();
    }
}
