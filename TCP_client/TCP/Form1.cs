/*------------------------------------------------------------------------
 TP Four IUT Annecy Génie Electrique et Informatique Industrielle             mars 2021
//------------------------------------------------------------------------
 But: SIMULATEUR DE RÉGULATION DE VITESSE DE MOTEUR A COURANT CONTINU EN C#

 Ce programme:

 Rprésente une fenêtre client pouvant se connecter au serveur extérieur(voir projet) par liaison TCP/IP, pour contrôler le moteur à distance.

 Elle comporte: -un espace de dialogue(envoie de messages)
                -des champs de saisie vitesse et charge pour écriture sur moteur
                - des boutons pour lecture des données du moteur
                -un choix du mode statique ou dynamique
  

//------------------------------------------------------------------------
 Licence LGPL: Ce code source développé dans un but purement éducatif
               peut être utilisé et recopié librement.
//------------------------------------------------------------------------


*/





using SimpleTcp;                            //utilisation de la bibliothèque SimpleTcp pour liaison TCP/IP
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {

        SimpleTcpClient client;  //initialisation d 'un client
        string smode;
        string sV;
        string sT;

        public Form1()
        {

            InitializeComponent();
        }

       
    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //--------------------------------------------------------------
        // METHODE DECONNECTION 
        //--------------------------------------------------------------
        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)      //on reçoit la source et les données d'évènement
        {
            this.Invoke((MethodInvoker)delegate                                         //si la deconnection est sur le thread principal
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";                 //ecriture:Server disconnected
            });
        }

        //--------------------------------------------------------------
        // METHODE DATA RECU
        //--------------------------------------------------------------

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)                
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";     //on écrit le message reçu du serveur  
            });
            
        }
        //--------------------------------------------------------------
        // METHODE CONNECTION
        //--------------------------------------------------------------


        private void Events_Connected(object sender, ClientConnectedEventArgs e)            //évènement client connecté
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";                  //connectés

            });
        }
        //--------------------------------------------------------------
        // METHODE ENVOIE DU MESSAGE
        //--------------------------------------------------------------



        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)                                 //si le client est connecté
            {
               
           
                if (!string.IsNullOrEmpty(txtMessage.Text))                                         //si il y a quelque chose d'écrit
                {
                    client.Send("M"+txtMessage.Text);                                                   //on envoie le message
                    txtInfo.Text += $"Me:{txtMessage.Text}{Environment.NewLine}";                   
                    txtMessage.Text = string.Empty;

                }



                if ((checkdynamique.Checked && checkstatique.Checked) || ((checkdynamique.Checked == false) && (checkstatique.Checked == false)))          //gère l'erreur sur les checkbox
                {
                    MessageBox.Show("vous devez choisir entre un des deux modes! ");
                }

                else if((!string.IsNullOrEmpty(txtspeed.Text))&&(!string.IsNullOrEmpty(txttorque.Text)))
                {

                    
                        if (checkdynamique.Checked)                         //si le client veut en dynamique
                        {
                       smode = "dynamic";
                        


                        }
                        if (checkstatique.Checked)                          //si le client veut en statique
                    {
                        smode = "static";
                          


                    }


                    
               
                        try                                                      // vérifie que la vitesse est un entier
                        {
                            double x = Convert.ToDouble(txtspeed.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Vous devez entrer un entier");
                        }
                                                       //envoie vitesse en rajoutant S devant le string pour reconnaissance par le serveur
                    sV = "S" + txtspeed.Text;
                    txtInfo.Text += $"Me:speed={txtspeed.Text}{Environment.NewLine}";
                        txtspeed.Text = string.Empty;




                                                    //envoie couple de charge en rajoutant T devant le string pour reconnaissance par le serveur  
                    sT = "T" + txttorque.Text;
                    txtInfo.Text += $"Me:torque={ txttorque.Text}{Environment.NewLine}";            //écriture du couple de charge dans boîte de dialogue
                        txttorque.Text = string.Empty;

                    
                    client.Send(smode + sV + sT);                   //envoie de la chaîne sous forme mode+S+vitesse+T+vitesse
                }
                else                                                                   //si il manque une donnée
                {
                    MessageBox.Show("vous devez entrer une vitesse et un couple de charge ");
                }

                
            }
        }




        //--------------------------------------------------------------
        // METHODE  BP CONNECTION
        //--------------------------------------------------------------

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new SimpleTcpClient(txtIP.Text);                   //créer un nouveau client avec addresse IP rentrée
                client.Events.Connected += Events_Connected;                //appel des évènements
                client.Events.DataReceived += Events_DataReceived;
                client.Events.Disconnected += Events_Disconnected;

                                                  
                client.Connect();                                           //connection du client au serveur
                btnSend.Enabled = true;                                    //autoriser l'envoie de données
                btnConnect.Enabled = true;                                      //autoriser la reconnection si perdue
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                    
        }

        //--------------------------------------------------------------
        // METHODE  BP DEMANDE DE VITESSE
        //--------------------------------------------------------------

        private void Askspeed_Click(object sender, EventArgs e)
        {
            client.Send("speed");                                           //envoie "speed" pour recevoir la vitesse
        }

        //--------------------------------------------------------------
        // METHODE   BP DEMANDE DE TENSION
        //--------------------------------------------------------------
        private void Askvoltage_Click(object sender, EventArgs e)
        {
            client.Send("voltage");                                         //envoie "voltage" pour recevoir la tension
        }

        //--------------------------------------------------------------
        // METHODE   BP DEMANDE DE courant
        //--------------------------------------------------------------

        private void Askcurrent_Click(object sender, EventArgs e)
        {
            client.Send("current");                                            //envoie "current" pour recevoir le courant
        }

        private void checkdynamique_CheckedChanged(object sender, EventArgs e)              //évènement checkbox dynamique appuyé
        {
            checkdynamique.Checked = true;                                                  //on coche dynamique et on décoche statique
            checkstatique.Checked = false;
        }

        private void checkstatique_CheckedChanged(object sender, EventArgs e)               //évènement checkbox satique appuyé
        {
            checkstatique.Checked = true;                                                       //on coche statique et on décoche dynamique
            checkdynamique.Checked = false;
        }
    }
}
