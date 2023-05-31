using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Entities
{


    public class ProductColor
    {
        #region CONSTRUCTORS
        public ProductColor()
        {

        }
        public ProductColor(Guid id, string description, bool isActive)
        {
            Id = id;
            Description = description;
            IsActive = isActive;
        }
        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
