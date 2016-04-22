using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TranslationFixer
{
    public partial class Form1 : Form
    {
        XmlDocument docGame;
        XmlDocument docName;

        Fonctions mOperation;

        private string pathfileGame;
        private string pathfileName;
        string pathDirectoryGame;
        string pathDirectoryName;
        string game;
        string name;

        bool done;

        public Form1()
        {
            InitializeComponent();
            done = false;
            mOperation = new Fonctions();
        }

        private void buttonLoadSaveGame_Click(object sender, EventArgs e)   // Charger SaveGameInfo
        {
            // Sélection du fichier
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathfileGame = openFileDialog1.FileName;                    // Chemin + Nom fichier
                pathDirectoryGame = Path.GetDirectoryName(pathfileGame);    // Chemin
                game = Path.GetFileNameWithoutExtension(pathfileGame);      // Nom fichier
            }

            try
            {
                // Chargement du fichier
                if (game=="SaveGameInfo")
                {
                    docGame = new XmlDocument();
                    docGame.Load(pathfileGame);
                    buttonLoadSaveGame.BackColor = Color.LimeGreen;
                    buttonLoadSaveGame.Text = game;
                }
                else
                {
                    buttonLoadSaveGame.BackColor = Color.Firebrick;
                    buttonLoadSaveGame.Text = "Mauvais fichier";
                }
            }
            catch
            {
                buttonLoadSaveGame.BackColor = Color.Firebrick;
                buttonLoadSaveGame.Text = "Erreur";
            }
        }

        private void buttonLoadSaveName_Click(object sender, EventArgs e)   // Charger Nom_56557
        {
            // Sélection du fichier
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathfileName = openFileDialog2.FileName;                    // Chemin + Nom fichier
                pathDirectoryName = Path.GetDirectoryName(pathfileName);    // Chemin
                name = Path.GetFileNameWithoutExtension(pathfileName);      // Nom fichier
            }

            try
            {
                // Chargement du fichier
                if (name == "SaveGameInfo")
                {
                    buttonLoadSaveName.BackColor = Color.Firebrick;
                    buttonLoadSaveName.Text = "Mauvais fichier";
                }
                else
                {
                    docName = new XmlDocument();
                    docName.Load(pathfileName);
                    buttonLoadSaveName.BackColor = Color.LimeGreen;
                    buttonLoadSaveName.Text = name;
                }
            }
            catch
            {
                buttonLoadSaveName.BackColor = Color.Firebrick;
                buttonLoadSaveName.Text = "Erreur";
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (done==false)
            {
                try
                {
                    // Backup
                    if (checkBoxBackup.Checked == true)
                    {
                        File.Copy(pathfileName, pathDirectoryName + "\\" + name + "BACKUP");
                        File.Copy(pathfileGame, pathDirectoryGame + "\\" + "SaveGameInfoBACKUP");
                    }

                    XmlNodeList[] nodeTab = new XmlNodeList[]
                    {
                        // Lieux où chercher (Name)
                        docName.SelectNodes("/SaveGame/locations/GameLocation/objects/item/value/Object/items/Item"),
                        docName.SelectNodes("/SaveGame/player/items/Item"),
                        docName.SelectNodes("/SaveGame/locations/GameLocation/buildings/Building/indoors/name"),
                        docName.SelectNodes("SaveGame/locations/GameLocation/buildings/Building/buildingType"),

                        // Lieux où chercher (Game)
                        docGame.SelectNodes("/Farmer/items/Item"),
                    };

                    // Remplacements
                    int chgts = 0;
                    for (int i = 0; i < nodeTab.GetLength(0); i++)
                    {
                        chgts = chgts + mOperation.Remplace3(nodeTab[i]);
                    }
                    
                    // Sauvegarde
                    docName.Save(pathfileName);
                    docGame.Save(pathfileGame);
                    buttonReplace.BackColor = Color.LimeGreen;
                    buttonReplace.Text = "Terminé";
                    labelChgts.Text = Convert.ToString(chgts) + " changements effectués";
                    done = true;
                }
                catch
                {
                    buttonReplace.Text = "Erreur";
                } 
            }
        }
    }
}
