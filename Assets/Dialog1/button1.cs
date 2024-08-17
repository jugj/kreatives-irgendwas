using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    private string[] texte1 = {"NPC1: rENn, fLiEH, ScHnell sCHNelL, DU GEHÖRST HIER NICHT HIN! vERsChwInDe aUs DiesEr Stadt", "NPC: DU! dU bIst ANderS! NoCH sElbSt. nIchT wiE wIR... Du SolLTesT NiCHT So eXEStiereN, dU SOLLTesT ErLÖst WerDEn. WIE WIR! uNsere FOrm, waHre PerfeKTIon.","PC: (mit dieser Figur kann man nicht normal reden, es hat seinen Verstand völlig verloren.)",""};
    private int woImText=0;
    private string nextText;
    public TMP_Text starText;

    public string NächsterText(){
        woImText +=1;
        return texte1[woImText];
    }

    public void weiter(){
        nextText = NächsterText();
        starText.SetText(nextText);
        if(nextText=="" ){

        }
    }
}
