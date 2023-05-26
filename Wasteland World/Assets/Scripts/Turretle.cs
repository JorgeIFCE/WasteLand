using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turretle : MonoBehaviour
{
    Rigidbody2D rbTurretle;
    [SerializeField] float speed = 2f;

    private void Awake ()
    {
        rbTurretle = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate ()
    {
        rbTurretle.velocity = new Vector2(speed, rbTurretle.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
