using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przeszkoda : MonoBehaviour
{
    public float speed = 1f;

    private void Start()
    {
        
    }
    
    //Generuje przeszkody
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }
}
