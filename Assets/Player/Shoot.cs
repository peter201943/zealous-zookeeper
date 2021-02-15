using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firepoint;
    public GameObject[] bulletPrefeb,BulletUIImage;
    public int BulletType = 1;
    public int[] RemainBullet;

    public Text[] BulletText;

    public float bulletforce = 20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255,255,255,100);
            BulletText[BulletType].color = new Color32(255, 255, 255, 100);
            BulletType = 0;
            BulletText[BulletType].color = new Color32(255, 255, 255, 255);
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            BulletText[BulletType].color = new Color32(255, 255, 255, 100);
            BulletType = 1;
            BulletText[BulletType].color = new Color32(255, 255, 255, 255);
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            BulletText[BulletType].color = new Color32(255, 255, 255, 100);
            BulletType = 2;
            BulletText[BulletType].color = new Color32(255, 255, 255, 255);
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            BulletText[BulletType].color = new Color32(255, 255, 255, 100);
            BulletType = 3;
            BulletText[BulletType].color = new Color32(255, 255, 255, 255);
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            BulletText[BulletType].color = new Color32(255, 255, 255, 100);
            BulletType = 4;
            BulletText[BulletType].color = new Color32(255, 255, 255, 255);
            BulletUIImage[BulletType].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && RemainBullet[BulletType] > 0)
        {
            RemainBullet[BulletType] = RemainBullet[BulletType] - 1;
            BulletText[BulletType].text = RemainBullet[BulletType].ToString();
            Shot();
        }


    }

    void Shot()
    {
       GameObject bullet = Instantiate(bulletPrefeb[BulletType], firepoint.position, firepoint.rotation);
      //  bullet.AddComponent<Bullet>();
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);

    }

    void ChangeBulletTypeImage()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            RemainBullet[2] = 10;
            BulletText[2].text = RemainBullet[2].ToString();
        }
        if (collision.tag == "Banana" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
            {
            RemainBullet[0] = 10;
            BulletText[0].text = RemainBullet[0].ToString();
        }

        if (collision.tag == "Berry" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            RemainBullet[1] = 10;
            BulletText[1].text = RemainBullet[1].ToString();
        }

     

        if (collision.tag == "Honey" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            RemainBullet[3] = 10;
            BulletText[3].text = RemainBullet[3].ToString();
        }

        if (collision.tag == "Carrot" && collision.gameObject.layer == LayerMask.NameToLayer("Supply"))
        {
            RemainBullet[4] = 10;
            BulletText[4].text = RemainBullet[4].ToString();
        }









    }
}
