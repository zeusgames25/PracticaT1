using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaballeroControl : MonoBehaviour
{
    public float velocityX = 5;
    // Start is called before the first frame update
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Animator animacion;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        animacion.SetInteger("Estado",0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            rb.velocity = new Vector2(velocityX,rb.velocity.y);
            animacion.SetInteger("Estado",1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            rb.velocity = new Vector2(-velocityX, rb.velocity.y);
            animacion.SetInteger("Estado", 1);

        }
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.X))
        {
            sr.flipX = false;
            rb.velocity = Vector2.right * 15;
            animacion.SetInteger("Estado", 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.X))
        {
            sr.flipX = true;
            rb.velocity = Vector2.right * -15;
            animacion.SetInteger("Estado", 2);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space) )
        {
            sr.flipX = true;
            rb.velocity = Vector2.down * -15;
            animacion.SetInteger("Estado", 3);
        }
        if ( Input.GetKey(KeyCode.Space))
        {

            rb.AddForce(Vector2.up*60);
            animacion.SetInteger("Estado", 3);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            animacion.SetInteger("Estado", 4);
        }

    }
}
