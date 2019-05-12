using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDisparo : MonoBehaviour
{
    public int tiempopresuicidio = 5;
    // Start is called before the first frame update
    void Start()
    {
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
