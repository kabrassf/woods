using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mm : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject BackButton;
    public GameObject Text;

    public void ClickStart(){
        SceneManager.LoadScene(1);
    }

    public void ClickAbout(){
        Button1.SetActive(false);
        Button2.SetActive(false);
        BackButton.SetActive(true);
        Text.SetActive(true);
    }
    
    public void ClickBack(){
        Button1.SetActive(true);
        Button2.SetActive(true);
        BackButton.SetActive(false);
        Text.SetActive(false);
    }

}
