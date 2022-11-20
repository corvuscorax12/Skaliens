using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

 

    public static void DeleteClone(GameObject clone)
    {
        if (clone.transform.position.x > 100f)
        {
            Destroy(clone);
        }
    }
}