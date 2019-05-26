using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ModoJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        Globales.locura = !Globales.locura;
        string texto = "Fácil";
        if (Globales.locura) texto = "Difícil";
        var ModoJuegoTXT = GameObject.Find("ModoJuegoTXT");
        ModoJuegoTXT.GetComponent<TMP_Text>().SetText(texto);
    }
}
