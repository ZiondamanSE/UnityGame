using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float activeMoveSpeed;
    [SerializeField] private float _speed;

    public float dashSpeed;
    public float dashLength = .5f, dashCooldown = 1f;
    private float dashCounter;
    private float dashCoolCounter;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        activeMoveSpeed = _speed;
    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
        Move();
        Dash();
    }

    private void LookAtMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePos - new Vector2(transform.position.x, transform.position.y);
        //Debug.Log(mousePos);
    }

    private void Move()
    {
        var input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _rigidbody.velocity = input.normalized * activeMoveSpeed;
        //Debug.Log(input);
    }

    private void Dash()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(dashCoolCounter <= 0 && dashCounter <= 0)
            {
               activeMoveSpeed = dashSpeed;
                dashCounter = dashLength;
                //Debug.Log("A " + activeMoveSpeed + dashCoolCounter);
            }
        }

        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                activeMoveSpeed = _speed;
                dashCoolCounter = dashCooldown;
                //Debug.Log("B " + activeMoveSpeed + dashCoolCounter);
            }
        }

        if (dashCoolCounter > 0)
        {
            dashCoolCounter -= Time.deltaTime;
            //Debug.Log("C " + dashCoolCounter);
        }
    }

}
