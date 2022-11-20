using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D lazer;
    public Collider2D lazerCollider;
    public Sprite explode;
    public RuntimeAnimatorController death;
    public AudioSource boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Animator>().runtimeAnimatorController = death;
        boom.Play();
        Destroy(gameObject,1f);
    }
    // Update is called once per frame
    void Update()
    {
  
       
    }
}
