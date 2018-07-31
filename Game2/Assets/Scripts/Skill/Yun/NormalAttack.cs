using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : MonoBehaviour {
    public GameObject Attack;
    public bool Can_NormalAttack;

	// Use this for initialization
	void Start () {
        Can_NormalAttack = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag == "Player1")
        {
            Attack.tag = "YunAttack";
            if(Input.GetKeyDown(KeyCode.F))
            {
                if(Can_NormalAttack == true)
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(1, 1, 0);
                        StartCoroutine("Normal");
                    }
                    else
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-1, 1, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
        }
    else if(this.tag == "Player2")
        {
            Attack.tag = "YunAttack_2";
            if(Input.GetKeyDown(KeyCode.Keypad1))
            {
                if(Can_NormalAttack == true)
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(1, 1, 0);
                        StartCoroutine("Normal");
                    }
                    else
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-0.5f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(-1, 1, 0);
                        StartCoroutine("Normal");
                    }
                }
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "YunAttack_2")
            {
                if(Yunskill3.UsingSkill3 == true)
                {
                    Gameplayer.HP1_ -= 20;
                }
                else
                Gameplayer.HP1_ -= 10;
            }
        }
        if(this.tag == "Player2")
        {
            if(other.gameObject.tag == "YunAttack")
            {
                if (Yunskill3.UsingSkill3 == true)
                {
                    Gameplayer.HP2_ -= 20;
                }
                else
                Gameplayer.HP2_ -= 10;
            }
        }
    }                                                        
    
    IEnumerator Normal()
    {
        Can_NormalAttack = false;
        yield return new WaitForSeconds(0.3f);
        Can_NormalAttack = true;
    }
}
