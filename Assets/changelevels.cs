using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changelevels : MonoBehaviour
{
    // public Animation anim1;
    //
    // void Start()
    // {
    //     anim1 = gameObject.GetComponent<Animation>();
    // }
    // void Update()
    // {
    //     anim1.
    //     if (!anim1.isPlaying)
    //     {
    //         SceneManager.LoadScene("1");
    //     }
    //     
    // }
    public GameObject level;

    public void levelDisable()
    {
        level.SetActive(false);
    }
    public void MainMenu()
    {
        
        SceneManager.LoadSceneAsync("1");
    }   
    public void LoadMainMenu()
        {
            
            SceneManager.LoadSceneAsync("SudokuGame");
        }   
}
