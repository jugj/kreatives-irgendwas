using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button3 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"Seltsamer Ball: ...","PC: ...","Seltsamer Ball: ...","PC: ...kannst du mich verstehen?","Seltsamer Ball: Du gehörst hier nicht hin. Du musst gehen.","PC: Ich kann nicht.","Seltsamer Ball: Ich weiß.","PC: Hilf mir. Bitte.","Seltsamer Ball: Könntest du jemanden lieben, selbst wenn diese Person unmögliche Grausamkeiten begonnen hat?","Seltsamer Ball: ...interessant. Bist du dir sicher?","PC: ...","PC: Ja.","Seltsamer Ball: Ich helfe dir.","Seltsamer Ball: Sprich mit der weinenden Dame. Sie ist die Älteste von uns.",""};
    private int woImText=-1;
    private string nextText;
    public TMP_Text starText;
    public TMP_Text buttonText;
    public GameObject button2a;

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
        Debug.Log("1");
        if(woImText==7){
            Debug.Log("2");
            button2a.SetActive(true);
            buttonText.SetText("Ja.");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==8){
            Debug.Log("3");
            button2a.SetActive(false);
            buttonText.SetText("weiter");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==13){
            Debug.Log("4");
            SceneManagerCLass.LoadStadt3();
        }
        else{
            Debug.Log("5");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
    }
    public void weiter2(){
         Debug.Log("3");
        button2a.SetActive(false);
        buttonText.SetText("weiter");
        nextText = NächsterText();
        starText.SetText(nextText);
    }
}
