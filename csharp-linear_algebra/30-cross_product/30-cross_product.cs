using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // Vérification que les deux vecteurs sont des vecteurs 3D
        if (vector1 == null || vector2 == null ||
            vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] { -1 };
        }

        // Calcul du produit vectoriel
        double[] result = new double[3];

        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1]; // x
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2]; // y
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0]; // z

        return result;
    }
}
