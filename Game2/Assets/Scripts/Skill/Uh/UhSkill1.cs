using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UhSkill1 : MonoBehaviour {
    GameObject Player;
    public GameObject Skill1;
    bool canuse;
	// Use this for initialization
	void Start () {
        Player = this.gameObject;
        canuse = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(canuse == true)
        {
            if(Player.gameObject.tag == "Player1")
            {
                if(Input.GetKeyDown(KeyCode.G))
                {
                    Skill1.tag = "P1Uh1";
                    if(Player.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Skill1, this.transform.position + new Vector3(0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                        StartCoroutine("Skill2cooltime");
                    }
                    else if(Player.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Skill1, this.transform.position + new Vector3(-0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-0.8f, 0.8f, 0);
                        StartCoroutine("Skill2cooltime");
                    }
                }
            }
            else if(Player.gameObject.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad2))
                {
                    Skill1.tag = "P2Uh1";
                    if (Player.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Skill1, this.transform.position + new Vector3(0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                        StartCoroutine("Skill2cooltime");
                    }
                    else if (Player.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Skill1, this.transform.position + new Vector3(-0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-0.8f, 0.8f, 0);
                        StartCoroutine("Skill2cooltime");
                    }
                }
            }
        }
	}
    IEnumerator Skill2cooltime()
    {
        canuse = false;
        yield return new WaitForSeconds(10);
        canuse = true;
    }
}
