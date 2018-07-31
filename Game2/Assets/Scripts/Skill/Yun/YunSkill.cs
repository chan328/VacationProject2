using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunSkill : MonoBehaviour {
    public bool can_useSkill1;
    public GameObject Yun;
    public Sprite Skill1;
    public Sprite Ego;
    public YunMove skill1Effect;
    private SpriteRenderer spriteRan;
	// Use this for initialization
	void Start () {
        can_useSkill1 = true;
        spriteRan  = GetComponent<SpriteRenderer>();
        skill1Effect = Yun.GetComponent<YunMove>();
	}
	
	// Update is called once per frame
	void Update () {
        if (can_useSkill1 == true)
        {
            if(this.tag == "Player1")
            {
                if (Input.GetKeyDown(KeyCode.H))
                {
                    spriteRan.sprite = Skill1;
                    skill1Effect.movePower = 3f;
                    skill1Effect.jumpPower = 5f;
                    StartCoroutine(Sk1_time());
                }
            }
            if (this.tag == "Player2")
            {
                if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    spriteRan.sprite = Skill1;
                    skill1Effect.movePower = 3f;
                    skill1Effect.jumpPower = 5f;
                    StartCoroutine(Sk1_time());
                }
            }

        }
	}
    IEnumerator Sk1_time()
    {
            can_useSkill1 = false;
            yield return new WaitForSeconds(5);
            skill1Effect.movePower = 2f;
            skill1Effect.jumpPower = 4f;
            spriteRan.sprite = Ego;

        StartCoroutine(Sk1_cooltime());
    }
    IEnumerator Sk1_cooltime()
    {
        yield return new WaitForSeconds(15);
        can_useSkill1 = true;
    }
}
