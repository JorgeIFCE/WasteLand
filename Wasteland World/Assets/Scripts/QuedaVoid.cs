using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuedaVoid : MonoBehaviour
{
    
    [SerializeField] bool isColliding;
    [SerializeField] LayerMask layer;
    [SerializeField] Transform point3, point4;

    BoxCollider2D colliderVoid;

    private void Awake ()
    {
        colliderVoid = GetComponent<BoxCollider2D>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate ()
    {
         isColliding = Physics2D.Linecast(point3.position, point4.position, layer);
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
        }
    }
}
