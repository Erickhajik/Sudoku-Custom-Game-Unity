using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public Text nameMusic;
    public AudioSource m;
    private int playingMusic = 0;
    public AudioClip[] playlist1;
    void Start()
    {
        // playlist1[2].
        m = gameObject.GetComponent<AudioSource>();
        playaudio(playingMusic);
        nameMusic.text = playlist1[playingMusic].name;
    }

   

    public void playaudio(int a)
    {
        if (a < playlist1.Length)
        {
            m.clip = playlist1[a];
            m.Play();
            
        }
        else
        {
            playingMusic = 0;
        }
    }

    public void next()
    {
        playingMusic++;
        if (playingMusic > playlist1.Length-1)
        {
            playingMusic = 0;
        }

        nameMusic.text = playlist1[playingMusic].name;
        m.clip = playlist1[playingMusic];
        m.Play();
    }
    public void prev()
    {
        playingMusic--;
        if (playingMusic < 0)
        {
            playingMusic = playlist1.Length-1;
        }
        nameMusic.text = playlist1[playingMusic].name;
        m.clip = playlist1[playingMusic];
        m.Play();
    }

    public void stopPlay()
    {
        if (m.isPlaying)
        {
           
            m.Stop();
        }
        else if(!m.isPlaying)
        {
            m.Play();
        }
    }
}
