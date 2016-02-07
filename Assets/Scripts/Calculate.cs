using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculate : MonoBehaviour {
    public OnClick Feet;
    public OnClick Inches;
    public OnClick[] Weight;
    public Text Display;

    void Update() {
        float weight = (Weight[0].Number * 100 + Weight[1].Number * 10 + Weight[2].Number); //convert lb
        weight *= 0.45f; //convert to kg
        float height = Feet.Number * 12 + Inches.Number; //convert to inches
        height *= 0.025f;//convert meters
        height *= height;//square height
        decimal bmi = (decimal)(weight / height);
        Display.text = bmi.ToString("F2");
    }
}
