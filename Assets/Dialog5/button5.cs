/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"???: Du hast die ersten zwei Regeln.","PC: Fehlt nur noch eine.","???: Ich kenne sie.","PC: !!!","PC: Du bist es!","Sie: Es ist lange her.","Sie: Ich habe dich vermisst.","PC: ...","PC: Ich kann kaum glauben, dass das echt ist.","PC: Wieso bist du hier?","Sie: Das ist nicht wichtig.","Sie: Wir können gehen.","Sie: Gemeinsam.","PC: ...","PC: Ja!","Sie: Komm mit! Lass uns gehen!","PC: Was ist mit den anderen?","Sie: Was soll mit ihnen sein?","PC: Kommen sie nicht mit?"};


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
*/