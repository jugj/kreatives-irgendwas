using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sprechen1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    public GameObject spieler;
    public GameObject button;
    public bool bereitsGesprochen=false;
    // Update is called once per frame
    void Update()
    {
        if((Vector2.Distance(gameObject.transform.position, spieler.transform.position)<1)){
            button.SetActive(true);
            Debug.Log("an");
        }
        else{
            button.SetActive(false);
            Debug.Log("aus");
        }

        if((Vector2.Distance(gameObject.transform.position, spieler.transform.position)<1)&&(Input.GetKey("space"))){
            bereitsGesprochen=true;
            SceneManagerCLass.LoadDialog1();
            button.SetActive(true);
        }
    }
}
