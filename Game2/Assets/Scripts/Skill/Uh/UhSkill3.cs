using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UhSkill3 : MonoBehaviour {
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
                if (this.gameObject.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        Instantiate(Skill3, this.transform);
                        Skill3.transform.localScale = new Vector3(1, 1, 1);
                        StartCoroutine("Skillcool");
                    }
                    else
                    {
                        Instantiate(Skill3, this.transform);
                        Skill3.transform.localScale = new Vector3(-1, -1, -1);
                        StartCoroutine("Skillcool");
                    }
                }
                else if (this.gameObject.tag == "Player2")
                {
                    if(Input.GetKeyDown(KeyCode.Keypad0))
                    {
                        if (this.transform.localScale.x > 0)
                        {
                            Instantiate(Skill3, this.transform);
                            Skill3.transform.localScale = new Vector3(1, 1, 1);
                            StartCoroutine("Skillcool");
                        }
                        else
                        {
                            Instantiate(Skill3, this.transform);
                            Skill3.transform.localScale = new Vector3(-1, -1, -1);
                            StartCoroutine("Skillcool");
                        }
                    }
                }
            }
        }
	}
    IEnumerator Skillcool()
    {
        canuse = false;
        yield return new WaitForSeconds(20);
        canuse = true;
    }
}
