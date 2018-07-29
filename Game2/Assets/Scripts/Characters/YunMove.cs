using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunMove : MonoBehaviour {
public float movePower = 2f;
public float jumpPower = 3f;
public static int HP {get; set;}   
Vector3 movement;
public bool isJumping = false;
Rigidbody2D rig;
int a;
    void Start()
    {
        if(transform.position.x == -1.5f)
        a = 1;
        if(transform.position.x == 2f)
        a = 2;
        HP = 120;
        Gameplayer.player2 =1;   
    }

    void FixedUpdate()
    {
        if(a==1)
        Move();
        if(a==2)
        Move2();
        if(transform.position.y<-10)
        {
            HP -= 20;
            transform.position = new Vector3(0,0,0);
        }
    }

    void Update()
    {
        if(HP<=0)
        Destroy(gameObject);
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
		rig = GetComponent<Rigidbody2D>();       
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
}
    
