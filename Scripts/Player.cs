using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()//click on the play game button
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()//input from keyboard per frame
    {
        float directionY = Input.GetAxisRaw("Vertical"); //to get input from keyboard
        playerDirection = new Vector2(0, directionY).normalized;
    }
     void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
