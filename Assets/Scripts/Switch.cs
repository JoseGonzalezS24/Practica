using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Switch : MonoBehaviour
{
    [SerializeField] private int input;
    [SerializeField] private TextMeshProUGUI text;

    public void ShowMessage()
    {
        switch (input)
        {
            case 0:
                text.text = "la variable está muy baja";
                break;
            case 1:
                text.text = "la variable está en su punto";
                break;
            case 2:
                text.text = "la variable está muy alta";
                break;
            default:
                text.text = "la variable está en default";
                break;
        }
    }
}
