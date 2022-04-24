// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Vecteur
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace TLE_Analyser
{
  public class Vecteur
  {
    private double _x;
    private double _y;
    private double _z;

    /// <summary>Constructeur par defaut</summary>
    /// <remarks></remarks>
    public Vecteur()
    {
    }

    /// <summary>Constructeur a partir d'un vecteur</summary>
    /// <param name="vec">Vecteur</param>
    /// <remarks></remarks>
    public Vecteur(Vecteur vec)
    {
      this._x = vec._x;
      this._y = vec._y;
      this._z = vec._z;
    }

    /// <summary>Constructeur a partir de 3 reels</summary>
    /// <param name="x">Composante x du vecteur</param>
    /// <param name="y">Composante y du vecteur</param>
    /// <param name="z">Composante z du vecteur</param>
    /// <remarks></remarks>
    public Vecteur(double x, double y, double z)
    {
      this._x = x;
      this._y = y;
      this._z = z;
    }

    /// <summary>Norme d'un vecteur 3D</summary>
    /// <returns>Norme du vecteur</returns>
    /// <remarks></remarks>
    public double Norme() => Math.Sqrt(this._x * this._x + this._y * this._y + this._z * this._z);

    /// <summary>Oppose d'un vecteur</summary>
    /// <returns>Oppose du vecteur</returns>
    /// <remarks></remarks>
    public Vecteur Oppose() => new Vecteur(-this._x, -this._y, -this._z);

    /// <summary>Soustraction de 2 vecteurs 3D</summary>
    /// <param name="vec">Vecteur soustractif</param>
    /// <returns>Vecteur soustrait</returns>
    /// <remarks></remarks>
    public Vecteur Moins(Vecteur vec) => new Vecteur(this._x - vec._x, this._y - vec._y, this._z - vec._z);

    /// <summary>Multiplication d'un vecteur 3D par un scalaire</summary>
    /// <param name="xval">Valeur scalaire</param>
    /// <returns>Vecteur multiplie par le scalaire</returns>
    /// <remarks></remarks>
    public Vecteur MultScal(double xval) => new Vecteur(this._x * xval, this._y * xval, this._z * xval);

    /// <summary>Calcul du vecteur 3D unitaire</summary>
    /// <returns>Vecteur 3D unitaire</returns>
    /// <remarks></remarks>
    public Vecteur Normalise()
    {
      double num = this.Norme();
      return new Vecteur(this.MultScal(Conversions.ToDouble(Interaction.IIf(num < 1E-10, (object) 1.0, (object) (1.0 / num)))));
    }

    /// <summary>Produit scalaire de 2 vecteurs 3D</summary>
    /// <param name="vec">Vecteur</param>
    /// <returns>Produit scalaire</returns>
    /// <remarks></remarks>
    public double ProduitScalaire(Vecteur vec) => this._x * vec._x + this._y * vec._y + this._z * vec._z;

    /// <summary>Produit vectoriel de 2 vecteurs 3D</summary>
    /// <param name="vec">Vecteur</param>
    /// <returns>Produit vectoriel</returns>
    /// <remarks></remarks>
    public Vecteur ProduitVectoriel(Vecteur vec) => new Vecteur(this._y * vec._z - this._z * vec._y, this._z * vec._x - this._x * vec._z, this._x * vec._y - this._y * vec._x);

    /// <summary>Angle entre 2 vecteurs 3D</summary>
    /// <param name="vec">Vecteur</param>
    /// <returns>Angle en radians</returns>
    /// <remarks></remarks>
    public double Angle(Vecteur vec)
    {
      double num1 = this.Norme();
      double num2 = vec.Norme();
      return num1 >= 1E-12 && num2 >= 1E-12 ? Math.Acos(this.ProduitScalaire(vec) / (num1 * num2)) : 0.0;
    }

    public double X => this._x;

    public double Y => this._y;

    public double Z => this._z;
  }
}
