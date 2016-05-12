using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
                /*case "Český":
                    //erdnusse = mData.tablecz;
                    break;
                case "Deutsch":
                    //erdnusse = mData.tablede;
                    break;
                case "Português":
                    //erdnusse = mData.tablept;
                    break;*/
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

        public bool RemplaceDraivin(XDocument Name, XDocument Game, string alaqueuleuleu, Button toast)
        {
            string[,] erdnusse;
            toast.Text = "0%";
            switch (alaqueuleuleu)
            {
                case "Français":
                    erdnusse = mData.tablefr;
                    break;
                case "Español":
                    erdnusse = mData.tablesp;
                    break;
                /*case "Český":
                    //erdnusse = mData.tablecz;
                    break;
                case "Deutsch":
                    //erdnusse = mData.tablede;
                    break;
                case "Português":
                    //erdnusse = mData.tablept;
                    break;*/
                default:
                    erdnusse = mData.tablefr;
                    break;
            }

            var leaves =
                from e in Name.Descendants()
                where !e.Elements().Any()
                select e;

            for (int i = 0; i < erdnusse.GetLength(0); i++)
            {
                foreach (var leaf in leaves)
                {
                    var value = leaf.Value;
                    if (value == erdnusse[i, 0])
                    {
                        value = erdnusse[i, 1];
                        // Esthétique
                        if ((i/10) <= 100)
                            toast.Text = "(1/2) " + (i / 10).ToString() + "%";
                        else
                            toast.Text = "...";
                    }

                    leaf.Value = value;
                }
            }

            toast.Text = "...";
            var leavess =
                from e in Game.Descendants()
                where !e.Elements().Any()
                select e;

            for (int i = 0; i < erdnusse.GetLength(0); i++)
            {
                foreach (var leaff in leavess)
                {
                    var value = leaff.Value;
                    if (value == erdnusse[i, 0])
                    {
                        value = erdnusse[i, 1];
                        // Esthétique
                        if ((i / 10) <= 100)
                            toast.Text = "(2/2) " + (i / 10).ToString() + "%";
                        else
                            toast.Text = "...";
                    }

                    leaff.Value = value;
                }
            }

            return true;
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
