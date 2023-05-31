using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Entities
{
    public class Product
    {
        #region CONSTRUCTORS
        /// <summary>
        /// My first constructor at this class
        /// <Author>Tocantins, Pedro</Author>
        /// </summary>
        public Product()
        {

        }

        public Product(Guid id, string description, decimal price,bool isActive, Guid colorId, Guid categoryId)
        {
            Id = id;
            Description = description;
            Price = price;
            ColorId = colorId;
            CategorieId = categoryId;
            IsActive = isActive;
        }
        #endregion

        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public Guid ColorId { get; set; }
        public Guid CategorieId { get; set; }

    }
}
