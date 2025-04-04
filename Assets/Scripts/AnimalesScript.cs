using System;
using UnityEngine;

public class AnimalesScript : MonoBehaviour
{
    enum Tipodeanimal
    {
        
    }
    #region Variables
    
    [field: SerializeField] public AnimalCode animalCode;
    public int dayCount = 1;

    private int _gramsPerDay = 0;
    private int pricePerGram = 80;

    private int[] _minimumGrams = { 300, 400, 700};
    private string[] _codes = { "G", "PP", "PG" };
    
    #endregion

    #region Methods
    
    private void CheckAnimal()
    {
        for (int i = 0; i < _codes.Length; i++)
        {
            if (_codes[i] == animalCode.ToString())
            {
                _gramsPerDay = _minimumGrams[i];
            }
        }

        if (_gramsPerDay == 0)
        {
            Debug.Log("Error, el codigo proporcionado NO existe.");
        }
    }
    
    #endregion
    
    
    void Start()
    {
        CheckAnimal();
        if (dayCount < 3)
        {
            Debug.Log("La estadia debe ser mayor de 3 dias.");
        }
        else
        {
            var totalGrams = _gramsPerDay * dayCount;
            var totalPrice = (totalGrams / 100) * pricePerGram;
            
            Debug.Log("Para ese periodo, se necesitan: " + totalGrams + "g de alimento.");
            Debug.Log("El precio total de este alimento es: " + totalPrice + "$ pesos");
        }
    }
    
    public enum AnimalCode
    {
        G,
        PP,
        PG
    }

    
}
