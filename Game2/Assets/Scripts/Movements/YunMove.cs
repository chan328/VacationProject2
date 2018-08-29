using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunMove : MonoBehaviour {
    public float movePower = 2f;
    public float jumpPower = 3f;
    public int StunNum;
    public bool stun; 
    public bool Chanstun;
    public bool Chanstun3;
    Vector3 movement;
    public bool isJumping = false;
    Rigidbody2D rig;
    void Start()
    {
        stun = false;
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(this.tag == "Player1")
        {
            Move();
            if(Gameplayer.HP1_<=0)
            Destroy(gameObject);
        }
        
        if(this.tag == "Player2")
        {
            Move2();
            if(Gameplayer.HP2_<=0)
            Destroy(gameObject);
        }
        
        if(transform.position.y<-10)
        {
            if(this.tag == "Player1")
            {
                Gameplayer.HP1_-=20;
            }
            if(this.tag == "Player2")
            {
                Gameplayer.HP2_-=20;
            }
            transform.position = new Vector3(0,0,0);
        }
    }

    void Update()
    {

    }

    
    public void Move2()
	{
        if(stun == true || Chanstun == true || Chanstun3 == true) return;
		Vector3 movevelo = Vector3.zero;

            if(Input.GetKey(KeyCode.UpArrow))
            {
                Jump();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                movevelo = Vector3.left;
                transform.localScale = new Vector3(-0.5f,0.5f,1);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                movevelo = Vector3.right;
                transform.localScale = new Vector3(0.5f,0.5f,1);
            }               
        transform.position += movevelo * movePower * Time.deltaTime;
	}
	public void Move()
    {
        if(stun == true || Chanstun == true || Chanstun3 == true) return;
        Vector3 movevelo = Vector3.zero;
            if(Input.GetKey(KeyCode.W))
            {
                Jump();
            }
            if (Input.GetKey(KeyCode.A))
            {
                movevelo = Vector3.left;
                transform.localScale = new Vector3(-0.5f,0.5f,1);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                movevelo = Vector3.right;
                transform.localScale = new Vector3(0.5f,0.5f,1);
            }
        
        
        transform.position += movevelo * movePower * Time.deltaTime;
    }

	public void Jump()
    {
        if (stun == true) return;
        if (!isJumping) return;

        rig.velocity = Vector2.zero;
        Vector2 jumpvelocity = new Vector2(0, jumpPower);

        rig.AddForce(jumpvelocity, ForceMode2D.Impulse);

        isJumping = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isJumping = true;
        }                        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(this.tag == "Player1")
        {
            if(other.gameObject.tag == "P2Git1")
            {          
                rig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P2Git2"||other.gameObject.tag == "P2Git3")
            {               
                StartCoroutine("isStun");                             
            }
            if(other.gameObject.tag == "P2Chan1"||other.gameObject.tag == "P2Uh2")
            {
                StartCoroutine("isChanStun");
            }
            if(other.gameObject.tag == "P2Chan3")
            {
                StartCoroutine("isChanskill3Stun");
            }
        }
        else
        {
            if(other.gameObject.tag == "P1Git1")
            {          
                rig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }           
            if(other.gameObject.tag == "P1Git2"|| other.gameObject.tag == "P1Git3")
            {                
                StartCoroutine("isStun");                             
            }
            if(other.gameObject.tag == "P1Chan1"||other.gameObject.tag == "P1Uh2")
            {
                StartCoroutine("isChanStun");
            }
            if(other.gameObject.tag == "P1Chan3")
            {
                StartCoroutine("isChanskill3Stun");
            }
        }
    }
    IEnumerator isStun()
    {
        stun = true;
        yield return new WaitForSeconds(0.5f);
        stun = false;
    }
    IEnumerator isChanStun()
    {
        Chanstun = true;
        yield return new WaitForSeconds(1f);
        Chanstun = false;
    }
    IEnumerator isChanskill3Stun()
    {
        Chanstun3 = true;
        yield return new WaitForSeconds(1.5f);
        Chanstun3 = false;
    }
}
    
