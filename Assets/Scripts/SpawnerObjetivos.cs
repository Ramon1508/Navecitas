using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjetivos : MonoBehaviour
{
    public GameObject meteoro;
    public float tiempo = 1;
    float tiempopasado;
    System.Random random = new System.Random();
    public float fuerzameteoro = 100f;
    // Start is called before the first frame update
    void Start()
    {
        tiempopasado = tiempo;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tiempopasado -= Time.deltaTime;
        if (true) {//tiempopasado <= 0
            tiempopasado = tiempo;
            generarMeteoro();
        }
    }
    void generarMeteoro() {
        var x = random.Next(-93, 50);
        var y = random.Next(-93, 50);
        var NuevoDisparo = Instantiate(meteoro, new Vector3(x, y, transform.position.z - 2), transform.rotation);
        NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * -fuerzameteoro, ForceMode.VelocityChange);
    }
}
