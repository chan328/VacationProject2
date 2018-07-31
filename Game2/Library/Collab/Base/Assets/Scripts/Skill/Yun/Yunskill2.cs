using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yunskill2 : MonoBehaviour {
    public GameObject Attack;
    public bool Can_useSkill2;

	// Use this for initialization
	void Start () {
        Can_useSkill2 = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.tag == "Player1")
        {
            if(Can_useSkill2 == true)
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(1f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(2, 2, 0);
                        StartCoroutine("Sk2_time");
                    }
                    else
                    {                        
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-1f, 0, -1), new Quaternion(0, 0, 0, 0));
                        attack.transform.localScale = new Vector3(-2, 2, 0);
                        StartCoroutine("Sk2_time");
                    }
                }
            }
        }
        else if(this.tag == "Player2")
        {
            if(Can_useSkill2 == true)
            {
                if (Input.GetKeyDown(KeyCode.Keypad2))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(1f, 0, -1), Quaternion.identity);
                        attack.transform.localScale = new Vector3(2, 2, 0);
                        StartCoroutine("Sk2_time");
                    }
                    else
                    {
                        
                        GameObject attack = Instantiate(Attack, this.transform.position + new Vector3(-1f, 0, -1), new Quaternion(0, 0, 0, 0));
                        attack.transform.localScale = new Vector3(-2, 2, 0);
                        StartCoroutine("Sk2_time");
                    }
                }
            }
        }
	}
    private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "YunSkill_2")
            Gameplayer.HP1_-=20;
        }
        if(this.tag == "Player2")
        {
            if(other.gameObject.tag == "YunSkill1")
            Gameplayer.HP2_-=20;
        }
    }                    
                                     
    
    IEnumerator Sk2_time()
    {
        Can_useSkill2 = false;
        yield return null;
        StartCoroutine("Sk2_cooltime");
    }
    IEnumerator Sk2_cooltime()
    {
        yield return new WaitForSeconds(4);
        Can_useSkill2 = true;
    }
}
