using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Force;
    int iloscKlatek = 0;

    private void Start()
    {
        Debug.Log("Update");
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            iloscKlatek++;
            Debug.Log("Update " + iloscKlatek);
            rb.velocity = new Vector2(0, Force);

        }
    }
}
