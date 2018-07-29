using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunMove : MonoBehaviour {
    public float movePower = 2f;
    float jumpPower = 3f;
    Rigidbody2D rig;
    Vector3 movement;
    public bool isJumping = false;
    public static int HP {get; set;}
    void Start()
    {
        HP = 120;
        if(Gameplayer.player1!=0&&Gameplayer.player2!=0)
        gameObject.SetActive(false);
        rig = GetComponent<Rigidbody2D>(); 
        Gameplayer.player2 =1;   
    }

    void FixedUpdate()
    {
        Move();
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

    void Move()
    {
        Vector3 movevelo = Vector3.zero;
        if(Gameplayer.player1 == 0)
        {
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
        }
        if(Gameplayer.player2 == 0)
        {
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
        }
        
        transform.position += movevelo * movePower * Time.deltaTime;
    }
    void Jump()
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
}