using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

        public void Remplace3(XmlNodeList node)     // Traduction en anglais
        {
            for (int i = 0; i < mData.table.GetLength(0); i++)
            {
                foreach (XmlElement element in node)
                {
                    XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé
                    while (currNode != null)
                    {                       // on parcourt les noeuds
                        if (currNode.InnerText == mData.table[i, 0])
                        {
                            currNode.InnerText = mData.table[i, 1];
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

        static string RemoveDiacritics(string stIn)
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
