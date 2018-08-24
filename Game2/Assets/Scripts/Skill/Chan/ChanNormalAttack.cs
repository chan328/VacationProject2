using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanNormalAttack : MonoBehaviour {
    public GameObject Attack;
    public bool CanAttack;
    public GameObject Player;
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
                if(Input.GetKeyDown(KeyCode.F))
                {
                    Attack.tag = "P1Chan0";
                    if(this.transform.localScale.x > 0)
                    {                    
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(0.4f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(1, 1, 0);
                        StartCoroutine("Normal");
                    }
                    else if(this.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-0.4f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-1, 1, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
            else if (Player.gameObject.tag == "Player2")
            {
                if(Input.GetKeyDown(KeyCode.Keypad1))
                {
                    Attack.tag = "P2Chan0";
                    if (this.transform.localScale.x > 0)
                    {                       
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(0.4f, 0.18f, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(0.8f, 0.8f, 0);
                        StartCoroutine("Normal");
                    }
                    else if (this.transform.localScale.x < 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-0.4f, 0.18f, -1), Quaternion.identity);
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
        yield return new WaitForSeconds(1f);
        CanAttack = true;
    }
}
