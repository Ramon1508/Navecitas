using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveGiro : MonoBehaviour
{
    public float GiroX = 1;
    public float GiroY = 1;
    public GameObject nuke;
    float tiempogiro = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Girar();
        tiempogiro -= Time.deltaTime;
        if (tiempogiro <= 0) {
            tiempogiro = 10;
            transform.eulerAngles = new Vector3(180f, 0f, 180f);
        }
    }
    void Girar() {
        if (Arriba() && (transform.rotation.eulerAngles.x < 10 || (transform.rotation.eulerAngles.x > 345 && transform.rotation.eulerAngles.x < 360)))
            transform.Rotate(new Vector3(GiroY, 0f, 0f) * Time.deltaTime);
        if (Abajo() && (transform.rotation.eulerAngles.x < 11 || (transform.rotation.eulerAngles.x > 350 && transform.rotation.eulerAngles.x < 360)))
            transform.Rotate(new Vector3(-GiroY, 0f, 0f) * Time.deltaTime);
        if (Derecha() && (transform.rotation.eulerAngles.z < 50 || (transform.rotation.eulerAngles.z > 315 && transform.rotation.eulerAngles.z < 360)))
            transform.Rotate(new Vector3(0f, 0f, -GiroX) * Time.deltaTime);
        if (Izquierda() && (transform.rotation.eulerAngles.z < 45 || (transform.rotation.eulerAngles.z > 314 && transform.rotation.eulerAngles.z < 360)))
            transform.Rotate(new Vector3(0f, 0f, GiroX) * Time.deltaTime);
    }
    bool Arriba() {
        return (Input.GetKey(KeyCode.W) || Input.GetKey((KeyCode)IpegaAndroid.AXIS_LEFT_X) || Input.GetKey(KeyCode.UpArrow));
    }
    bool Abajo() {
        return (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") < 0 || Input.GetKey(KeyCode.DownArrow));
    }
    bool Izquierda() {
        return (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < 0 || Input.GetKey(KeyCode.LeftArrow));
    }
    bool Derecha() {
        return (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0 || Input.GetKey(KeyCode.RightArrow));
    }
    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Objetivo") {
            GameObject personaje = GameObject.Find("Personaje");
            GameObject pistola = GameObject.Find("Pistola");
            GameObject canvascruz = GameObject.Find("CanvasCruz");
            Destroy(this.gameObject);
            Destroy(pistola);
            Destroy(canvascruz);
            personaje.GetComponent<Move>().timeron = true;
            var Explosion = Instantiate(nuke, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        }
    }
}