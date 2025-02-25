using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
    Rigidbody2D rb => GetComponent<Rigidbody2D>();
    void Update()=> transform.right = rb.velocity;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            UI.instance.AddScore();
        }
    }

}
