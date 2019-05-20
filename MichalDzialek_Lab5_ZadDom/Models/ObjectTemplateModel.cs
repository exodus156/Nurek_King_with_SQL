using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MichalDzialek_Lab5_ZadDom.Models
{
    public class ObjectTemplateModel
    {
        /// <summary>
        /// Model dla przedmiotów
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        public ObjectTemplateModel(string name, string type, string description, decimal price, string photo, string uniqueid)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Price = price;
            this.Photo = photo;
            this.UniqueID = uniqueid;
        }

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



    }
}
