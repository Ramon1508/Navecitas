using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerObjetivos : MonoBehaviour
{
    public List<GameObject> meteoros;
    public Text lblPuntuacion;
    private bool locura;
    float tiempo = 0.2f;
    float tiempopasado = 0.2f;
    System.Random random = new System.Random();
    public float fuerzameteoro = 100f;
    // Start is called before the first frame update
    void Start()
    {
        tiempopasado = tiempo;
        locura = Globales.locura;
        Globales.Load();
        lblPuntuacion.text = "Puntuaje: " + Globales.puntuacion.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tiempopasado -= Time.fixedDeltaTime;
        if (locura || tiempopasado <= 0) {//
            tiempopasado = tiempo;
            generarMeteoro();
        }
    }
    void generarMeteoro() {
        var x = random.Next(-93, 70);
        var y = random.Next(-93, 70);
        var i = random.Next(0, meteoros.Count);
        var meteoro = meteoros[i];
        var NuevoDisparo = Instantiate(meteoro, new Vector3(x, y, transform.position.z - 2), transform.rotation);
        NuevoDisparo.GetComponent<Objetivo>().lblPuntuacion = lblPuntuacion;
        NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * -fuerzameteoro, ForceMode.VelocityChange);
    }
}
