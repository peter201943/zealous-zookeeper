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
[RequireComponent(typeof(AnimalBehavior))]
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
    
    // TODO Move to AnimalBehavior and handle from there
    //public Collider2D detectionCircle;  // Trigger:  change state when in range
    
    // IMPLIED
    // public RigidBody rigidBody;      // Collider: stop on walls

    [Header("Delays")]
    public float moveSoundDelay;        // How frequently to play the move sound
    public float attackDelay;           // How quickly to attack
    public float spawnDelay;            // How long until start playing

    // Delay Trackers
    private float currentMoveSoundDelay;
    private float currentAttackDelay;
    private float currentSpawnDelay;

    // Sounds
    private AudioSource sounds;

    // States
    private AnimalState animalState;

    // Delegates
    // We delegate the AnimalBehavior for controlling
    // * Patrols * Attacks
    private AnimalBehavior animalBehavior;

    // What we attack when we find it
    private GameObject target;




    void Start()
    {
        // Sounds
        sounds = GetComponent<AudioSource>();
        sounds.PlayOneShot(spawnSound);

        // States
        animalState = AnimalState.Waiting;

        // Delegates
        animalBehavior = GetComponent<AnimalBehavior>();

        // Timers
        currentMoveSoundDelay   = 0.0f;
        currentAttackDelay      = 0.0f;
        currentSpawnDelay       = spawnDelay;

        // TEMP HACK DO NOT USE PERMANENTLY
    }




    void Update()
    {
        // Decrement All Timers
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

        // Check All Timers
        {
            // MoveSound
            if (currentMoveSoundDelay <= 0.0f)
            {
                // Do nothing if still spawning
                if (animalState != AnimalState.Waiting)
                {
                    sounds.PlayOneShot(moveSound);
                    currentMoveSoundDelay = moveSoundDelay;
                }
            }
        }

        // Manage State
        {
            // Delete if done Dying
            if (animalState == AnimalState.Defeated && !sounds.isPlaying)
            {
                Destroy(this);
            }

            // Don't do anything else if Dying
            if (animalState == AnimalState.Defeated)
            {
                return;
            }

            // Do nothing if still spawning
            if (animalState == AnimalState.Waiting)
            {
                return;
            }

            // More...
        }
    }





    private void OnTriggerEnter2D(Collider2D collision)
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
    private void Attack(GameObject targetObject)
    {
        sounds.PlayOneShot(attackSound);
        targetObject.GetComponent<PlayerMover>().Damage(attackDamage);
        currentAttackDelay = attackDelay;
    }



    /// <summary>
    /// Called from update
    /// Find paths
    /// TODO
    /// TODO move to AnimalBehavior
    /// </summary>
    private void Patrol()
    {

    }




    /// <summary>
    /// TODO move to AnimalBehavior
    /// </summary>
    private void Chase()
    {

    }
}
