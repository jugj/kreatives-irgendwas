using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sprechen : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    public GameObject spieler;
    public bool bereitsGesprochen=false;
    // Update is called once per frame
    void Update()
    {
        if((Vector2.Distance(gameObject.transform.position, spieler.transform.position)<1)&&(Input.GetKey("space"))){
            bereitsGesprochen=true;
            SceneManagerCLass.LoadDialog1();
        }
    }
}
