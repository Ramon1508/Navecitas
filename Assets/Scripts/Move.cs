﻿using System.Collections;
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
    void FixedUpdate()
    {
        if (Abajo() && transform.position.y < 50)
            transform.Translate(Vector3.up * deltaMove * Time.fixedDeltaTime);
        if (Arriba() && transform.position.y > -93.60346)
            transform.Translate(Vector3.down * deltaMove * Time.fixedDeltaTime);
        if (Izquierda() && transform.position.x > -80)
            transform.Translate(Vector3.left * deltaMove * Time.fixedDeltaTime);
        if (Derecha() && transform.position.x < 60)
            transform.Translate(Vector3.right * deltaMove * Time.fixedDeltaTime);
    }
    bool Arriba() {
        return (Input.GetKey(KeyCode.W) || Input.GetAxis("Vertical") > 0 || Input.GetAxis("BotonesVertical") < 0 || Input.GetKey(KeyCode.UpArrow));
    }
    bool Abajo() {
        return (Input.GetKey(KeyCode.S) || Input.GetAxis("Vertical") < 0 || Input.GetAxis("BotonesVertical") > 0 || Input.GetKey(KeyCode.DownArrow));
    }
    bool Izquierda() {
        return (Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < 0 || Input.GetAxis("BotonesHorizontal") < 0 || Input.GetKey(KeyCode.LeftArrow));
    }
    bool Derecha() {
        return (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0 || Input.GetAxis("BotonesHorizontal") > 0 || Input.GetKey(KeyCode.RightArrow));
    }
}