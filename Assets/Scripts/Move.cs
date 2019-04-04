using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool timeron = false;
    public float tiempo = 5;
    public float deltaMove = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void FixedUpdate() {
        if (timeron) {
            tiempo -= Time.deltaTime;
            if (tiempo <= 0) {
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.S) && transform.position.y < 50)
            transform.Translate(Vector3.up * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.W) && transform.position.y > -93.60346)
            transform.Translate(Vector3.down * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && transform.position.x > -80)
            transform.Translate(Vector3.left * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && transform.position.x < 60)
            transform.Translate(Vector3.right * deltaMove * Time.deltaTime);
    }
}
