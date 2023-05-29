using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turretle : MonoBehaviour
{
    Rigidbody2D rbTurretle;
    [SerializeField] float speed = 2f;
    [SerializeField] Transform point1, point2;
    [SerializeField] LayerMask layer;
    [SerializeField] bool isColliding;

    Animator animTurretle;
    BoxCollider2D colliderTurretle;

    private void Awake ()
    {
        rbTurretle = GetComponent<Rigidbody2D>();
        animTurretle = GetComponent<Animator>();
        colliderTurretle = GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate ()
    {
        rbTurretle.velocity = new Vector2(speed, rbTurretle.velocity.y);

        isColliding = Physics2D.Linecast(point1.position, point2.position, layer);

        if (isColliding)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            speed *=-1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<PlayerMovement>().Death();

            Turretle[] turretle = FindObjectsOfType<Turretle>();

            for (int i = 0; i < turretle.Length; i++)
            {
                turretle[i].speed = 0;
                turretle[i].animTurretle.speed = 0;
            }
        }
    }
}