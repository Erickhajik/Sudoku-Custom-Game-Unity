using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changelevels : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("SudokuGame");
    }   
}
