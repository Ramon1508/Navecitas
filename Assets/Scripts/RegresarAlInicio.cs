using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RegresarAlInicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Globales.Load();
        var texto = "Puntuaciones\nmás altas:";
        for (int i = 0; i < 10; i++)
        {
            int p;
            if (Globales.Puntuaciones.Count - 1 < i) p = 1;
            else p = Globales.Puntuaciones[i];
            texto += "\n" + (i + 1).ToString() + ".- " + p.ToString();
        }
        var Puntuaciones = GameObject.Find("Puntuaciones");
        Puntuaciones.GetComponent<TMP_Text>().SetText(texto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene("Escena inicial", LoadSceneMode.Single);
    }
}
