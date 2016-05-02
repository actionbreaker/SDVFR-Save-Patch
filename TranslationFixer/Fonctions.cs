using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TranslationFixer
{
    class Fonctions
    {
        Data mData;

        public Fonctions()
        {
            mData = new Data();
        }

        public void Remplace3(XmlNodeList node, string alaqueuleuleu)     // Traduction en anglais
        {
            string[,] erdnusse;

            switch (alaqueuleuleu)
            {
                case "Français":
                    erdnusse = mData.tablefr;
                    break;
                case "Español":
                    erdnusse = mData.tablesp;
                    break;
                default:
                    erdnusse = mData.tablefr;
                    break;
            }

            for (int i = 0; i < erdnusse.GetLength(0); i++)
            {
                foreach (XmlElement element in node)
                {
                    XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé
                    while (currNode != null)
                    {                       // on parcourt les noeuds
                        if (currNode.InnerText == erdnusse[i, 0])
                        {
                            currNode.InnerText = erdnusse[i, 1];
                        }
                        currNode = currNode.NextSibling;            // On passe au noeud d'après
                    }
                }
            }
        }

        public void RemplaceEN(XmlNodeList node)    // Traduction en anglais
        {

            foreach (XmlElement element in node)
            {
                XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                while (currNode != null)
                {
                    do
                    {
                        currNode = currNode.FirstChild;
                    } while (currNode.HasChildNodes);

                    while (currNode != null)
                    {                       // on parcourt les noeuds
                        currNode.InnerText = RemoveDiacritics(currNode.InnerText);
                        currNode.InnerText = "CACA";
                        currNode = currNode.NextSibling;            // On passe au noeud d'après
                    }
                    currNode = currNode.NextSibling;            // On passe au noeud d'après
                }
            }

        }

        static string RemoveDiacritics(string stIn)     // Accents
        {
            string stFormD = stIn.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }

            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }
    }
}
