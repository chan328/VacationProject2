using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoSkill3 : MonoBehaviour {
    public GameObject Enemy;
    public bool CanUseskill3;
    public GameObject Skill3;
	// Use this for initialization
	void Start () {
        CanUseskill3 = true;
		if(gameObject.tag == "Player1")
        {
            Enemy = GameObject.FindGameObjectWithTag("Player2");
        }
        else if(gameObject.tag == "Player2")
        {
            Enemy = GameObject.FindGameObjectWithTag("Player1");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(CanUseskill3 == true)
        {
            if (this.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Skill3.tag = "P1Ho2";
                    StartCoroutine("Skill3_cool");
                    this.transform.position = Enemy.transform.position;
                    Instantiate(Skill3, this.transform.position, Quaternion.identity);
                }
            }
            else if (this.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad0))
                {
                    StartCoroutine("Skill3_cool");
                    Skill3.tag = "P2Ho2";
                    this.transform.position = Enemy.transform.position;
                    Instantiate(Skill3, this.transform.position, Quaternion.identity);
                }
            }
        }
	}
    IEnumerator Skill3_cool()
    {
        CanUseskill3 = false;
        yield return new WaitForSeconds(30);
        CanUseskill3 = true;
    }
}
