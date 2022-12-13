using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    
   public float timer{get;private set;}
     
     void Start () 
     {
     
     }
     
     
     void Update () 
     {
        timer = (int) (1.0f/ Time.deltaTime) ;
        //timer += Time.deltaTime;
         if (timer%60 == 0)//change the float value here to change how long it takes to switch.
         {
            gameObject.GetComponent<Renderer>().material.color = new Color( Random.value, Random.value, Random.value, 1.0f );
         }
  
         
     }
}
