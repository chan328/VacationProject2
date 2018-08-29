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
                        StartCoroutine("Skillcool");
                    }
                    else if (this.transform.localScale.x < 0)
                    {
                        Instantiate(Skill3, this.transform);
                        StartCoroutine("Skillcool");
                    }
                }
            }
            else if (this.gameObject.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad0))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        Instantiate(Skill3, this.transform);
                        StartCoroutine("Skillcool");
                    }
                    else if (this.transform.localScale.x < 0)
                    {
                        Instantiate(Skill3, this.transform);
                        StartCoroutine("Skillcool");
                    }
                }
            }           
        }
	}
    IEnumerator Skillcool()
    {
        canuse = false;
        yield return new WaitForSeconds(0);
        canuse = true;
    }
}
