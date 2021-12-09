using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sprite;
    public float Force;
    public Animator anim;
    public Sprite DeadBird;
    bool life = true;

    private void Start()
    {
        Debug.Log("Update");
        
    }

    //blokada ruchu po pregranej i latanie
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && life == true)
        {
            
            rb.velocity = new Vector2(0, Force);


        }
    }

    //Zdech³y ptak
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Kolizja: " + collision.name);
        anim.enabled = false;
        sprite.sprite = DeadBird;
        life = false;
    }
}
