using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTer : MonoBehaviour
{
    // Start is called before the first frame update
    public float SlowSpeed = 3f;
    private float PlayerOriginSpeed = 5f;
    public PlayerController PC;
    public bool slowed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && slowed == false)
        {
            PlayerOriginSpeed = PC.speed;
           PC.speed = SlowSpeed;
            slowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(PlayerOriginSpeed);
       
        if (collision.tag == "Player")
        {
            Debug.Log(PlayerOriginSpeed);
           PC.speed = PlayerOriginSpeed;
            slowed = false;
        }
    }
}
