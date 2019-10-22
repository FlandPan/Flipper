using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToButton : MonoBehaviour
{
    public GameObject howto;
    public GameObject home;
    public void click(){
        howto.SetActive(false);
        home.SetActive(true);
    }
}
