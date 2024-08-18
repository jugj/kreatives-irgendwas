using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"???: Du hast die ersten zwei Regeln.","PC: Fehlt nur noch eine.","???: Ich kenne sie.","PC: !!!","PC: Du bist es!","Sie: Es ist lange her.","Sie: Ich habe dich vermisst.","PC: ...","PC: Ich kann kaum glauben, dass das echt ist.","PC: Wieso bist du hier?","Sie: Das ist nicht wichtig.","Sie: Wir können gehen.","Sie: Gemeinsam.","PC: ...","PC: Ja!","Sie: Komm mit! Lass uns gehen!","PC: Was ist mit den anderen?","Sie: Was soll mit ihnen sein?","PC: Kommen sie nicht mit?",
"Sie": Sie kommen nicht mit.
PC: Sie leiden.
"Sie": Sie sind verdammt. Sie können nicht mit.
"Sie": Vertrau mir.
PC: Ich kann ihnen helfen.
"Sie": Mann kann Ihnen nicht helfen.
"Sie":  Vertrau mir. Bitte.
PC: 1. Ich vertraue dir. 2. Es tut mir leid.NPC1: rENn, fLiEH, ScHnell sCHNelL, DU GEHÖRST HIER NICHT HIN! vERsChwInDe aUs DiesEr Stadt", "NPC: DU! dU bIst ANderS! NoCH sElbSt. nIchT wiE wIR... Du SolLTesT NiCHT So eXEStiereN, dU SOLLTesT ErLÖst WerDEn. WIE WIR! uNsere FOrm, waHre PerfeKTIon.","PC: (mit dieser Figur kann man nicht normal reden, es hat seinen Verstand völlig verloren.)",""};
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
