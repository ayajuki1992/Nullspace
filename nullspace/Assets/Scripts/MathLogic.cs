using UnityEngine;
using System.Data; // Required for DataTable.Compute

public class MathLogic : MonoBehaviour
{
    // Adds two numbers
    public float Add(float a, float b)
    {
        return a + b;
    }

    // Subtracts the second number from the first
    public float Subtract(float a, float b)
    {
        return a - b;
    }

    // Multiplies two numbers
    public float Multiply(float a, float b)
    {
        return a * b;
    }

    // Divides the first number by the second
    public float Divide(float a, float b)
    {
        if (b == 0)
        {
            Debug.LogError("Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }

    // Calculates a number raised to the power of another
    public float Power(float baseNumber, float exponent)
    {
        return Mathf.Pow(baseNumber, exponent);
    }

    // Evaluates a mathematical expression following BIDMAS
    public float EvaluateExpression(string expression)
    {
        try
        {
            DataTable table = new DataTable();
            object result = table.Compute(expression, string.Empty);
            return System.Convert.ToSingle(result);
        }
        catch
        {
            Debug.LogError("Invalid expression.");
            return 0;
        }
    }
}