using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour
{
    public float Geschwindigkeit;
    private Animator anim;

  void Start (){
    anim = GetComponent<Animator>();
  }
  void Update(){
    if  (Input.GetKey("up")){
        transform.Translate(Vector2.up*Geschwindigkeit*Time.deltaTime,Space.World);
    }
    if(Input.GetKey("down")){
       transform.Translate(Vector2.down*Geschwindigkeit*Time.deltaTime,Space.World);
    }
    if(Input.GetKey("left")){
       transform.Translate(Vector2.left*Geschwindigkeit*Time.deltaTime,Space.World);    
       transform.localScale = new Vector2(-1f, 1f);        
    }
    if(Input.GetKey("right")){
       transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime,Space.World);
       transform.localScale = new Vector2(1f, 1f);
    }

    bool walk;

    if (Input.GetKey("up")){
      walk = true;
    }
    else if (Input.GetKey("down")){
      walk = true;
    }
    else if (Input.GetKey("left")){
      walk = true;
    }
    else if (Input.GetKey("right")){
      walk = true;
    }
    else {
      walk = false;
    }

anim.SetBool("walk",walk);

  } 
}
