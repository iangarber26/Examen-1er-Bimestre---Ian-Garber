using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ01 : MonoBehaviour
{
    public string nombre_de_alumno;
    public int año;
    public string orientación;

    // Start is called before the first frame update
    void Start()
    {
        if (año > 5)
        {
            Debug.Log("El año ingresado no está en el rango del 1 al 5");
}
        else if (año < 4)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else
        switch (orientación)
        {
            case "T":
                Debug.Log("Muchas gracias " + nombre_de_alumno);
                break;
            case "D":
                Debug.Log("Muchas gracias " + nombre_de_alumno);
                break;
            case "G":
                Debug.Log("Muchas gracias " + nombre_de_alumno);
                break;
            case "M":
                Debug.Log("Muchas gracias " + nombre_de_alumno);
                break;
            case "H":
                Debug.Log("Muchas gracias " + nombre_de_alumno);
                break;
            default:
                Debug.Log("Sólo se puede ingresar la inicial en mayúscula de la especialidad: T para TIC, D para Diseño, G para Gestión, M para Medios y H para Humanidades");
                break;
}
}
        

        // Update is called once per frame
        void Update()
    {
        
    }
}
