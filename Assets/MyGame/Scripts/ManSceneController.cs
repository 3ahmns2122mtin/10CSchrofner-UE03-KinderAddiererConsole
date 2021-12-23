using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private TextAlignment txtResult;

    void Start()
    {
        int val1 = CheckAddition(1,2);
        int val2 = CheckAddition(10, 20);
        int val3 = CheckAddition(100, 200);

        Debug.Log("val1: " + val1 + "val2 +val3" + (val2 + val3));
        Debug.Log("Nach Methodenaufruf sg. call");

        inputFieldTermA.text = "Number";
        inputFieldTermB.text = "Number";
    }

    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;

        Debug.Log("Methode GetValues wird ausgeführt: " + CheckAddition(int.Parse(termA), int.Parse(termB)));
        Debug.Log(termA + " ; " + termB);
    }

    void Update()
    {
    }

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;
        result = summandA + summandB;
        Debug.Log(result);
        return result;
    }
}

