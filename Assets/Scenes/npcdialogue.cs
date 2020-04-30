using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcdialogue : MonoBehaviour
{
    public GameObject text;
    public GameObject choice1;
    public GameObject choice2;
    public bool Seen;
    
    public void Choice1Text(){
        text.GetComponent<Text>().text = "Great, thank you so much!";
        Seen = true;
    }
    public void Choice2Text(){
        text.GetComponent<Text>().text = "What do you mean? Don't worry about that right now!";
        Seen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Seen){
            choice1.SetActive(false);
            choice2.SetActive(false);
        }
    } // end update
}
