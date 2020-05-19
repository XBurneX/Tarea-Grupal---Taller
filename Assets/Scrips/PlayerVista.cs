using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerVista : MonoBehaviour
{
    public MODELO model;
    public Text textovida;
    public Text recuperarvida;
    public Text perdervida;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        recuperarvida.text = "+1";
        perdervida.text = "-1";
        textovida.text = "Vida:" + model.LifeToAdd;
    }
}
