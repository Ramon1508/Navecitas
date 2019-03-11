using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mira : MonoBehaviour
{
    public Sprite crossHair;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = crossHair;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor (Color color){
	    this.GetComponent<Image> ().color = color;
    }
}
