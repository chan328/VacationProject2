﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitNormalAtk : MonoBehaviour {
    public bool Can_NormalAttack;
    public GameObject GitAttack;
	// Use this for initialization
	void Start () {
        Can_NormalAttack = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag == "Player1")
        {
            GitAttack.tag = "P1Git0";
            if(Input.GetKeyDown(KeyCode.F))
            {
                if(Can_NormalAttack == true)
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(GitAttack, this.transform.position + new Vector3(0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(1, 1, 0);
                        StartCoroutine("Normal");
                    }
                    else
                    {
                        GameObject attack = Instantiate(GitAttack, this.transform.position + new Vector3(-0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-1, 1, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
        }
    else if(this.tag == "Player2")
        {
            GitAttack.tag = "P2Git0";
            if(Input.GetKeyDown(KeyCode.Keypad1))
            {
                if(Can_NormalAttack == true)
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(GitAttack, this.transform.position + new Vector3(0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(1, 1, 0);
                        StartCoroutine("Normal");
                    }
                    else
                    {
                        GameObject attack = Instantiate(GitAttack, this.transform.position + new Vector3(-0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-1, 1, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
        }
	}
                                                        
    
    IEnumerator Normal()
    {
        Can_NormalAttack = false;
        yield return new WaitForSeconds(0.6f);
        Can_NormalAttack = true;
    }
}

