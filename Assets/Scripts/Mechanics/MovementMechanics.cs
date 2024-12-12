using System;
using UnityEngine;

[Serializable]
public class MovementMechanics
{
    [SerializeField]
    private GameObject GameObj;

    [SerializeField]
    private Rigidbody2D Rigidbody;

    [SerializeField]
    private Animator Animator;

    [SerializeField]
    private float MovementSpeed = 1;

    [SerializeField]
    private float JumpPower = 1;

    private bool LastDirectionRight = true;

    public void MoveX(float axisPower)
    {
        UpdateSpriteDirection(axisPower);

        Vector3 movement = new Vector3(axisPower * MovementSpeed, 0, 0);

        movement = movement * Time.deltaTime;

        Rigidbody.transform.Translate(movement);
    }

    public void MoveY(float axisPower)
    {
        Vector3 movement = new Vector3(0, axisPower * MovementSpeed, 0);

        movement = movement * Time.deltaTime;

        Rigidbody.transform.Translate(movement);
    }

    public void Jump(bool jump)
    {
        if(jump && IsGrounded())
        {
            Rigidbody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);

            Rigidbody.velocity = new Vector3(0f, Rigidbody.velocity.y, 0f);

            LimitTheJumpVelocity();
        }
    }

    public void ForceJump()
    {
        ResetVelocity();

        Rigidbody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);

        Rigidbody.velocity = new Vector3(0f, Rigidbody.velocity.y, 0f);

        LimitTheJumpVelocity();
    }

    public void DoAnimationLogic(float axisPower)
    {
        if (Animator != null)
        {
            var x = axisPower < 0 ? axisPower * -1 : axisPower;
            var y = Rigidbody.velocity.y < 0 ? Rigidbody.velocity.y * -1 : Rigidbody.velocity.y;

            Animator.SetFloat("xVelocity", x);
            Animator.SetFloat("yVelocity", y);
        }
    }

    private void UpdateSpriteDirection(float axisPower)
    {
        bool currentDirectionRight = LastDirectionRight;

        if (axisPower < 0) 
        {
            currentDirectionRight = false;
        }
        else if(axisPower > 0)
        {
            currentDirectionRight = true;
        }

        if (currentDirectionRight != LastDirectionRight)
        {
            this.GameObj.transform.localScale = new Vector3(this.GameObj.transform.localScale.x * -1, this.GameObj.transform.localScale.y, this.GameObj.transform.localScale.z);
        }

        LastDirectionRight = currentDirectionRight;
    }

    private void LimitTheJumpVelocity()
    {
        if (Rigidbody.velocity.y > JumpPower)
        {
            Rigidbody.velocity = new Vector3(0f, JumpPower, 0f);
        }
    }

    private bool IsGrounded()
    {
        return this.Rigidbody.velocity.y == 0;
    }

    private void ResetVelocity()
    {
        Rigidbody.velocity = new Vector3(0f, 0f, 0f);
    }
}
