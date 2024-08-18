using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button5 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"PC: Fehlt nur noch eine.","???: Ich kenne sie.","PC: !!!","PC: Du bist es!","Sie: Es ist lange her.","Sie: Ich habe dich vermisst.","PC: ...","PC: Ich kann kaum glauben, dass das echt ist.","PC: Wieso bist du hier?","Sie: Das ist nicht wichtig.","Sie: Wir können gehen.","Sie: Gemeinsam.","PC: ...","PC: Ja!","Sie: Komm mit! Lass uns gehen!","PC: Was ist mit den anderen?","Sie: Was soll mit ihnen sein?","PC: Kommen sie nicht mit?","Sie: Sie kommen nicht mit.","PC: Sie leiden.","Sie: Sie sind verdammt. Sie können nicht mit.","Sie: Vertrau mir.","PC: Ich kann ihnen helfen.","Sie: Man kann Ihnen nicht helfen.","Sie: Vertrau mir. Bitte."};

    private int woImText=-1;
    private string nextText;
    public TMP_Text starText;
    public TMP_Text buttonText;
    public GameObject button2a;
    private bool gedrückt1=false;
    private bool gedrückt2=false;

    public void Start(){
        button2a.SetActive(false);
    }
    
    public string NächsterText(){
        woImText +=1;
        return texte1[woImText];
    }

    public void Test(){
        Debug.Log("test");
    }

    public void Weiter1(){
        if(gedrückt1==false&&gedrückt2==false){
            if(woImText==23){
                Debug.Log("2");
                button2a.SetActive(true);
                buttonText.SetText("Ich vertraue dir.");
                nextText = NächsterText();
                starText.SetText(nextText);
                gedrückt1=true;
            }
            else{
                Debug.Log("5");
                nextText = NächsterText();
                starText.SetText(nextText);
            }
        }
        else{
            if(woImText==24){
                Debug.Log("3");
                gedrückt1=true;
                button2a.SetActive(false);
                buttonText.SetText("weiter");
                starText.SetText("Dann komm. Wir gehen.");
                woImText=woImText+1;
            }
            else if(gedrückt1==true){
                Debug.Log("3");
                gedrückt1=false;
                gedrückt2=false;
                SceneManagerCLass.LoadEnde1();
            }
            else if(gedrückt2==true){
                Debug.Log("3");
                gedrückt1=false;
                gedrückt2=false;
                SceneManagerCLass.LoadEnde2();
            }
        }
    }

    public void weiter2(){
        Debug.Log("3");
        gedrückt2=true;
        button2a.SetActive(false);
        buttonText.SetText("weiter");
        starText.SetText("Ich verstehe... auf Wiedersehen.");
        woImText=woImText+1;
    }
}
