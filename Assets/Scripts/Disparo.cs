using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public float fuerzabala = 100f;
    float tiempodisparo = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tiempodisparo -= Time.fixedDeltaTime;
        if (tiempodisparo <= 0) {
            tiempodisparo = 1;
            transform.eulerAngles = new Vector3(180f, 0f, 180f);
        }
        Shoot();
    }
    bool verificardisparo() {
        return Input.GetKeyDown(KeyCode.Space) || 
        Input.GetKeyDown(KeyCode.Joystick1Button0) ||
        Input.GetKeyDown(KeyCode.Joystick1Button1) || 
        Input.GetKeyDown(KeyCode.Joystick1Button2) ||
        Input.GetKeyDown(KeyCode.Joystick1Button3) ||
        Input.GetKeyDown(KeyCode.Joystick1Button4) ||
        Input.GetKeyDown(KeyCode.Joystick1Button6) ||
        Input.GetKeyDown(KeyCode.Joystick1Button7) ||
        Input.GetKeyDown(KeyCode.Joystick1Button8) ||
        Input.GetKeyDown(KeyCode.Joystick1Button9) ||
        Input.GetKeyDown(KeyCode.Joystick1Button10);
    }
    void Shoot(){
        if (verificardisparo()){
            GameObject mira = GameObject.Find("CanvasCruz");
            var NuevoDisparo = Instantiate(bala, new Vector3(transform.position.x, transform.position.y, transform.position.z - 2), transform.rotation);
            NuevoDisparo.GetComponent<Rigidbody>().AddForce(Vector3.back * fuerzabala, ForceMode.VelocityChange);
        }
    }
}
