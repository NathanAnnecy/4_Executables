/*------------------------------------------------------------------------

App s'occupe de l'affichage(courbes, moteur, valeurs), des timers(moteur et valeurs en temps réel) 
Methodes:
            - RESET:permet de réinitialiser les graphiques et les label
            -BtnGO_Click: à l'appui du bouton GO!(serveur), lance la régulation
            -TimerMoteur_Tick: timer pour la vitesse de rotation de l'image du moteur uniquement
            -Graphique(): gère l'affichage des courbes 
            -Timer10_Tick: appel la fonction Commande de CCommande à chaque coup, en lui envoyant la consigne venue du serveur ou du client + affiche les valeurs+ les points sur les courbes

------------------------------------------------------------------------
*/







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;                          //utilisation de ZedGraph pour les courbes

namespace TCPServer
{
    public  partial class App : Form
    {

        public CCommande mcommande;             //nécessaires à l'association
        public Form1 mServer;

        Bitmap bmp;                             // variable image pour le moteur
       
        GraphPane mGrapheVitesse = new GraphPane();                 // initialiser un graphe
        GraphPane mGrapheTension = new GraphPane();
      
        readonly PointPairList  ListEchantillonVitesse = new PointPairList();           //initialiser des listes de points
        readonly PointPairList  ListEchantillonTension = new PointPairList();
        

        public LineItem GraphVitesse;                   //initialiser une courbe
        public LineItem GraphTension;




        public double dCVitesse;                            //variables utiles
        public double dCharge;
        public double Kp;
        public double Ki;
        public double Kd;
        public float i = 0;
        public bool bchoix = false;
        public string replaceKp;
        public string replaceKi;
        public string replaceKd;
        bool ival = false;                                  //variable d'état
      
        

        public App()
        {
            InitializeComponent();

            timer10.Tick += Timer10_Tick;                   //méthode timer10.Tick associée à l'event Timer10_Tick

        }


        private void App_Load(object sender, EventArgs e)
        {
         
            try                                                         //ajout de l'image du moteur
            {
                bmp = (Bitmap)Bitmap.FromFile(@"moteur.png");
                PictureMoteur.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureMoteur.Image = bmp;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("image non trouvée");
            }
            

        }

        //--------------------------------------------------------------
        // METHODE BOUTON GO
        //--------------------------------------------------------------


        private void BtnGO_Click(object sender, EventArgs e)
        {

            Reset();
            bchoix = true;                                      // savoir que la demande vient du serveur dans timer10_Tick
            Graphique();                                        //apparition des graphiques sans courbes


           
         

                if (txtboxKp.Text == "")                            //récupération des coefficients:
                {
                    Kp = 0;
                }
                else
                {
                    
                    replaceKp = txtboxKp.Text;
                    replaceKp = replaceKp.Replace('.', ',');
                    Kp = double.Parse(replaceKp);                       //Kp
                }
                if (txtboxKi.Text == "")
                {
                    Ki = 0;
                }
                else
                {
                    replaceKi = txtboxKi.Text;
                    replaceKi = replaceKi.Replace('.', ',');
                    Ki = double.Parse(replaceKi);                           //ki
                }
                if (txtboxKd.Text == "")
                {
                    Kd = 0;
                }
                else
                {
                    replaceKd = txtboxKd.Text;
                    replaceKd = replaceKd.Replace('.', ',');
                    Kd = double.Parse(replaceKd);                           //kd
                }

                if (string.IsNullOrEmpty(txtVitesse.Text) || string.IsNullOrEmpty(txtCharge.Text))
                {
                    MessageBox.Show("you must enter a speed and a load torque");            //si il manque une des deux valeurs
                }
                else
                {
                    try
                    {

                        timerMoteur.Start();                                                //démarrage des timers(qui lancent l'affichage et le calcul) 

                        timer10.Start();
                        lblconsigne.Text = txtVitesse.Text;
                        lblcharge.Text = txtCharge.Text;                    //affichage de la consigne et de la charge



                    }
                    catch
                    {
                        MessageBox.Show("La vitesse doit être un entier et être supérieure à 0 et inférieure à 15000 ");            // si la vitesse n'est pas bien renseignée
                    }
                }
           
        }


        //--------------------------------------------------------------
        // METHODE AFFICHAGE MOTEUR TOURNANT
        //--------------------------------------------------------------
        private void TimerMoteur_Tick(object sender, EventArgs e)         //à chaque coup du timer 
        {
            if ((Convert.ToDouble(lblvitesse.Text) > 1) && (Convert.ToDouble(lblvitesse.Text) < 15000))    //calcul de la vitesse du moteur
            {
                int ivitesse = System.Convert.ToInt32(Convert.ToDouble(lblvitesse.Text));
                timerMoteur.Interval = (60000 / (4 * ivitesse));                                    //60 000 car 1 minutes = 60 000 ms et le 4 vient du fait que l'on tourne de 90° l'image donc 4 pour 360°
            }
            if (bmp != null)                                                //si il y a un fichier image
            {
                
                bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);                  //l'image tourne de 90°                
                PictureMoteur.Image = bmp;                                                  
               
            }
        }

        //--------------------------------------------------------------
        // METHODE AFFICHAGE DES COURBES
        //--------------------------------------------------------------

