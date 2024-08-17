using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lebensanzeige : MonoBehaviour
{
    public Slider slider;

    // setze Maximal Leben
    public void SetzeMaxLeben(int leben){
        slider.maxValue = leben;
        slider.value = leben;
    }

    // setze aktuelles Leben
    public void SetzeLeben(int leben){
        slider.value = leben;
    }
}
