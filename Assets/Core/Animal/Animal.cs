using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generic Class for All Animals
/// Each Animal must define its own PathFindingBehavior
/// This only includes the basics:
/// * Wakeup (On Spawn)
/// * Detection (Of Player)
/// * Death
/// * State Management (Via Animation)
/// </summary>
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Collider2D))]
public class Animal : MonoBehaviour
{



    [Header("Interaction")]
    public float moveSpeed;
    public float attackDamage;

    [Header("Sounds")]
    public AudioClip attackSound;
    public AudioClip moveSound;
    public AudioClip spawnSound;
    public AudioClip defeatSound;

    [Header("Collision")]
    public Collider2D attackCircle;
    public Collider2D detectionCircle;

    // Sounds
    private AudioSource sounds;

    // States
    private bool isDefeated;
    private bool isAware;
    private bool isPatrolling;




    void Start()
    {
        // Sounds
        sounds = GetComponent<AudioSource>();
        sounds.PlayOneShot(spawnSound);

        // States
        isDefeated   = false;
        isAware      = false;
        isPatrolling = false;
    }
    



    void Update()
    {
        // Die
        if(isDefeated && !sounds.isPlaying)
        {
            Destroy(this);
        }

        // Don't do anything
        if (isDefeated)
        {
            return;
        }

        // More...
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO
    }






    public void Defeat()
    {
        sounds.PlayOneShot(defeatSound);
        isDefeated = true;
    }




    private void Attack()
    {

    }




    private void Patrol()
    {

    }




    private void Chase()
    {

    }
}
