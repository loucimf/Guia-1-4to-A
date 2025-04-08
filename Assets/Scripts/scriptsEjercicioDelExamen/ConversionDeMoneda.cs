using System;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    private enum Monedas
    {
        D, // = 1335
        E, // = 225
        R, // = 1172
    }

    private float _cotizacionDolar = 1335f;
    private float _cotizacionEuro = 1335f;
    private float _cotizacionReal = 1335f;

    
    [field: SerializeField] private Monedas monedaElegida = Monedas.D;


    public int dineroParaConvertir;
    private readonly int _dineroMinimo = 1000;
    
    private void Start()
    {
        if (dineroParaConvertir < _dineroMinimo)
        {
            print("El monto minimo de dinero es: 1000");
            return;
        }
        
        if (!MonedaValida()) { return; }

        float plata = ConvertirMoneda(monedaElegida);
        
        print("Tu dinero convertido es: " + plata);
    }

    private bool MonedaValida()
    {
        return Enum.IsDefined(typeof(Monedas), monedaElegida);
    }

    private float ConvertirMoneda(Monedas monedaElegida)
    {
        if (monedaElegida == Monedas.D)
        {
            return dineroParaConvertir / _cotizacionDolar;
        }
        if (monedaElegida == Monedas.E)
        {
            return dineroParaConvertir / _cotizacionEuro;
        }
        if (monedaElegida == Monedas.R)
        {
            return dineroParaConvertir / _cotizacionReal;
        }

        return 0f;
    }
}
