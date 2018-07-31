using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunMove : MonoBehaviour {
    public float movePower = 2f;
    public float jumpPower = 3f;
    public bool stun; 
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
        Move();
        if(this.tag == "Player2")
        Move2();
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
        if(this.tag == "Player1")
        {
            if(Gameplayer.HP1_<=0)
            Destroy(gameObject);
        }
        if(this.tag == "Player2")
        {
            if(Gameplayer.HP2_<=0)
            Destroy(gameObject);
        }
    }

    
    public void Move2()
	{
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
        if(other.gameObject.tag == "Spear")
        {
            if(this.tag == "Player1")
            {
                Gameplayer.HP1_-=10;
                rig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }
            else 
            {
                Gameplayer.HP2_-=10;
                rig.AddForce(new Vector2(200 * other.gameObject.transform.localScale.x,0));
            }
            if(other.gameObject.tag == "GitSkill_3")
            {
                if(this.tag == "Player1")
                {
                    Gameplayer.HP1_ -= 25;
                }
                else
                {
                    Gameplayer.HP2_ -= 25;
                }
            }
        }
    }
}
    
