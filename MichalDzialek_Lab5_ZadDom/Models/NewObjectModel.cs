using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MichalDzialek_Lab5_ZadDom.Models
{
    public class NewObjectModel
    {
        /// <summary>
        /// Nazwa
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Rodzaj sprzętu
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Opis sprzętu
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Zdjęcie
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public string UniqueID { get; set; }

        /// <summary>
        /// Typ zapytania
        /// </summary>
        public string RequestType { get; set; }
    }
}
