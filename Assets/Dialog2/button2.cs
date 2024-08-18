using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"???: Na, sieh mal an... Du hast also die erste Regel gebrochen.", "PC: Wer spricht da?","???: Eine gute Frage, aber im Moment unwichtig.","???: Wichtiger ist: Welche Regeln gibt es noch?","PC: Regeln? Wovon redest du?","???: Was, hast du es noch nicht bemerkt?","???: ...","???: In dieser Welt gibt es drei Regeln, heiliger als selbst Gott.","???: Wer sie bricht ist verdammt.","PC: ...also war das gerade?","???: Bingo! Das war deine Strafe, kleiner Regelbrecher.","PC: ...","PC: 1. Ich darf die Stadt nicht verlassen? 2. Ich bin hier gefangen.","???: Das befürchte ich.","???: obwohl...","???: ...nein. Du würdest es sowieso nicht schaffen.","PC: Was würde ich nicht schaffen?","???: Nichts. Es ist unwichtig.","PC: Sag es mir.","???: Vielleicht gibt es einen Weg zu fliehen...","???: Zuerst musst du alle Regeln kennen.","PC: ...","PC: Sie ist weg.","PC: (Ihre Stimme kam mir irgendwie bekannt vor.)",""};
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
