using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();



            /*--------------------------------------------------------------
              associations entre App,CCommande et Server
            --------------------------------------------------------------
            */
            CCommande Commande;
            App app;
            Form1 form1;

            app = new App();
            Commande = new CCommande();
            form1 = new Form1();
            app.mcommande = Commande;
            Commande.mapp = app;

        
            Commande.mServer = form1;
            form1.mcommande = Commande;

            app.mServer = form1;
            form1.mapp = app;
            /*--------------------------------------------------------------
              lancement des deux fenêtres
            --------------------------------------------------------------
            */

            app.Show();
           
            Application.Run(form1);
            
        }
    }
}
