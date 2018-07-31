using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoNoraml : MonoBehaviour {
    public bool Can_normalAttack;
    public GameObject NormalAttack;
	// Use this for initialization
	void Start () {
        Can_normalAttack = true;
        Component Skill1On = this.GetComponent<HoSkill1>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Can_normalAttack == true)
        {
            if (this.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject Normal = Instantiate(NormalAttack, this.transform.position + new Vector3(0.7f, 0, 0), Quaternion.identity);
                        Normal.transform.localScale = new Vector3(2, 1, 0);
                        StartCoroutine("HoNormalAttack");
                    }
                    else
                    {
                        GameObject Normal = Instantiate(NormalAttack, this.transform.position + new Vector3(-0.7f, 0, 0), Quaternion.identity);
                        Normal.transform.localScale = new Vector3(-2, 1, 0);
                        StartCoroutine("HoNormalAttack");
                    }
                }
            }
            else if (this.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    if (this.transform.localScale.x > 0)
                    {
                        GameObject Normal = Instantiate(NormalAttack, this.transform.position + new Vector3(0.7f, 0, 0), Quaternion.identity);
                        Normal.transform.localScale = new Vector3(2, 1, 0);
                        StartCoroutine("HoNormalAttack");
                    }
                    else
                    {
                        GameObject Normal = Instantiate(NormalAttack, this.transform.position + new Vector3(-0.7f, 0, 0), Quaternion.identity);
                        Normal.transform.localScale = new Vector3(-2, 1, 0);
                        StartCoroutine("HoNormalAttack");
                    }
                }
            }
        }
        
	}
    IEnumerator HoNormalAttack()
    {
        Can_normalAttack = false;
        yield return new WaitForSeconds(0.3f);
        Can_normalAttack = true;
    }
}
