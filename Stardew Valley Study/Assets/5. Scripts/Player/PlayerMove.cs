using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public Vector2 inputVec;
    public float moveSpeed;

    Rigidbody2D rigidBody;
    SpriteRenderer spriteRenderer;
    Animator anim;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 nextVec = inputVec * moveSpeed * Time.fixedDeltaTime;
        rigidBody.MovePosition(rigidBody.position + nextVec);
    }

    void LateUpdate()
    {
        if (inputVec.x != 0 || inputVec.y != 0)
            anim.SetBool("isMove", true);
        else
            anim.SetBool("isMove", false);

        anim.SetFloat("inputX", inputVec.x);
        anim.SetFloat("inputY", inputVec.y);

    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

}
