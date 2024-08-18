using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"PC: Hallo. Kannst du mir helfen?","Seltsamer Ball: ...","PC: ...","Seltsamer Ball: ...","PC: ...kannst du mich verstehen?","Seltsamer Ball: Du gehörst hier nicht hin. Du musst gehen.","PC: Ich kann nicht.","Seltsamer Ball: Ich weiß.","PC: Hilf mir. Bitte.","Seltsamer Ball: Könntest du jemanden lieben, selbst wenn diese Person unmögliche Grausamkeiten begonnen hat?","PC: 1. Ja. 2. Nein.","Seltsamer Ball: ...interessant. Bist du dir sicher?","PC: ...","PC: Ja.","Seltsamer Ball: Ich helfe dir.","Seltsamer Ball: Sprich mit der weinenden Dame. Sie ist die Älteste von uns.",""};
    private int woImText=0;
    private string nextText;
    public TMP_Text starText;

    public string NächsterText(){
        woImText +=1;
        return texte1[woImText];
    }

    public void weiter(){
        nextText = NächsterText();
        if(nextText=="" ){
            SceneManagerCLass.LoadStadt1();
        }
        else{
            starText.SetText(nextText);
        }
    }
}
