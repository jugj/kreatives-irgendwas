using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttoncontrol : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;

    public void TryAgain(){
        SceneManagerCLass.LoadStadt2();
    }

    public void Reset(){
        SceneManagerCLass.LoadTitleScreen1();
    }
}
