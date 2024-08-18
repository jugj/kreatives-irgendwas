/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class button1 : MonoBehaviour
{
    public SceneManagerCLass SceneManagerCLass;
    private string[] texte1 = {"PC: Bist du die weinende Dame?","PC: Mir wurde gesagt du kannst mir helfen.","Weinende Dame: Was willst du von mir?","PC: (Brrr! Sie sieht aus als wolle sie mich umbringen!)","PC: Kennst du die zweite Regel?","Weinende Dame: Ha! Was willst du denn schon mit der zweiten Regel?","PC: Ich fliehe.","Weinende Dame: Sicher, dass es das ist, was du willst?","PC: 1. Ja. 2. Nein.","Weinende Dame: ...lächerlich.","Weinende Dame: Hör gut zu. Und pass auf was du tust.","Weinende Dame: Hast du einmal eine Entscheidung getroffen, kannst du diese nicht mehr zurücknehmen.","PC: ...","PC: (Meine Entscheidungen sind also endgültig, was?)","PC: Danke.",""};
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
*/