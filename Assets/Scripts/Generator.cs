using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public GameObject przeszkoda;

    void Start()
    {
        InvokeRepeating("StworzPrzeszkode", 3, 5);
    }

    void StworzPrzeszkode()
    {
        Debug.Log("Stworz przeszkode");
        Instantiate(przeszkoda, transform.position,Quaternion.identity);
    }
}