        public void Graphique()
        {

            //------------------------Courbe Vitesse-----------------------------//

                                                            
            mGrapheVitesse = ZDGrapheVitesse.GraphPane;                 // créer un volet

            
            mGrapheVitesse.Title.Text = "Courbe de la vitesse";         // titre

            
            mGrapheVitesse.YAxis.Title.Text = "Vitesse";                // titres des axes
            mGrapheVitesse.XAxis.Title.Text = "temps";

 
           

           
            GraphVitesse = mGrapheVitesse.AddCurve(null, ListEchantillonVitesse, Color.Blue, SymbolType.None);      //ajouter les points sur le volet
           

          
          
            ZDGrapheVitesse.AxisChange();                       //dessin
            ZDGrapheVitesse.Refresh();

            
            //------------------------Courbe Tension-----------------------------//
            
            
           
            mGrapheTension = ZDGrapheTension.GraphPane;              // créer un volet

            mGrapheTension.Title.Text = "Courbe de la tension";      // titre

            
            mGrapheTension.YAxis.Title.Text = "tension";                // titres des axes
            mGrapheTension.XAxis.Title.Text = "temps";

        


           
            GraphTension = mGrapheTension.AddCurve(null, ListEchantillonTension, Color.Red, SymbolType.None);           //ajouter les points sur le volet
      


            ZDGrapheTension.AxisChange();               //dessin
            ZDGrapheTension.Refresh();
        }

        //--------------------------------------------------------------
        // METHODE APPEL DU TIMER10
        //--------------------------------------------------------------


        private void Timer10_Tick(object sender, EventArgs e)
        {
            i ++;                               //incrémentation à chaque coup de timer pour affichage des courbes

            //--------------------------------------------------------------
            // AFFICHER TEMPS QUE METS LE MOTEUR POUR ARRIVER A LA CONSIGNE
            //--------------------------------------------------------------
            if ((Convert.ToDouble(lblvitesse.Text) < Convert.ToDouble(lblconsigne.Text) * 0.95) || (Convert.ToDouble(lblvitesse.Text) > (Convert.ToDouble(lblconsigne.Text) * 1.05)))                   
            {

                lbltps.Text = Convert.ToString(100 * i);
            }

            //--------------------------------------------------------------

            if (bchoix==true)                                          //si la commande provient de App (BTN GO)
            {
               
                    dCVitesse = System.Convert.ToDouble(txtVitesse.Text);       //récupération de la vitesse textbox
                    string dC = txtCharge.Text;                              //récupération de la charge textbox
                    dC = dC.Replace('.', ',');                               //remplacement du . en ,
                    dCharge = double.Parse(dC);                                 //passage en double
               
                 
               


            }
            else                                                      //Si la commande provient du client 
            {

                
                dCVitesse = mServer.dS;                                 //on récupère les valeurs demandées par le client
                dCharge = mServer.dT;
              
                
            }


                mcommande.Commande(dCVitesse, dCharge);                         //on appelle la fonction Commande qui s'occupe de la régulation
                this.lbltension.Text = mcommande.sTension;                          //on affiche en tps réel
                this.lblvitesse.Text = mcommande.svitesse;
                this.lblcourant.Text = mcommande.scourant;


                ListEchantillonVitesse.Add(i, mcommande.dVitesse[mcommande.i]);                 //on rajoute les points sur les courbe vitesse et tension
                ListEchantillonTension.Add(i, mcommande.dtension[mcommande.i]);
                ival = true;                                                        //nécessaire pour Reset()

            ZDGrapheVitesse.Refresh();                                              //on rafraîchit  les courbes(+ évite le lag)
            ZDGrapheVitesse.AxisChange();
            ZDGrapheTension.Refresh();
            ZDGrapheTension.AxisChange();


        }

        //--------------------------------------------------------------
        // BOUTON RESET
        //--------------------------------------------------------------

        private void Button1_Click(object sender, EventArgs e)                          
        {
            Reset();                                                        
        }

        //--------------------------------------------------------------
        // METHODE RESET
        //--------------------------------------------------------------

        public void Reset()
        {
            

            

            if (ival == true)                                                                   //si on est déjà passé dans Timer10, donc qu'il y a une courbe affichée( car effacer une courbe inexistante met une erreur)
            {
                ZDGrapheVitesse.GraphPane.CurveList[0].Clear();                                 //on efface les courbes
                ZDGrapheTension.GraphPane.CurveList[0].Clear();
            }
              
            ZDGrapheVitesse.Refresh();                                                             
            ZDGrapheTension.Refresh();
            timer10.Stop();                                                                     //Arrêt des deux timers 
            timerMoteur.Stop();
            mcommande.dtension[0] = 24;                                                         //remise à 0 des tableaux dans CCommande
            mcommande.dtension[1] = 24;
            mcommande.dVitesse[0] = 0;
            mcommande.dVitesse[1] = 0;
            lbltps.Text = lblvitesse.Text = lbltension.Text = lblcourant.Text =lblconsigne.Text=lblcharge.Text= "0";   //remise à 0 des labels 
           
           
            i = 0;                                                                          // repartir de 0 sur l'abscisse du temps des courbes                  
        }

        private void checkDynamique_CheckedChanged(object sender, EventArgs e)
        {
            checkstatique.Checked = false;                                                  //décoche mode statique si le client coche dynamique
        }

        private void checkstatique_CheckedChanged(object sender, EventArgs e)
        {
            checkDynamique.Checked = false;
        }
    }
}



