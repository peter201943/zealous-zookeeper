using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    private bool game_not_end;
    private bool is_new_round;
    public GameObject bear;
    public GameObject rabbit;
    public GameObject monkey;
    public GameObject eagle;
    public GameObject deer;
    public int nub_animals;
    public List<GameObject> animals = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        nub_animals = 15;
        game_not_end = true;
        is_new_round = true;
        animals.Add(bear);
        animals.Add(rabbit);
        animals.Add(eagle);
        animals.Add(deer);
		animals.Add(monkey);
    }

    // Update is called once per frame
    void Update()
    {
        if (game_not_end) {
            if (is_new_round) {
                CreateAnimals();
            }
            if (GameObject.Find("Animal").transform.childCount <= 0) {
                nub_animals += 5;
                is_new_round = true;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            // Too much debug
            // Debug.Log(transform.position);
            GameObject animal_new = Instantiate(animals[Random.Range(0,4)], this.transform.position, new Quaternion(0f,0f,0f,0f));
            animal_new.transform.SetParent(GameObject.Find("Animal").transform);
        }
    }


    void ChangePosition() {
        float y_pos = Random.Range(-9.0f, 30.0f);
        float x_pos = Random.Range(75.0f, 117.0f);
        Vector3 new_pos = new Vector3(x_pos, y_pos, 0.0f);
        transform.position = new_pos;
    }
    void CreateAnimals() {
        if (GameObject.Find("Animal").transform.childCount < nub_animals)
        {
            ChangePosition();
        }
        else {
            is_new_round = false;
        }
    }
}
