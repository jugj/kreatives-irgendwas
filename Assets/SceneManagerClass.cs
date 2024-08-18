using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerCLass : MonoBehaviour
{
    public void LoadDialog1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void LoadDialog2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void LoadDialog3(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void LoadDialog4(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }

    public void LoadStadt1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }

    public void LoadStadt2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }

    public void LoadStadt3(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);
    }

    public void LoadTitleScreen1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(9);
    }

    public void LoadTitleScreen2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(10);
    }

    public void LoadEnde1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }

    public void LoadEnde2(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public void LoadStadt1a(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(11);
    }
}
