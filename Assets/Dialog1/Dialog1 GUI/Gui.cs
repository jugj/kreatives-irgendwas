using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 200), "Hello World!");
    }
}