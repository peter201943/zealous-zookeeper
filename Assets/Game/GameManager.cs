using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    [Header("Music to play throughout the game")]
    public List<AudioClip> musicTracks;
    private AudioSource music;
    private int currentClip;
    private int maxClip;

    void Start()
    {
        currentClip = 0;
        maxClip = musicTracks.Count;
        music = GetComponent<AudioSource>();
    }

    // Check if music has stopped playing
    // If it has, find the next track and play again
    void Update()
    {
        if (!music.isPlaying)
        {
            currentClip += 1;
            if (currentClip > maxClip)
            {
                currentClip = 0;
            }
            music.clip = musicTracks[currentClip];
            music.Play();
        }
    }
}
