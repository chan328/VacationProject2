using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoSkill2 : MonoBehaviour {
    public bool CanUse_skill2;
    public GameObject Skill2;
	// Use this for initialization
	void Start () {
        CanUse_skill2 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(CanUse_skill2 == true)
        {
            if (this.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    GameObject HoSkill2 = Instantiate(Skill2, this.gameObject.transform.position, Quaternion.identity);
                    StartCoroutine("HoSkill2_cool");
                }
            }
            else if (this.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad2))
                {
                    GameObject HoSkill2 = Instantiate(Skill2, this.gameObject.transform.position, Quaternion.identity);
                    StartCoroutine("HoSkill2_cool");
                }
            }
        }
	}
    IEnumerator HoSkill2_cool()
    {
        CanUse_skill2 = false;
        yield return new WaitForSeconds(9);
        CanUse_skill2 = true;
    }
}
