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

    // Game Over Screen
    [Header("Activated on game loss")]
    public GameObject gameOverScreen;

    // Music
    private bool playMusic;

    void Start()
    {
        currentClip = 0;
        maxClip = musicTracks.Count;
        music = GetComponent<AudioSource>();
        music.volume = 0.3f;

        // Game Over Reset
        gameOverScreen.SetActive(false);

        // Music
        playMusic = true;
    }

    // Check if music has stopped playing
    // If it has, find the next track and play again
    void Update()
    {
        if (!music.isPlaying && playMusic)
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

    public void GameOver()
    {
        // TEMP Notice
        Debug.Log("GAME OVER");

        // Stop Music
        music.Stop();
        playMusic = false;

        // Play Game Over
        gameOverScreen.SetActive(true);
    }
}
