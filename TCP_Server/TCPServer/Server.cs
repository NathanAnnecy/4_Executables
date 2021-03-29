/*------------------------------------------------------------------------

Server s'occupe de la liaison avec le client en TCP/IP
-échange de données
-autorise la connexion
------------------------------------------------------------------------
*/




using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;    
using ZedGraph;

namespace TCPServer
{
    public partial class Form1 : Form
    {
      
         SimpleTcpServer server;                //creation server
        public CCommande mcommande;
        public App mapp;
        public double dS;                           //vitesse et couple 
        public double dT;
        public string client;                   //IP du client
        bool bOneClient=false;                  // si un client est déjà connecté
        int iPlaceS;
        int iPlaceT;
        string sS;
        string sT;





        public Form1()
        {
            InitializeComponent();
        }
       
     
    
       

        private void BtnStart_Click(object sender, EventArgs e)                         // à l'appui du BP Start
        {
            server = new SimpleTcpServer(txtIP.Text);                                       // création du serveur
            server.Events.ClientConnected += Events_ClientConnected;                        //initialise les évènements possibles
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            server.Start();                                                               //lance le serveur                       
           
            
            txtInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = false;                                                       // BP sart devient grisé
            btnSend.Enabled = true;                                                         //le serveur peut envoyer
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        { 
           btnSend.Enabled = false;
            
           

        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
           

            this.Invoke((MethodInvoker)delegate                                         // délègue l'action au thread principal
             {
                 string schaine = Encoding.UTF8.GetString(e.Data);                       //on récupère la donnée provenant du client           
                
                

                
                 if (server.IsListening)                                                    // si le serveur écoute
                 {
                    
                    

                     if (schaine == "speed")                                                                // si le client demande la vitesse
                         {
                            
                             server.Send( client ,"speed: "+ mcommande.svitesse);                               // envoie de la vitesse
                             txtInfo.Text += $"Server:{mcommande.svitesse}{Environment.NewLine}";


                         }

                        else if (schaine == "voltage")                                                      // si le client demande la tension
                     {

                             server.Send(client, "voltage: " + mcommande.sTension);                         // // envoie de la tension
                         txtInfo.Text += $"Server:{mcommande.sTension}{Environment.NewLine}";
                     

                         }

                        else if (schaine == "current")                              // si le client demande le courant
                     {

                             server.Send(client,"current: "+ mcommande.scourant);                           // envoie du courant
                         txtInfo.Text += $"Server:{mcommande.scourant}{Environment.NewLine}";


                         }
                     else if (schaine.Substring(0, 1) == "M")
                     {
                         txtInfo.Text += $"{e.IpPort} :{schaine}{Environment.NewLine}";                 //sinon ca veut dire que le client écrit juste un message, on l'affiche donc
                     }

                     else                                                                    // si il y a qq chose à envoyer
                     {

                         iPlaceT = schaine.LastIndexOf("T");                                //on cherche la place de S et T dans la chaîne de caractère
                         iPlaceS = schaine.LastIndexOf("S");

                         sT = schaine.Substring(iPlaceT + 1);                                      // grâce à S et T on sait où sont les valeurs
                         sS = schaine.Substring(iPlaceS + 1, iPlaceT - iPlaceS - 1);


                         if (schaine.Substring(0, 1) == "s")                                          //si le 1er caractère est s(statique)=>mode statique
                         {
                             mapp.checkDynamique.Checked = false;
                             mapp.checkstatique.Checked = true;                                  // ensuite utilisés dans Commande()
                             mapp.Kp = 0.05;                                                    // coefficients déjà calculés
                             mapp.Ki = 0.01;
                             mapp.Kd = 0.001;
                         }
                         if (schaine.Substring(0, 1) == "d")                                              // si il reçoit "dynamique": le client veut être en mode dynamique
                         {
                             mapp.checkstatique.Checked = false;                                // ensuite utilisés dans Commande()
                             mapp.checkDynamique.Checked = true;
                             mapp.Kp = 52929;                                                   // coefficients déjà calculés
                             mapp.Kd = 130421;
                             mapp.Ki = 176429;

                         }



                              mapp.bchoix = false;                                                     // pour dans App
                              mapp.Reset();                                                          // le client fait une demande=> on reset le graphe et les valeurs précèdentes
                              mapp.Graphique();                                                      // on re-appelle le grpahique
                              mapp.lblconsigne.Text = sS;                                        //on affiche la consigne et la charge
                              mapp.lblcharge.Text = sT;
                              mapp.timer10.Start();                                                      //on re-appelle les timer
                              mapp.timerMoteur.Start();


                     }









                    



                    



                 }

                


             });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)                //évènement client se déconnecte
        {
            this.Invoke((MethodInvoker)delegate
            {
                if(bOneClient == true)                                                  //si le 1er client se déconnecte=> il n'y a plus de client=> on autorise la connexion
                {
                    bOneClient = false;
                }
                txtInfo.Text += $"{client} disconnected.{Environment.NewLine}";
                lstClientIP.Items.Remove(e.IpPort);
            });

          
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)                      //évènement client se connecte
        {

            if (bOneClient == true)                                                             // si un client est déjà connecté, on le déconnecte car on ne veut qu'un seul client
            {
                server.DisconnectClient(e.IpPort);
            }
            else
            {

                this.Invoke((MethodInvoker)delegate                                             //sinon on passe sur le thread principal
                {
                    client = e.IpPort;                                                          //o récupère l'ip du client qu'on affiche
                    txtInfo.Text += $"{client} connected.{Environment.NewLine}";
                    lstClientIP.Items.Add(client);
                    client = e.IpPort;
                    bOneClient = true;                                                          //variable pour dire q'un client est connecté



                });

            }
        }

        private void BtnSend_Click(object sender, EventArgs e)                      // appui sur BP Send
        {
           
             
            if (server.IsListening)                   //si le serveur ecoute
            {
                if(!string.IsNullOrEmpty(txtMessage.Text))        // si il y a qq chose à envoyer
                {
                   server.Send(client,txtMessage.Text);              // on envoie le msg au client
                 
                    txtInfo.Text += $"Server:{txtMessage.Text}{Environment.NewLine}";       // on écrit le msg envoyé
                    txtMessage.Text = string.Empty;
                }
            }
        }
    }
}
