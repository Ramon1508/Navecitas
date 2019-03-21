using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveGiro : MonoBehaviour
{
    public float GiroX = 1;
    public float GiroY = 1;
    public GameObject nuke;
    bool timeron = false;
    public float tiempo = 10;
    float tiempogiro = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Girar();
        if (timeron) {
            tiempo -= Time.deltaTime;
            if (tiempo <= 0) {
                Application.Quit();
            }
        }
        tiempogiro -= Time.deltaTime;
        if (tiempogiro <= 0) {
            tiempogiro = 10;
            transform.eulerAngles = new Vector3(180f, 0f, 180f);
        }
    }
    void Girar() {
        if (Input.GetKey(KeyCode.W) && (transform.rotation.eulerAngles.x < 10 || (transform.rotation.eulerAngles.x > 345 && transform.rotation.eulerAngles.x < 360)))
            transform.Rotate(new Vector3(GiroY, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && (transform.rotation.eulerAngles.x < 11 || (transform.rotation.eulerAngles.x > 350 && transform.rotation.eulerAngles.x < 360)))
            transform.Rotate(new Vector3(-GiroY, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && (transform.rotation.eulerAngles.z < 50 || (transform.rotation.eulerAngles.z > 315 && transform.rotation.eulerAngles.z < 360)))
            transform.Rotate(new Vector3(0f, 0f, -GiroX) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && (transform.rotation.eulerAngles.z < 45 || (transform.rotation.eulerAngles.z > 314 && transform.rotation.eulerAngles.z < 360)))
            transform.Rotate(new Vector3(0f, 0f, GiroX) * Time.deltaTime);
    }
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Objetivo") {
            Destroy(this.gameObject);
            timeron = true;
            var Explosion = Instantiate(nuke, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        }
    }
}