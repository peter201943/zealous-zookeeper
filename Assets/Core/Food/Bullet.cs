using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == this.gameObject.tag)
        {   
            // Notify World
            Debug.Log(collision.gameObject + ": Hit!");

            // Notify the target (if it is an animal)
            try
            {
                collision.gameObject.GetComponent<Animal>().Defeat();
            }
            catch
            {
                Debug.Log("Could Not Find Animal or Could not call Defeat");
            }

            // Destroy Ourselves
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != this.gameObject.tag)
        {
            // Destroy Ourselves
            Destroy(this.gameObject);
        }
    }
}
