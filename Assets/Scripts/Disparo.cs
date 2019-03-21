using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public float fuerzabala = 100f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shoot();
    }
    void Shoot(){
        if (Input.GetKeyUp(KeyCode.Space)){
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x, transform.position.y, transform.position.z - 2), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * fuerzabala, ForceMode.VelocityChange);
        }
    }
}
