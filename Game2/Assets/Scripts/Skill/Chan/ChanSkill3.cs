using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanSkill3 : MonoBehaviour {
	public GameObject Skill3;
	bool canuse;
	// Use this for initialization
	void Start () {
		canuse = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(canuse == true)
		{
			if(gameObject.tag == "Player1")
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
					Skill3.tag = "P1Chan3";
                    GameObject attack = Instantiate(Skill3, this.transform.position, Quaternion.identity);
                    StartCoroutine("Skill3cooltime");                   
                }
            }
            else if(gameObject.tag == "Player2")
            {	
				if(Input.GetKeyDown(KeyCode.Keypad0))
				{
					Skill3.tag = "P2Chan3";
                	GameObject attack = Instantiate(Skill3, this.transform.position, Quaternion.identity);
                	StartCoroutine("Skill3cooltime");
                }
            }
		}
	}
	IEnumerator Skill3cooltime()
    {
        canuse = false;
        yield return new WaitForSeconds(20);
        canuse = true;
    }
}
