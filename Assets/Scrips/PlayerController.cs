using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float s;

    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<MODELO>().MoveVelocity;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position = new Vector3(transform.position.x + (h * s), transform.position.y, transform.position.z + (v * s));
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("MinusLive"))
        {
            Debug.Log("disminuyendo vida");
            GetComponent<MODELO>().LifeToAdd = GetComponent<MODELO>().LifeToAdd - GetComponent<MODELO>().LifepenaltyOnEnter;
        }

        if (obj.gameObject.CompareTag("PlusLive"))
        {
            Debug.Log("Aumentando Vida");
            GetComponent<MODELO>().LifeToAdd = GetComponent<MODELO>().LifeToAdd + GetComponent<MODELO>().LifepenaltyOnEnter;
            
        }


    }
}
