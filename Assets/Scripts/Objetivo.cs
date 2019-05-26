using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objetivo : MonoBehaviour
{
    public int vida = 5;
    public int tiempopresuicidio = 2;
    public Text lblPuntuacion;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
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
                Globales.puntuacion += 1;
                lblPuntuacion.text = "Puntuaje: " + Globales.puntuacion.ToString();
                Destroy(Bum, tiempopresuicidio);
                Destroy(this.gameObject);
            }
        }
    }
}
