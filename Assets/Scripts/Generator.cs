using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject przeszkoda;


    //Generuje przeszkody
    void Start()
    {
        Debug.Log(Random.Range(-1f, 2));
        InvokeRepeating("StworzPrzeszkode", 3, 5);
    }

    void StworzPrzeszkode()
    {
        Debug.Log("Stworz przeszkode");
        Instantiate(przeszkoda, new Vector2(transform.position.x, -1f + Random.Range(-1f, 2)), Quaternion.identity);
    }
}
