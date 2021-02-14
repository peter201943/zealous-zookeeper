using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum PlayerState
{
    // Player is Active in the game
    Alive,
    // Player has been slain and effects are still playing out
    Defeated
}


public class PlayerMover : MonoBehaviour
{



    [Header("Interaction")]
    public float moveSpeed;

    [Header("Sounds")]
    public AudioClip attackSound;
    public AudioClip moveSound;
    public AudioClip spawnSound;
    public AudioClip defeatSound;

    [Header("Delays")]
    public float moveSoundDelay;        // How frequently to play the move sound

    // [Header("Collision")]
    // public RigidBody rigidBody;      // Collider: stop on walls

    // Delay Trackers
    protected float currentMoveSoundDelay;

    // Sounds
    protected AudioSource sounds;

    // Health
    public float health;
    protected float currentHealth;

    // State
    protected PlayerState playerState;

    protected void Start()
    {
        // Health
        currentHealth = health;

        // State
        playerState = PlayerState.Alive;
    }

    protected void Update()
    {
        // Do not delete the player

        // Do nothing if dying
        if (playerState == PlayerState.Defeated)
        {
            return;
        }


        // Check if Dead
        if (currentHealth < 0.0f)
        {
            Defeat();
        }
    }

    protected void Defeat()
    {
        sounds.PlayOneShot(defeatSound);
        playerState = PlayerState.Defeated;
        
        // Notify GameManager of Game Over
        // gameManager.PlayerDefeated();
        // TODO
    }

    public void Damage(float amount)
    {
        currentHealth -= amount;
    }

    protected void Attack()
    {
        // Just handles effects?
    }
}
