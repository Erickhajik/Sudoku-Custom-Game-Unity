using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopMenuFunction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stopGameMain;
    public GameObject gameScreen;

    // public Animation stop;
    // Update is called once per frame

    public void stopTheGame()
    {
        gameScreen.SetActive(false);
        stopGameMain.SetActive(true);
        // stop.Play();
        GameTime.StopTimer();
       
            // GetComponent<Animator>().SetBool("MenuOpenClose",true);
        
    }

    public void resumeTheGame()
    {
        
        stopGameMain.SetActive(false);
        gameScreen.SetActive(true);
        // GameTime.UpdateTime();
        GameTime.ResumeTimer();
    }
    public void goMainMenu()
    {
        
        stopGameMain.SetActive(false);
        gameScreen.SetActive(false);
        GameTime.StopTimer();
    }
}
