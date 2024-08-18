using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stadt1aManager : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    public GameObject spieler;
    public void Update(){
        Debug.Log("2");
        if((spieler.transform.position.x<-5)){
            Debug.Log("1");
            SceneManagerCLass.LoadTitleScreen2();
        }
        if((spieler.transform.position.x>5)){
            Debug.Log("1");
            SceneManagerCLass.LoadTitleScreen2();
        }
    }
}
