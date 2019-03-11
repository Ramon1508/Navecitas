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
    void Update()
    {
        Shoot();
    }
    void Shoot(){
        if (Input.GetKeyUp(KeyCode.UpArrow)){
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 1), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerzabala, ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z - 1), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * fuerzabala, ForceMode.VelocityChange);
        }  
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x - 1, transform.position.y - 1, transform.position.z), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.left * fuerzabala, ForceMode.VelocityChange);
            NuevoDisparo.GetComponent<Transform>().Rotate(new Vector3(0f, 90f, 0f));
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x + 1, transform.position.y - 1, transform.position.z), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.right * fuerzabala, ForceMode.VelocityChange);
            NuevoDisparo.GetComponent<Transform>().Rotate(new Vector3(0f, 90f, 0f));
        }
    }
}
