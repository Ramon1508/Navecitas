using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool timeron = false;
    public float tiempo = 5;
    public float deltaMove = 10f;
    public int puntuacion = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Abajo() && transform.position.y < 50)
            transform.Translate(Vector3.up * deltaMove * Time.deltaTime);
        if (Arriba() && transform.position.y > -93.60346)
            transform.Translate(Vector3.down * deltaMove * Time.deltaTime);
        if (Izquierda() && transform.position.x > -80)
            transform.Translate(Vector3.left * deltaMove * Time.deltaTime);
        if (Derecha() && transform.position.x < 60)
            transform.Translate(Vector3.right * deltaMove * Time.deltaTime);
    }
    void FixedUpdate() {
        if (timeron) {
            tiempo -= Time.deltaTime;
            if (tiempo <= 0) {
                Application.Quit();
                //UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
    bool Arriba() {
        return (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") > 0 || Input.GetKey(KeyCode.UpArrow));
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
}