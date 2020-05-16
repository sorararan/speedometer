using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    [SerializeField] private Text endText;

    void Start() {
        endText.text = "";
    }

    public void setEndText(bool is_clear) {
        if(is_clear) {
            endText.text = "clear!!!";
        }else {
            endText.text = "game over";
        }
    }
}
