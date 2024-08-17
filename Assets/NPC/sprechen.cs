using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sprechen : MonoBehaviour
{
    public GameObject spieler;
    // Update is called once per frame
    void Update()
    {
        if((Vector2.Distance(gameObject.transform.position, spieler.transform.position)<1)&&(Input.GetKey("space"))){
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
