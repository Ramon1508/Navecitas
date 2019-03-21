using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDisparo : MonoBehaviour
{
    public int tiempopresuicidio = 5;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, tiempopresuicidio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Objetivo") {
            Destroy(this.gameObject);
        }
    }
}
