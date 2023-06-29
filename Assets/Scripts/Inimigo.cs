using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
     public GameObject pfLaser ;
   
    public float tempoDeDisparo = 0.3f ;

    public float podeDisparar = 0.0f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > podeDisparar){

                 Instantiate(pfLaser, transform.position + new Vector3 (0,1.1f,0),Quaternion.identity);
            
            }
                 podeDisparar = Time.time + tempoDeDisparo ;
    }
}
