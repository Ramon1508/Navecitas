using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float deltaMove = 10f;
    public GameObject prefab;
    public float fuerzabala = 100f;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        //rigidbody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        //Rotate();
        //Shoot();
    }
    void Shoot(){/* 
        if (Input.GetKeyUp(KeyCode.UpArrow)){
            var NuevoDisparo = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.forward * fuerzabala, ForceMode.Impulse);
            //NuevoDisparo.GetComponent<Transform>().Rotate(new Vector3(90f, 0f, 0f) * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            var NuevoDisparo = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * fuerzabala, ForceMode.Impulse);
        }  
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            var NuevoDisparo = Instantiate(prefab, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.left * fuerzabala, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            var NuevoDisparo = Instantiate(prefab, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.right * fuerzabala, ForceMode.Impulse);
        }*/
    }
    void Rotate()
    {
        transform.Rotate(new Vector3(0f, 0f, 0f) * Time.deltaTime);
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < 25)
            transform.Translate(Vector3.up * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && transform.position.y > -46.80173)
            transform.Translate(Vector3.down * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && transform.position.x > -30)
            transform.Translate(Vector3.left * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && transform.position.x < 20)
            transform.Translate(Vector3.right * deltaMove * Time.deltaTime);
    }
}
