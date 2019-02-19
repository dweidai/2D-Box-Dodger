using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float width = 30f;
    Rigidbody2D rb;
    public int life = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 position = rb.position + Vector2.right * x;
        position.x = Mathf.Clamp(position.x, -width, width);
        rb.MovePosition(position);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        if(life == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
