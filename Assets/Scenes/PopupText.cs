using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupText : MonoBehaviour
{
    [SerializeField]
    Canvas messageCanvas;
    // Start is called before the first frame update
    void Start()
    {
        messageCanvas.enabled = false;
    }

    void OnTriggerEnter(Collider other){
        if (other.name == "elf demo"){
            TurnOnMessage();
        }
    }

    private void TurnOnMessage(){
        messageCanvas.enabled = true;
    }

    void OnTriggerExit(Collider other){
        if (other.name == "elf demo"){
            TurnOffMessage();
        }
    }

    private void TurnOffMessage(){
        messageCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
