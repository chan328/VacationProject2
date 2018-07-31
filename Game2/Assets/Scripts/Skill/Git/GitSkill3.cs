using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitSkill3 : MonoBehaviour {
    public GameObject Skill3;
    public bool Can_Skill3;

	// Use this for initialization
	void Start () {
        Can_Skill3 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(Can_Skill3 == true)
        {
            if (this.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad0))
                {
                    StartCoroutine("shield");
                    Instantiate(Skill3, this.transform.position, Quaternion.identity);
                    StartCoroutine("Skill3_cooltime");
                }
            }
            if(this.tag == "Player1")
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    StartCoroutine("shield");
                    Instantiate(Skill3, this.transform.position, Quaternion.identity);
                    StartCoroutine("Skill3_cooltime");
                }
            }
        }
	}
    IEnumerator shield()
    {
        GitMove.Shield = true;
        yield return new WaitForSeconds(5);
        GitMove.Shield = false;
    }
    IEnumerator Skill3_cooltime()
    {
        Can_Skill3 = false;
        yield return new WaitForSeconds(30);
        Can_Skill3 = true;
    }
}
