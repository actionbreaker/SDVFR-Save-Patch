using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationFixer
{
    class Data
    {
        public string[,] table = new string[,]
        {
            // TRADUCTIONS
            {"Cooking", "Cuisine"},
            {"Fish",    "Poisson"},
            {"Scythe",  "Faux"},
            {"Weeds",  "Herbes"},
            {"Stone",  "Pierre"},
            {"Pickaxe",  "Pioche"},
            {"Chest",  "Coffre"},
        };

        public Data()
        {

        }
    }
}