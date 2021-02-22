using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    private bool game_not_end;
    private bool is_new_round;
    private float time_round;
    private float time_round_current;
    public GameObject bear;
    public GameObject rabbit;
    public GameObject monkey;
    public GameObject eagle;
    public GameObject deer;
    public int nub_animals;
    public int nub_animals_total;
    public int nub_positions;
    public List<GameObject> animals = new List<GameObject>();
    public List<GameObject> positions = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        nub_animals_total = 0;
        time_round = 30.0f;
        time_round_current = time_round;
        nub_positions = GameObject.Find("Positions").transform.childCount;
        nub_animals = 5;
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
            if (time_round_current <= 0.0f)
            {
                time_round -= 5.0f;
                time_round_current = time_round;
                nub_animals += 5;
                is_new_round = true;
            }
            else {
                time_round_current -= Time.deltaTime;
            }
            if (GameObject.Find("Animal").transform.childCount <= 0 && nub_animals == 50) {
                SceneManager.LoadScene("EditedDesertLevel");
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Ground" && nub_animals < 49)
        {
            Debug.Log(transform.position);
            GameObject animal_new = Instantiate(animals[Random.Range(0,4)], this.transform.position, new Quaternion(0f,0f,0f,0f));
            nub_animals_total++;
            animal_new.transform.SetParent(GameObject.Find("Animal").transform);
        }
    }


    void ChangePosition() {
        int index = Random.Range(0, nub_positions -1);
        Vector3 new_pos = GameObject.Find("Positions").transform.GetChild(index).position;
        transform.position = new_pos;
    }
    void CreateAnimals() {
        if (GameObject.Find("Animal").transform.childCount < nub_animals)
        {
            ChangePosition();
            GameObject animal_new = Instantiate(animals[Random.Range(0, 4)], this.transform.position, new Quaternion(0f, 0f, 0f, 0f));
            nub_animals_total++;
            animal_new.transform.SetParent(GameObject.Find("Animal").transform);
        }
        else {
            is_new_round = false;
        }
    }
}
