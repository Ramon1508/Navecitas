using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerObjetivos : MonoBehaviour
{
    public List<GameObject> meteoros;
    public Text lblPuntuacion;
    private bool locura;
    public float tiempo = 0.2f;
    public float tiempopasado = 0.2f;
    System.Random random = new System.Random();
    public float fuerzameteoro = 100f;
    // Start is called before the first frame update
    void Start()
    {
        tiempopasado = tiempo;
        GameObject Globales = GameObject.Find("Global");
        locura = Globales.GetComponent<Globales>().locura;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tiempopasado -= Time.fixedDeltaTime;
        if (tiempopasado <= 0 || locura) {//
            tiempopasado = tiempo;
            generarMeteoro();
        }
    }
    void generarMeteoro() {
        var x = random.Next(-93, 60);
        var y = random.Next(-93, 60);
        var i = random.Next(0, meteoros.Count);
        var meteoro = meteoros[i];
        var NuevoDisparo = Instantiate(meteoro, new Vector3(x, y, transform.position.z - 2), transform.rotation);
        NuevoDisparo.GetComponent<Objetivo>().lblPuntuacion = lblPuntuacion;
        NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * -fuerzameteoro, ForceMode.VelocityChange);
    }
}
