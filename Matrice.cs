// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Matrice
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

namespace TLE_Analyser
{
  public class Matrice
  {
    private Vecteur _vec1;
    private Vecteur _vec2;
    private Vecteur _vec3;

    /// <summary>Constructeur par defaut</summary>
    /// <remarks></remarks>
    public Matrice()
    {
    }

    /// <summary>Constructeur a partir d'une matrice</summary>
    /// <param name="mat">Matrice</param>
    /// <remarks></remarks>
    public Matrice(Matrice mat)
    {
      this._vec1 = mat._vec1;
      this._vec2 = mat._vec2;
      this._vec3 = mat._vec3;
    }

    /// <summary>Constructeur a partir de 3 vecteurs colonnes</summary>
    /// <param name="vec1">Vecteur colonne 1</param>
    /// <param name="vec2">Vecteur colonne 2</param>
    /// <param name="vec3">Vecteur colonne 3</param>
    /// <remarks></remarks>
    public Matrice(Vecteur vec1, Vecteur vec2, Vecteur vec3)
    {
      this._vec1 = vec1;
      this._vec2 = vec2;
      this._vec3 = vec3;
    }

    /// <summary>Transposition d'une matrice</summary>
    /// <returns>Matrice transposee</returns>
    /// <remarks></remarks>
    public Matrice Transpose() => new Matrice(new Vecteur(this._vec1.X, this._vec2.X, this._vec3.X), new Vecteur(this._vec1.Y, this._vec2.Y, this._vec3.Y), new Vecteur(this._vec1.Z, this._vec2.Z, this._vec3.Z));

    /// <summary>Multiplication d'un vecteur 3D par une matrice 3x3</summary>
    /// <param name="vec">Vecteur</param>
    /// <returns>Vecteur multiplie par la matrice</returns>
    /// <remarks></remarks>
    public Vecteur MultVec(Vecteur vec) => new Vecteur(this._vec1.X * vec.X + this._vec2.X * vec.Y + this._vec3.X * vec.Z, this._vec1.Y * vec.X + this._vec2.Y * vec.Y + this._vec3.Y * vec.Z, this._vec1.Z * vec.X + this._vec2.Z * vec.Y + this._vec3.Z * vec.Z);

    /// <summary>Multiplication d'une matrice 3x3 par une matrice 3x3</summary>
    /// <param name="mat">Matrice</param>
    /// <returns>Produit des deux matrices</returns>
    /// <remarks></remarks>
    public Matrice MatMult(Matrice mat) => new Matrice(this.MultVec(mat._vec1), this.MultVec(mat._vec2), this.MultVec(mat._vec3));
  }
}
