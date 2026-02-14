using UnityEngine;
using TMPro;

public class EquationAnswerLevel1 : MonoBehaviour
{
    public TMP_Text val1Text; // Reference to VAL_1
    public TMP_Text val2Text; // Reference to VAL_2
    public TMP_Text val3Text; // Reference to VAL_3

    // Method to validate the answer and return whether it's correct
    public bool ValidateAnswer()
    {
        // Parse the values from the text fields
        if (float.TryParse(val1Text.text, out float val1) &&
            float.TryParse(val2Text.text, out float val2) &&
            float.TryParse(val3Text.text, out float val3))
        {
            // Calculate the result of VAL_1 + VAL_2 * VAL_3
            float result = val1 + val2 * val3;

            // Check if the result equals 42
            return Mathf.Approximately(result, 42f); // Use Mathf.Approximately for floating-point comparison
        }
        else
        {
            Debug.LogError("Invalid input! Please ensure all fields contain valid numbers.");
            return false;
        }
    }

    // Method to clear all three values
    public void ClearValues()
    {
        val1Text.text = ""; // Clear VAL_1
        val2Text.text = ""; // Clear VAL_2
        val3Text.text = ""; // Clear VAL_3
    }
}