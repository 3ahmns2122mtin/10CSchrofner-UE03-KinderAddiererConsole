using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    private int termA = 0, termB = 0;



    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;
        result = summandA + summandB;
        Debug.Log(result);
        txtResult.text = string.Format("{0}", result);
        return result;
    }


    public void GetValues()
    {
    
        try
        {
            termA = int.Parse(inputFieldTermA.text);
        }
        catch (System.Exception)
        {

            inputFieldTermA.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "ungültige Zahl";
            inputFieldTermA.text = "";
        }
        try
        {
            termB = int.Parse(inputFieldTermB.text);
        }
        catch (System.Exception)
        {
            inputFieldTermB.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "ungültige Zahl";
            inputFieldTermB.text = "";
        }
        txtResult.text = CheckAddition(termA, termB).ToString();
    }



    public void ResetAll()
    {
        txtResult.text = "";
        inputFieldTermA.text = "";
        inputFieldTermB.text = "";
        termA = 0;
        termB = 0;
        Color newColor = new Color(222, 192, 203, 255);
        inputFieldTermA.GetComponent<InputField>().image.color = newColor;
        inputFieldTermB.GetComponent<InputField>().image.color = newColor;
        inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Gültige Zahl eingeben";
        inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Gültige Zahl eingeben";
    }
    void Update()
    {


    }
}