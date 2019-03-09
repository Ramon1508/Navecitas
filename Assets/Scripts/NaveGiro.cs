using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveGiro : MonoBehaviour
{
    public float GiroX = 1;
    public float GiroY = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Girar();
    }
    void Girar() {
        if (Input.GetKey(KeyCode.W))
            transform.Rotate(new Vector3(GiroY, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Rotate(new Vector3(-GiroY, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        if (Input.GetKey(KeyCode.A) && (transform.rotation.eulerAngles.z < 50 || (transform.rotation.eulerAngles.magnitude > 315 && transform.rotation.eulerAngles.magnitude < 360)))
            transform.Rotate(new Vector3(0f, 0f, -GiroX) * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        if (Input.GetKey(KeyCode.D) && (transform.rotation.eulerAngles.z < 45 || (transform.rotation.eulerAngles.magnitude > 315 && transform.rotation.eulerAngles.magnitude < 360)))
            transform.Rotate(new Vector3(0f, 0f, GiroX) * Time.deltaTime);
    }
}