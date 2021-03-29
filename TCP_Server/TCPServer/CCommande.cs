/*------------------------------------------------------------------------
 TP Four IUT Annecy Génie Electrique et Informatique Industrielle             mars 2021
//------------------------------------------------------------------------
 But: SIMULATEUR DE RÉGULATION DE VITESSE DE MOTEUR A COURANT CONTINU EN C#

 Ce programme:

  -présente une fenêtre App visualisant la régulation du moteur
        -choix mode statique ou dynamique
        -lecture/écriture de la vitesse et de la charge
        -lecture de la tension et du courant
        -courbes de vitesse et de tension
        -visualisation du moteur

  -présente une fenêtre Server qui gère la liaison TCP/IP avec un client extérieur
        -autoriser la connexion
        - échanges des données avec le le client(vitesse, charge, courant, tension)

  -présente une classe CCommande qui calcule l'asservissement du moteur

//------------------------------------------------------------------------
 Licence LGPL: Ce code source développé dans un but purement éducatif
               peut être utilisé et recopié librement.
//------------------------------------------------------------------------

Cette classe CCommande s'occupe de calculer l'asservissement de la vitesse du moteur, en fonction du mode choisi(dynamique ou statique)


------------------------------------------------------------------------
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TCPServer
{

    public class CCommande
    {
        public App mapp;                                      // nécessaires à l'association avec App et Server //             
        public Form1 mServer;

        
        public double[] dtension = new double[3];             // tableaux contenants: l'état initial(resp dtension[0])
        public double[] dCourant = new double[3];             //                      l'état d'avant(resp dtension[i - 1] )            
        public double[] dErreur = new double[3];              //                      l'état en cours (resp dtension[i])
        public double[] dVitesse = new double[3];
      


                   
        public double dResistance = 32;                       //Resistance du moteur                  voir datasheet en annexe du projet
        public double dInductance = 0.0416;                   //Inductance du moteur
        public double dInertie = 190;                         // moment d'inertie du moteur

        public double dX;                                     //constantes pour faciliter le calcul en dynamique
        public double dY;

        public string svitesse = "0";                         //résultats en string affichés dans App
        public string scourant = "0";
        public string sTension = "0";
        
        public double dke = 0.0448F;                          //constante électromagnétique
        
        public int i = 2;                                     //constante d'état du tableau( départ à 2 car calcul de dVitesse[i - 2] en dynamique)

        public float fPeriodeEchantillonage = 0.1F;           //initialisation de la période d'échantillonnage(égale à la T du timer10(voir App)

            



        public CCommande()
        {
            dtension[0] = 24;                                 //initialisation des tableaux: U=24V (voir datasheet)
            dtension[1] = 24;                                   
            dVitesse[0] = 0;                                
            dVitesse[1] = 0;
            
            dErreur[0] = 0; 
            
            dX = dke + (dResistance * dInertie) / (dke * fPeriodeEchantillonage) + (dInductance * dInertie) /(dke* (Math.Pow(fPeriodeEchantillonage, 2)));     //constantes utilisant des valeurs fixes(R,L) pour faciliter le calcul en dynamique
            dY = ((dResistance * dInertie) / (dke * fPeriodeEchantillonage) + (2 * dInductance * dInertie) /(dke* (Math.Pow(fPeriodeEchantillonage, 2))));
        }

        /*------------------------------------------------------------------------
      Commande: méthode de calcul appellée à chaque coup de timer
        ------------------------------------------------------------------------
        */


        public void Commande(double dCvitesse, double dCharge)                      //paramètres d'entrée: consigne vitesse et consigne charge
        {
         
            
            dErreur[i] = dCvitesse - dVitesse[i - 1];                               //calcul l'erreur entre la consigne et la vitesse du coup d'avant
            dtension[i] = (dtension[i - 1] + mapp.Ki * dErreur[i] * fPeriodeEchantillonage + mapp.Kp * dErreur[i] + mapp.Kd * (dErreur[i] - dErreur[i - 1]));               //calcul de la tension


            if (mapp.checkDynamique.Checked)                           //si demande en DYNAMIQUE (somme des couples=moment d'inertie* accélération)
            {
            

                dVitesse[i] = (dtension[i] + dVitesse[i - 1] * dY - (dVitesse[i - 2] * dInductance * dInertie / (Math.Pow(fPeriodeEchantillonage, 2))) + (dResistance * dCharge / dke)) / dX;      //calcul de la vitesse
                dCourant[i] = (dInertie * (dVitesse[i] - dVitesse[i - 1]) - dCharge * fPeriodeEchantillonage) / (dke * fPeriodeEchantillonage);      //calcul du courant en dynamique

            }

            else if(mapp.checkstatique.Checked) {                       //si demande en STATIQUE

                dInertie = 190;
                dVitesse[i] = (dtension[i] / dke) - ((dResistance * dCharge) / (Math.Pow(dke, 2)));  //calcul vitesse
                dCourant[i] = (dtension[i] - dke * dVitesse[i]) / dResistance;                                  //calcul courant             
            }

            if(dtension[i] > 24)                            //si la tension est supérieur à la Umax du moteur(voir datasheet)
            {
                dtension[i] = 24;                          //on la met à la Umax        
            }
            else if(dtension[i]< 0)                         
            {
                dtension[i] = 0;
            }


            
           

                dVitesse[i - 2] = dVitesse[i - 1];        // les états d'avant deviennent les états en cours pour le coup suivant
                dErreur[i - 1] = dErreur[i];
                dVitesse[i - 1] = dVitesse[i];
                dtension[i - 1] = dtension[i];



                sTension = dtension[i].ToString();        //string qui seront affichés dans App et envoyés au client
                svitesse = dVitesse[i].ToString();        
                scourant = dCourant[i].ToString();
        
          
         

        }
    }
}
