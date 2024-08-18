using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button4 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"PC: Mir wurde gesagt du kannst mir helfen.","Weinende Dame: Was willst du von mir?","PC: (Brrr! Sie sieht aus als wolle sie mich umbringen!)","PC: Kennst du die zweite Regel?","Weinende Dame: Ha! Was willst du denn schon mit der zweiten Regel?","PC: Ich fliehe.","Weinende Dame: Sicher, dass es das ist, was du willst?","Weinende Dame: ...lächerlich.","Weinende Dame: Hör gut zu. Und pass auf was du tust.","Weinende Dame: Hast du einmal eine Entscheidung getroffen, kannst du diese nicht mehr zurücknehmen.","PC: ...","PC: (Meine ENTSCHEIDUNGEN sind also ENTGÜLTIG, was?)","PC: Danke.",""};
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
        if(woImText==5){
            Debug.Log("2");
            button2a.SetActive(true);
            buttonText.SetText("Ja.");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==6){
            Debug.Log("3");
            button2a.SetActive(false);
            buttonText.SetText("weiter");
            nextText = NächsterText();
            starText.SetText(nextText);
        }
        else if(woImText==12){
            Debug.Log("4");
            SceneManagerCLass.LoadDialog5();
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
