using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprechen : MonoBehaviour
{
    public GameObject Spieler;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance (Spieler.transform.position, gameObject.transform.position);
        if(Input.GetKey("space")&&distance<1){
            Debug.Log(distance);
            Debug.Log("hallo");
        }
    }
}
