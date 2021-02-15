using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D myrb;
    public Camera cam;
    Vector2 movement, mouseposition;

    void Start()
    {
        myrb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // float move;

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");


        mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    private void FixedUpdate()
    {
        myrb.MovePosition(myrb.position + movement * speed * Time.deltaTime);
        Vector2 lookDir = mouseposition - myrb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        myrb.rotation = angle;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            speed = speed * 0.5f;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            speed = speed * 2.0f;
        }

    }
}
