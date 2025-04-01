using UnityEngine;

public class CalculosCustom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float num1, num2;
    float _resultado;
    void Start()
    {
        _resultado = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " = " + _resultado);
        _resultado = num1 - num2;
        Debug.Log("La resta entre " + num1 + " y " + num2 + " = " + _resultado);
        _resultado = num1 / num2;
        Debug.Log("La division entre " + num1 + " y " + num2 + " = " + _resultado);
        _resultado = num1 * num2;
        Debug.Log("La multiplicacion entre " + num1 + " y " + num2 + " = " + _resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
