using UnityEngine;
using TMPro; // Make sure to include TextMeshPro namespace

public class NumberManager : MonoBehaviour
{
    public TMP_Text val1Text; // Reference to VAL_1
    public TMP_Text val2Text; // Reference to VAL_2
    public TMP_Text val3Text; // Reference to VAL_3

    private string currentInput = ""; // Stores the current input string
    private TMP_Text activeField; // Tracks the currently active field

    private void Start()
    {
        // Set the default active field to VAL_1
        activeField = val1Text;
    }

    // Method to handle button presses
    public void OnNumberButtonPressed(string number)
    {
        // Clear placeholder text if it matches the default field name
        if (activeField.text == "[VAL_1]" || activeField.text == "[VAL_2]" || activeField.text == "[VAL_3]")
        {
            currentInput = ""; // Reset the current input
        }

        currentInput += number; // Append the pressed number to the current input
        activeField.text = currentInput; // Update the active field's text
    }

    // Method to clear the input for the active field
    public void ClearInput()
    {
        currentInput = "";
        activeField.text = currentInput;
    }

    // Method to switch the active field
    public void SetActiveField(string fieldName)
    {
        switch (fieldName)
        {
            case "VAL_1":
                activeField = val1Text;
                currentInput = val1Text.text;
                break;
            case "VAL_2":
                activeField = val2Text;
                currentInput = val2Text.text;
                break;
            case "VAL_3":
                activeField = val3Text;
                currentInput = val3Text.text;
                break;
        }
    }
}