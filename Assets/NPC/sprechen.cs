using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprechen : MonoBehaviour
{
    public GameObject Spieler;

    void Update()
    {
        float distance = Vector2.Distance (Spieler.transform.position, gameObject.transform.position);
        if(Input.GetKey("space")&&distance<1){
            Debug.Log(distance);
            Debug.Log("hallo");
        }
    }
}
