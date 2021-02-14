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
            // Destroy(collision.gameObject);
            
            // Destroy Ourselves
            Destroy(this.gameObject);

            // Notify the target
            collision.gameObject.GetComponent<Animal>().Defeat();
        }

        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != this.gameObject.tag)
        {
            Destroy(this.gameObject);
        }
    }
}
