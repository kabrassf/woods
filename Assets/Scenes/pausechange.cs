using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausechange : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    public GameObject back;

    public bool PauseActive;

    public void Pause(){
        PauseActive = true;
        button.SetActive(false);
        text.SetActive(true);
        back.SetActive(true);
    }

    public void StopPause(){
        PauseActive = false;
        text.SetActive(false);
        back.SetActive(false);
        button.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseActive == false){
            text.SetActive(false);
            back.SetActive(false);
        }
    }
}
