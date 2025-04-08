using System;
using UnityEngine;

public class Main : MonoBehaviour
{

    
    enum Orientaciones
    {
        T,
        D,
        G,
        M,
        H,
    }
    
    public string nombreAlumno;
    public int gradoAlumno;
    [field: SerializeField] private Orientaciones orientacionAlumno;
    
    void Start()
    {
        if (ValidarInputs())
        {
            print("Muchas gracias, " + nombreAlumno);
        }
    }

    private bool ValidarInputs()
    {
        if (nombreAlumno.Length == 0)
        {
            print("Porfavor, ingresar un nombre");
            return false;
        }

        if (!ValidarEspecialidad())
        {
            print("Porfavor, ingresar una especialidad valida");
            return false;
        }

        if (gradoAlumno < 3)
        {
            print("Todavia sos ciclo basico");
            return false;
        }

        if (gradoAlumno > 5)
        {
            print("Ya te graduaste");
            return false;
        }
        
        return true;
    }

    private bool ValidarEspecialidad()
    {
        return Enum.IsDefined(typeof(Orientaciones), orientacionAlumno);
    }
}
