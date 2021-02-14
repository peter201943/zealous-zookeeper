using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// Finite State Machine States for the Animals
/// </summary>
public enum AnimalState
{
    // We just spawned in and our waiting to play
    Waiting,
    // We are out searching for the player
    Patrolling,
    // We have spotted the player and are moving towards them
    // Once we have started chasing, we cannot stop chasing
    Chasing,
    // We have been slain and are waiting for effects to end
    Defeated
}




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
    public Collider2D attackCircle;     // Trigger:  attack when in range
    public Collider2D detectionCircle;  // Trigger:  change state when in range
    // public RigidBody rigidBody;      // Collider: stop on walls

    [Header("Delays")]
    public float moveSoundDelay;        // How frequently to play the move sound
    public float attackDelay;           // How quickly to attack
    public float spawnDelay;            // How long until start playing

    // Delay Trackers
    protected float currentMoveSoundDelay;
    protected float currentAttackDelay;
    protected float currentSpawnDelay;

    // Sounds
    protected AudioSource sounds;

    // States
    protected AnimalState animalState;




    protected void Start()
    {
        // Sounds
        sounds = GetComponent<AudioSource>();
        sounds.PlayOneShot(spawnSound);

        // States
        animalState = AnimalState.Waiting;

        // Timers
        currentMoveSoundDelay   = 0.0f;
        currentAttackDelay      = 0.0f;
        currentSpawnDelay       = 0.0f;
    }




    protected void Update()
    {
        // Update All Timers
        {
            // MoveSound
            if (currentMoveSoundDelay > 0.0f)
            {
                currentMoveSoundDelay -= Time.deltaTime;
            }
            // Attack
            if (currentAttackDelay > 0.0f)
            {
                currentAttackDelay -= Time.deltaTime;
            }
            // Spawn
            if (currentSpawnDelay > 0.0f)
            {
                currentSpawnDelay -= Time.deltaTime;
            }
        }

        // Delete if done Dying
        if(animalState == AnimalState.Defeated && !sounds.isPlaying)
        {
            Destroy(this);
        }

        // Don't do anything else if Dying
        if (animalState == AnimalState.Defeated)
        {
            return;
        }

        // More...
    }





    protected void OnTriggerEnter2D(Collider2D collision)
    {
        // If collision is player and we are the awareness circle and we are patrolling
        // chase them
        
        // If collision is player and we are the attack circle and attack delay is done
        // attack them
    }






    /// <summary>
    /// Anyone can call this
    /// </summary>
    public void Defeat()
    {
        sounds.PlayOneShot(defeatSound);
        animalState = AnimalState.Defeated;
    }




    /// <summary>
    /// Only we can choose to attack
    /// </summary>
    protected void Attack(GameObject playerObject)
    {
        sounds.PlayOneShot(attackSound);
        playerObject.GetComponent<PlayerMover>().Damage(attackDamage);
    }




    private void Patrol()
    {

    }




    private void Chase()
    {

    }
}
