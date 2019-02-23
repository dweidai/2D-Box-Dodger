using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject player;
    float scale = 20f;
    // Update is called once per frame
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / scale;
    }
    void Update()
    {
        Debug.Log(player.GetComponent<Player>().life);
        if(transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(player.GetComponent<Player>().life == 0)
        {

            gameObject.GetComponent<Renderer>().material.color = Color.red;
            //gameObject.GetComponent<Collider2D>().enabled = false;
        }
        gameObject.GetComponent<Collider2D>().enabled = false;
        gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
