using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Formatif
{
    class Flotte
    {
        string _nom;
        List<Vehicule> _listeVehicules;

        public Flotte(string no)
        {
            _nom = no;
            _listeVehicules = new();
        }

        public void ChargerFichier()
        {
            string fic = @"C:\examen1\listeVehicules.txt";

            if (File.Exists(fic))
            {
                StreamReader reader = File.OpenText(fic);
                string ligneCourante;

                while (reader.Peek() > -1)
                {
                    
                    ligneCourante = reader.ReadLine();
                    Vehicule v = ParsingVehicule(ligneCourante);
                    _listeVehicules.Add(v);
                }
            }
            else
            {
                Console.WriteLine("Le fichier {0} n'existe pas", fic);
            }
            
        }

        static Vehicule ParsingVehicule(string infoBrute)
        {
            string[] tabInfo = infoBrute.Split(";");
            Position p = new Position(Convert.ToDouble(tabInfo[1]), Convert.ToDouble(tabInfo[2]));
            Vehicule veh = new Vehicule(tabInfo[0],p, Convert.ToInt32(tabInfo[3]), Convert.ToInt32(tabInfo[4]));
            return veh;
        }

        public void TrierListeVehiculeOrdreDecVal()
        {
            _listeVehicules.Sort(Vehicule.TrieParValeur);
        }

        public void TrierListeVehiculeOrdreTonnage()
        {
            _listeVehicules.Sort(Vehicule.TrieParTonnage);
        }

        public void TrieParLongitude(Vehicule v1, Vehicule v2)
        {
            _listeVehicules.Sort(Vehicule.TrieParLongitude);
        }

        public void Afficher()
        {
            Console.WriteLine("Flotte  {0}", _nom);
            for (int i = 0; i < _listeVehicules.Count; i++)
            {
                _listeVehicules[i].Afficher();
            }
        }


    }


}
