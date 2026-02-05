using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    // Renvoie la magnitude d'un vecteur.
    public static double Magnitude(double[] vector)
    {
        if (vector.Count() == 2)
        {
            // Calcul de la magnitude d'un vecteur 2D
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            return Math.Round(Math.Sqrt(a + b), 2);
        }
        else if (vector.Count() == 3)
        {
            // Calcul de la magnitude d'un vecteur 3D
            double a = vector[0] * vector[0];
            double b = vector[1] * vector[1];
            double c = vector[2] * vector[2];
            return Math.Round(Math.Sqrt(a + b + c), 2);
        }
        else
        {
            return -1;
        }
    }
}
