using System;
using System.Collections.Generic;
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

        public void Replace(XmlNodeList node)
        {
            foreach (XmlElement element in node)
            {
                XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                while (currNode != null){              // on parcourt les noeuds
                    if (currNode.Name == "type") {
                        if (currNode.InnerText == "Cooking") {
                            currNode.InnerText = "Cuisine";
                        }
                        else if (currNode.InnerText == "Fish") {
                            currNode.InnerText = "Poisson";
                        }
                    }
                    currNode = currNode.NextSibling;    // On passe au noeud d'après
                }
            }
        }

        public void ReplaceScythe(XmlNodeList node)
        {
            foreach (XmlElement element in node)
            {
                XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                while (currNode != null)
                {              // on parcourt les noeuds
                    if ((currNode.Name == "Name")||(currNode.Name == "name"))
                    {
                        if (currNode.InnerText == "Scythe")
                        {
                            currNode.InnerText = "Faux";
                        }
                    }
                    currNode = currNode.NextSibling;    // On passe au noeud d'après
                }
            }
        }

        public void Remplace(XmlNodeList node, string stringLoc, string stringSrc, string stringDst)
        {
            foreach (XmlElement element in node)
            {
                XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                while (currNode != null){              // on parcourt les noeuds
                    if (currNode.Name == stringLoc){
                        if (currNode.InnerText == stringSrc){
                            currNode.InnerText = stringDst;
                        }
                    }
                    currNode = currNode.NextSibling;    // On passe au noeud d'après
                }
            }
        }

        public void Remplace2(XmlNodeList node, string stringSrc, string stringDst)
        {
            foreach (XmlElement element in node)
            {
                XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                while (currNode != null)
                {              // on parcourt les noeuds
                    if (currNode.InnerText == stringSrc)
                    {
                        currNode.InnerText = stringDst;
                    }
                    currNode = currNode.NextSibling;    // On passe au noeud d'après
                }
            }
        }

        public void Remplace3(XmlNodeList node)
        {
            for (int i = 0; i < mData.table.GetLength(0); i++)
            {
                foreach (XmlElement element in node)
                {
                    XmlNode currNode = element.FirstChild;          // Initialisation au premier noeud trouvé

                    while (currNode != null)
                    {              // on parcourt les noeuds
                        if (currNode.InnerText == mData.table[i, 0])
                        {
                            currNode.InnerText = mData.table[i, 1];
                        }
                        currNode = currNode.NextSibling;    // On passe au noeud d'après
                    }
                }
            }
        }
    }
}
