using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour
{
    public int vida = 5;
    public int tiempopresuicidio = 2;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Bala") {
            vida = vida-1;
            if (vida <= 0){
                var Bum = Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                Destroy(this.gameObject);
                Destroy(Bum, tiempopresuicidio);
            }
        }
    }
}
