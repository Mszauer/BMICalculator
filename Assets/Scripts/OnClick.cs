using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {
    public Text Display;
    public OnClick PrevDisplay;
    public int MaxValue = 11;
    public int MinValue = 1;
    public int Number {
        get {
            return System.Convert.ToInt32(Display.text);
        }
        set {
            Display.text = value.ToString();
        }
    }
    public void OnIncrease() {
        Number++;
        if (Number > MaxValue) {
            Number = MaxValue;
            if (PrevDisplay != null) {
                PrevDisplay.OnIncrease();
                Number = MinValue;
            }
        }
    }
    public void OnDecrease() {
        Number--;
        if (Number < MinValue) {
            Number = MinValue;
            if (PrevDisplay != null) {
                PrevDisplay.OnDecrease();
                Number = MaxValue;
            }
        }
    }
}
