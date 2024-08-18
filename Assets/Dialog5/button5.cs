using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"???: Du hast die ersten zwei Regeln.","PC: Fehlt nur noch eine.","???: Ich kenne sie.","PC: !!!","PC: Du bist es!","Sie: Es ist lange her.","Sie: Ich habe dich vermisst.","PC: ...","PC: Ich kann kaum glauben, dass das echt ist.","PC: Wieso bist du hier?","Sie: Das ist nicht wichtig.","Sie: Wir können gehen.","Sie: Gemeinsam.","PC: ...","PC: Ja!","Sie: Komm mit! Lass uns gehen!","PC: Was ist mit den anderen?","Sie: Was soll mit ihnen sein?","PC: Kommen sie nicht mit?","Sie: Sie kommen nicht mit.","PC: Sie leiden.","Sie: Sie sind verdammt. Sie können nicht mit.","Sie: Vertrau mir.","PC: Ich kann ihnen helfen.","Sie: Mann kann Ihnen nicht helfen.","Sie: Vertrau mir. Bitte.","PC: 1. Ich vertraue dir. 2. Es tut mir leid.","Sie: 1. Dann komm. Wir gehen. 2. Ich verstehe... auf Wiedersehen.",""};
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
