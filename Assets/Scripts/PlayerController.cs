using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 4;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (transform.position.x < -11.5f)
        {
            transform.position = new Vector2(11.5f, transform.position.y);
        }
        if (transform.position.x > 11.5f)
        {
            transform.position = new Vector2(-11.5f, transform.position.y);
        }

        if (transform.position.y < -4.5f)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        if (transform.position.y > 4.5f)
        {
            transform.position = new Vector2(transform.position.x, 4.5f);
        }
        Vector2 movement = new Vector2(moveX, moveY) * speed * Time.deltaTime;
        transform.Translate(movement);
        
    }
}
