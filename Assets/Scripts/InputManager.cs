using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public InputField inputField;
    public Text EnteredText;

    void Start()
    {
        EnteredText.text = " ";
    }
    public void MyText()
    {
        EnteredText.text = "Добро пожаловать " + inputField.text + "";
    }
}
