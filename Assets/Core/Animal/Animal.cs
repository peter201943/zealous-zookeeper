using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




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
/// <see href="https://www.youtube.com/watch?v=W-NIYi1t16Q">Simple 2D Pathfinding In 4 Lines Of Code! | Unity Tutorial</see>
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


    // REMOVED, no sensory code in use
    // // TODO Move to AnimalBehavior and handle from there
    // // public Collider2D detectionCircle;  // Trigger:  change state when in range

    // NOT IN USE
    // // IMPLIED
    // // public RigidBody rigidBody;      // Collider: stop on walls

    [Header("Delays")]
    public float moveSoundDelay;        // How frequently to play the move sound
    public float attackDelay;           // How quickly to attack
    public float spawnDelay;            // How long until start playing
    public float deathDelay;            // How long until deletion
    public float navDelay = 1.0f;       // How frequently we update our path

    // Delay Trackers
    private float currentMoveSoundDelay;
    private float currentAttackDelay;
    private float currentSpawnDelay;
    private float currentDeathDelay;
    private float currentNavDelay;

    // Sounds
    private AudioSource sounds;

    // States
    private AnimalState animalState;

    // NOT IN USE
    // // Delegates
    // // We delegate the AnimalBehavior for controlling
    // // * Patrols * Attacks
    // private AnimalBehavior animalBehavior;

    // What we attack when we find it
    private Transform target;

    // What we move with
    private NavMeshAgent navAgent;



    /// <see href="https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html">GameObject.FindGameObjectsWithTag</see>
    void Start()
    {
        // Sounds
        sounds = GetComponent<AudioSource>();
        sounds.PlayOneShot(spawnSound);

        // States
        animalState = AnimalState.Waiting;

        // NOT IN USE
        // // Delegates
        // animalBehavior = GetComponent<AnimalBehavior>();

        // Timers
        currentMoveSoundDelay   = 0.0f;
        currentAttackDelay      = 0.0f;
        currentSpawnDelay       = spawnDelay;
        currentDeathDelay       = deathDelay;
        currentNavDelay         = navDelay;

        // NOT IN USE?
        // // TEMP HACK DO NOT USE PERMANENTLY

        // (Try to) Find the Player at Startup
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length > 0)
        {
            target = players[0].transform;
        }
    }




    void Update()
    {
        // Slowly decrement all timers
        DecrementAllTimers();

        // Manage State
        {
            // Delete if done Dying
            if (animalState == AnimalState.Defeated && currentDeathDelay <= 0.0f)
            {
                Destroy(gameObject);
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
            // Spawn
            if (currentSpawnDelay <= 0.0f)
            {
                animalState = AnimalState.Patrolling;
            }
        }

        // Look for player (if missing)
        if (!target)
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            if (players.Length > 0)
            {
                target = players[0].transform;
            }
        }

        // Update Path every once in a while
        if (currentNavDelay <= 0.0f)
        {
            // Find New Path
            navAgent.SetDestination(target.position);

            // Reset Timer
            currentNavDelay = navDelay;
        }
    }




    /// <summary>
    /// Resets al lof the timers until they hit zero
    /// </summary>
    private void DecrementAllTimers()
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
        if (animalState == AnimalState.Waiting && currentSpawnDelay > 0.0f)
        {
            currentSpawnDelay -= Time.deltaTime;
        }
        // Death
        if (animalState == AnimalState.Defeated && currentDeathDelay > 0.0f)
        {
            currentDeathDelay -= Time.deltaTime;
        }
        // Nav Delay
        if (currentNavDelay > 0.0f)
        {
            currentNavDelay -= Time.deltaTime;
        }
    }





    // NOT IN USE
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     // If collision is player and we are the awareness circle and we are patrolling
    //     // chase them
    //     
    //     // If collision is player and we are the attack circle and attack delay is done
    //     // attack them
    // }





    /// <summary>
    /// When enemy bumps into player
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If collision is player and we are the attack circle and attack delay is done
        if (collision.gameObject.tag == "Player" && currentAttackDelay <= 0.0f)
        {
            try
            {
                // attack them
                collision.gameObject.GetComponent<PlayerMover>().Damage(attackDamage);

                // reset timer
                currentAttackDelay = attackDelay;
            }
            catch
            {
                Debug.Log("Could not attack player");
            }
        }

    }






    /// <summary>
    /// Anyone can call this
    /// </summary>
    public void Defeat()
    {
        if (animalState == AnimalState.Defeated)
        {
            return;
        }
        Debug.Log(gameObject.name + ": DEFEATED");
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



    // NOT IN USE
    // /// <summary>
    // /// Called from update
    // /// Find paths
    // /// TODO
    // /// TODO move to AnimalBehavior
    // /// </summary>
    // private void Patrol()
    // {
    // 
    // }



    // NOT IN USE
    // /// <summary>
    // /// TODO move to AnimalBehavior
    // /// </summary>
    // private void Chase()
    // {
    // 
    // }
}
