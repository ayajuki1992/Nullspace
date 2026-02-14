using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public GameObject level1; // Reference to the Level_1 GameObject
    public TMP_Text accessGrantedText; // Reference to the Access_Granted text element
    public TMP_Text accessDeniedText; // Reference to the Access_Denied text element
    public EquationAnswerLevel1 equationAnswer; // Reference to the EquationAnswerLevel1 script

    public float flashDuration = 2f; // Duration to show the Access_Granted or Access_Denied text

    // Method to check the answer and handle the result
    public void CheckAnswerAndHandleResult()
    {
        if (equationAnswer == null)
        {
            Debug.LogError("EquationAnswerLevel1 script is not assigned!");
            return;
        }

        // Use the existing CheckAnswer method in EquationAnswerLevel1
        bool isCorrect = equationAnswer.ValidateAnswer();

        // Start the coroutine to handle the result
        StartCoroutine(HandleResult(isCorrect));
    }

    // Coroutine to handle the result
    private System.Collections.IEnumerator HandleResult(bool isCorrect)
    {
        // Hide Level_1
        if (level1 != null)
        {
            level1.SetActive(false);
        }

        // Show the appropriate text
        if (isCorrect)
        {
            accessGrantedText.gameObject.SetActive(true);
        }
        else
        {
            accessDeniedText.gameObject.SetActive(true);
        }

        // Wait for the flash duration
        yield return new WaitForSeconds(flashDuration);

        // Hide the text elements
        accessGrantedText.gameObject.SetActive(false);
        accessDeniedText.gameObject.SetActive(false);

        // Re-enable Level_1
        if (level1 != null)
        {
            level1.SetActive(true);
        }
    }
}