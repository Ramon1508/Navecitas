using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NukeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy() {
        Globales.Save();
        SceneManager.LoadScene("Escena creditos", LoadSceneMode.Single);
    }
}
