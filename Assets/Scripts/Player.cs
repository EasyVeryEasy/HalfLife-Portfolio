using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    Rigidbody rigidbody;

    public float force = 100.0f;

    public void Awake()
    {
        hp = 100;
        moveSpeed = 6.5f;
        backmoveSpeed = 5.5f;
        jumpPower = 10.0f;
        gravity = 9.8f;
        playerGravity = 0;

        rigidbody = GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector3(0, 1.0f, 0) * force);
        }
    }

    void Update()
    {
        MoveCharacter();
    }
    void MoveCharacter()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontal, Space.Self);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * vertical, Space.Self);

    }
}