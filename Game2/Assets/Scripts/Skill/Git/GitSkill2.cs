using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitSkill2 : MonoBehaviour {
    public bool CanUse_Skill2;
    public GameObject Rush;
    Rigidbody2D RB;
	// Use this for initialization
	void Start () {
		Rush = transform.GetChild(1).gameObject;
		RB = gameObject.GetComponent<Rigidbody2D>();
		GitMove gitmove = this.GetComponent<GitMove>();
        CanUse_Skill2 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(CanUse_Skill2 == true)
        {
            if (this.gameObject.tag == "Player1")
            {
                if (Input.GetKey(KeyCode.H))
                {
                    StartCoroutine("rush");
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Keypad3))
                {
                    StartCoroutine("rush");
                }

            }
        }
	}
	IEnumerator rush()
	{
		GitMove gitmove = this.GetComponent<GitMove>();
        CanUse_Skill2 = false;
		Rush.SetActive(true);			
		gitmove.movePower = 7f;
		yield return new WaitForSeconds(5);
		gitmove.movePower = 3f;
		Rush.SetActive(false);
        StartCoroutine("Skill2cooltime");
	}
    IEnumerator Skill2cooltime()
    {
        yield return new WaitForSeconds(12);
        CanUse_Skill2 = true;
    }
}
