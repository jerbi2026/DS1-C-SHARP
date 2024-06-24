using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string clmt;
            string chemin = "C:\\Users\\jerbi\\Documents\\1ère année Business Intelligence IHEC Carthage\\semestre 2\\programmation evementielle C#\\DS 1 2021\\DS1\\DS1\\bulletin.csv";
            
            bool ok = File.Exists(chemin);
            if(ok==true)
            {
                try
                {
                    Stream fs = File.Open(chemin, FileMode.Open,FileAccess.Read,FileShare.Read);
                    using (StreamReader sr = new StreamReader(chemin))
                    {
                        clmt = sr.ReadLine();
                        while (clmt != null )
                        {
                            bulletin.Items.Add(clmt);
                            clmt = sr.ReadLine();
                        }
                    }
                    fs.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("le fichier bulletin est introuvable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                

            }
           
        }

        private void Affiche_btn_Click(object sender, EventArgs e)
        {
            bulletin.Items.Clear();
            string fichier;
            bool okey = false;
            string chemin = "C:\\Users\\jerbi\\Documents\\1ère année Business Intelligence IHEC Carthage\\semestre 2\\programmation evementielle C#\\DS 1 2021\\DS1\\DS1\\bulletin.csv";
            FileStream fs = File.Open(chemin, FileMode.Open,FileAccess.Read,FileShare.Read);
            try
            {
                using (StreamReader sr = new StreamReader(fs))
                {


                    while ((fichier = sr.ReadLine()) != null)
                    {
                        if (fichier.Contains(txtregion.Text))
                        {
                            okey = true;
                            fichier = sr.ReadLine();
                            bulletin.Items.Add(fichier);
                            break;
                        }
                        fichier = sr.ReadLine();
                    }
                    fs.Close();
                }
                if (okey == false)
                {
                    MessageBox.Show("mot introuvable", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void enregistrer_btn_Click(object sender, EventArgs e)
        {
            if(txtregion.Text!="" && temp_max.Text!="" && temp_min.Text!="" && prec_max.Text!="" && prec_min.Text!="" )
            {
                try
                {
                    string chemin = "C:\\Users\\jerbi\\Documents\\1ère année Business Intelligence IHEC Carthage\\semestre 2\\programmation evementielle C#\\DS 1 2021\\DS1\\DS1\\bulletin.csv";
                    FileStream fs = File.Open(chemin, FileMode.Append);
                    using (StreamWriter sr = new StreamWriter(fs))
                    {
                        string aux = "\n"+txtregion.Text + "\n" + temp_max.Text + "\t" + dateTimePicker1.Text + "\n" + temp_min.Text + "\t" + dateTimePicker2.Text + "\n" + prec_max.Text + "\t" + dateTimePicker3.Text + "\n" + prec_min.Text + "\t" + dateTimePicker4.Text + "\n" + "_________________________\n";
                        sr.Write(aux);
                    }
                    fs.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("veuillez remplir tous les donnees", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir une chaine de caractere", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void temp_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir un entier", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void temp_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir un entier", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prec_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir un entier", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prec_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir un entier", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
