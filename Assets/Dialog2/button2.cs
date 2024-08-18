using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button2 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"PC: Wer spricht da?","???: Eine gute Frage, aber im Moment unwichtig.","???: Wichtiger ist: Welche Regeln gibt es noch?","PC: Regeln? Wovon redest du?","???: Was, hast du es noch nicht bemerkt?","???: ...","???: In dieser Welt gibt es drei Regeln, heiliger als selbst Gott.","???: Wer sie bricht ist verdammt.","PC: ...also war das gerade?","???: Bingo! Das war deine Strafe, kleiner Regelbrecher.","???: Das befürchte ich.","???: obwohl...","???: ...nein. Du würdest es sowieso nicht schaffen.","PC: Was würde ich nicht schaffen?","???: Nichts. Es ist unwichtig.","PC: Sag es mir.","???: Vielleicht gibt es einen Weg zu fliehen...","???: Zuerst musst du alle Regeln kennen.","PC: ...","PC: Sie ist weg.","PC: (Ihre Stimme kam mir irgendwie bekannt vor.)",""};
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
        if(woImText==8){
            Debug.Log("2");
            button2a.SetActive(true);
            buttonText.SetText("Ich darf die Stadt nicht verlassen?");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==9){
            Debug.Log("3");
            button2a.SetActive(false);
            buttonText.SetText("weiter");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==20){
            Debug.Log("4");
            SceneManagerCLass.LoadStadt2();
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
