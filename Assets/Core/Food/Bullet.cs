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
            // Destroy Ourselves
            Destroy(this.gameObject);

            // Notify the target (if it is an animal)
            try
            {
                collision.gameObject.GetComponent<Animal>().Defeat();
            }
            catch
            {
            }
        }

        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != this.gameObject.tag)
        {
            Destroy(this.gameObject);
        }
    }
}
