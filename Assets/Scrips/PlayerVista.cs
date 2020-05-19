using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerVista : MonoBehaviour
{
    public MODELO model;
    public Text textovida;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textovida.text = "Vida:" + model.LifeToAdd;
    }
}
