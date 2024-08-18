using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour
{
    public float Geschwindigkeit;
    private bool walk;

  void Update(){
      if  (Input.GetKey("up")){
        transform.Translate(Vector2.up*Geschwindigkeit*Time.deltaTime,Space.World);
        walk = true;
    }
     if(Input.GetKey("down")){
       transform.Translate(Vector2.down*Geschwindigkeit*Time.deltaTime,Space.World);
       walk = true;
    }
    if(Input.GetKey("left")){
       transform.Translate(Vector2.left*Geschwindigkeit*Time.deltaTime,Space.World);    
       transform.localScale = new Vector2(-1f, 1f);
       walk = true;
         
    }
    if(Input.GetKey("right")){
       transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime,Space.World);
       transform.localScale = new Vector2(1f, 1f);
       walk = true;
    }

    else {
      walk = false;
    }
  } 
}
