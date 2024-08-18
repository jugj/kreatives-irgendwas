using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ende1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    public void beenden(){
        SceneManagerCLass.LoadTitleScreen1();
    }
}
