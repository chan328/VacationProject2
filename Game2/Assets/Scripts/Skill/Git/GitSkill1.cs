using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitSkill1 : MonoBehaviour {
    public GameObject skill1;
    public bool Canuse_Skill1;

	// Use this for initialization
	void Start () {
        Canuse_Skill1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag == "Player1")
        {
            if(Canuse_Skill1 == true)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    skill1.tag = "P1Git1";
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject skillone = Instantiate(skill1, this.transform.position, Quaternion.identity);
                        skillone.transform.localScale = new Vector3(1, 1, 1);
                        StartCoroutine("Skill1Cool");
                    }
                    else
                    {
                        GameObject skillone = Instantiate(skill1, this.transform.position, Quaternion.identity);
                        skillone.transform.localScale = new Vector3(-1, -1, -1);
                        StartCoroutine("Skill1Cool");
                    }
                }
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Keypad2))
            {
                if(Canuse_Skill1 == true)
                {
                    skill1.tag = "P2Git1";
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject skillone = Instantiate(skill1, this.transform.position, Quaternion.identity);
                        skillone.transform.localScale = new Vector3(1, 1, 1);
                        StartCoroutine("Skill1Cool");
                    }
                    else
                    {
                        GameObject skillone = Instantiate(skill1, this.transform.position, Quaternion.identity);
                        skillone.transform.localScale = new Vector3(-1, -1, -1);
                        StartCoroutine("Skill1Cool");
                    }
                }
            }
        }
	}
    IEnumerator Skill1Cool()
    {
        Canuse_Skill1 = false;
        yield return new WaitForSeconds(5);
        Canuse_Skill1 = true;
    }
}
