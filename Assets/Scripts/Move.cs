using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
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
    void Movement()
    {
        if (Input.GetKey(KeyCode.S) && transform.position.y < 25)
            transform.Translate(Vector3.up * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.W) && transform.position.y > -46.80173)
            transform.Translate(Vector3.down * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && transform.position.x > -30)
            transform.Translate(Vector3.left * deltaMove * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && transform.position.x < 20)
            transform.Translate(Vector3.right * deltaMove * Time.deltaTime);
    }
}
