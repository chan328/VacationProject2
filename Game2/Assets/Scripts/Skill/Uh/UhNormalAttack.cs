using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UhNormalAttack : MonoBehaviour {
    public GameObject Player;
    public GameObject Skill0;
    bool CanAttack;   
	// Use this for initialization
	void Start () {
        Player = this.gameObject;
        CanAttack = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(CanAttack == true)
        {
            if (Player.gameObject.tag == "Player1")
            {
                Skill0.tag = "P1Uh0";
                if(Input.GetKeyDown(KeyCode.F))
                {
                    if(Player.transform.localScale.x > 0)
                    {                                           
                        GameObject attack = Instantiate(Skill0, this.transform.position + new Vector3(0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                        StartCoroutine("Normal");
                    }
                    else if(Player.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Skill0, this.transform.position + new Vector3(-0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-0.8f, 0.8f, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
            else if (Player.gameObject.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad1))
                {
                    Skill0.tag = "P2Uh0";
                    if (Player.transform.localScale.x > 0)
                    {                       
                        GameObject attack = Instantiate(Skill0, this.transform.position + new Vector3(0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                        StartCoroutine("Normal");
                    }
                    else if (Player.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Skill0, this.transform.position + new Vector3(-0.5f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-0.8f, 0.8f, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
        }
	}
    IEnumerator Normal()
    {
        CanAttack = false;
        yield return new WaitForSeconds(0.3f);
        CanAttack = true;
    }
}
