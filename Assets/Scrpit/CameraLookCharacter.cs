using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, this.gameObject.transform.position.z);

    }
}
