using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_GiocoMacchineBGW
{
    public partial class Form1 : Form
    {
        //variabili global
        BackgroundWorker bgw1, bgw2;
        bool vittoria = false;
        int v1, v2, ngiri,ntrag1, ntrag2, ntrag;
        bool ripeti = false;

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
           //faccio ripartire tutto
            vittoria = false;
            v1 =0;
            v2 = 0;
            ngiri = 0;
            ntrag = 0;
            ntrag1 = 0;
            ntrag2 = 0;
            ripeti = false;
            btn_start.Enabled = true;
            btn_start.Visible = true;
            btn_Restart.Visible = false;
            pct_car1.Location = new Point(12, 23);
            pct_car2.Location = new Point(12, 104);
            txt_ngiri.Text = "N.Giri:" + "";
            btn_quit.Enabled = true;
        }

        
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            //disabilito lo start e lo rendo invisibile
            btn_start.Enabled = false;
            btn_start.Visible = false;
            btn_quit.Enabled = false;

            //estraggo il numero di giri
            if (ripeti == false)
            {
                //numero random per i giri
                 Random rnd = new Random();
                 ngiri = rnd.Next(1, 11);
                 txt_ngiri.Text = "N.Giri:"+ngiri.ToString();

                //assegno alle variabili "check" il numero di giri da fare                
                ntrag = ngiri;
                ntrag1 = ngiri;
                ntrag2 = ngiri;
                ripeti = true;
            }

            //creo un backgroundworker per la macchina1
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            //creo un backgroundworker per la macchina2
            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            //avvio i backgroundworker
            bgw1.RunWorkerAsync();
            bgw2.RunWorkerAsync();

        }
       
        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //faccio muovere la macchina1 e la macchina2          
            pct_car1.Left = pct_car1.Left + v1;
            pct_car2.Left = pct_car2.Left + v2;

            //ciclo per far fare tutti i giri
            for (int i = 0; i <= ngiri; i++)
            {
                if (vittoria == false)
                {
                    //controllo se il check sui giri fatti è 0, se si dichiaro chi ha vinto
                    if (ntrag1 == 0)
                    {
                        vittoria = true;
                        MessageBox.Show("Macchina 1 ha Vinto");
                        btn_Restart.Visible = true;
                        btn_quit.Enabled = true;                        
                    }
                    if (ntrag2 == 0)
                    {
                        vittoria = true;
                        MessageBox.Show("Macchina 2 ha Vinto");
                        btn_Restart.Visible = true;
                        btn_quit.Enabled = true;                       
                    }

                    //finché i giri sono diversi da 0 faccio andare le macchine avanti
                    if (ntrag !=0)
                    {
                        if (pct_car1.Bounds.IntersectsWith(pct_traguardo.Bounds))
                        {
                            ntrag1--;
                            pct_car1.Location = new Point(12, 23);
                        }
                        if (pct_car2.Bounds.IntersectsWith(pct_traguardo.Bounds))
                        {
                            ntrag2--;
                            pct_car2.Location = new Point(12, 104);
                        }
                    }                    
                }

            }
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            while (vittoria != true)
            {
                //fino a quando la booleana non è true estraggo numeri random che assegno a due variabili per far muovere di n le macchine
                Random rnd = new Random();
                Thread.Sleep(100);
                v1 = rnd.Next(1, 11);
                v2 = rnd.Next(1, 11);

                //passo grazie alla ReportProgress le due velocità random
                bgw.ReportProgress(v1, v2);
            }            
        }
    }
}
