using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatif
{
    class Vehicule
    {
        string _matricule;
        Position _emplacement;
        int _tonnage;
        int _valeur;

        public Vehicule()
        {
            _matricule = "VIDE";
            _emplacement = new();
            _tonnage = 0;
            _valeur = 0;
        }

        public Vehicule(string mat, Position position, int ton, int val)
        {
            _matricule = mat;
            _emplacement = position;
            _tonnage = ton;
            _valeur = val;
        }

        public void Afficher()
        {
            Console.WriteLine("Véhicule : " + _matricule);
            _emplacement.Afficher();
            Console.WriteLine("Tonnage : {0};\n Valeur : {1}", _tonnage,_valeur );
        }

        public static int TrieParValeur(Vehicule v1, Vehicule v2)
        {
            return v2._valeur - v1._valeur;
        }

        public static int TrieParTonnage(Vehicule v1, Vehicule v2)
        {
            return v1._tonnage - v2._tonnage;
        }

        public static int TrieParLongitude(Vehicule v1, Vehicule v2)
        {
            return (int)(v1._emplacement.Longitude - v2._emplacement.Longitude);
        }

        

    }




}
