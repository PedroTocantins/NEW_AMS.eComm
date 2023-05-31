using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Entities
{
    public class Category
    {
        #region CONSTRUCTORS
        public Category()
        {

        }
        public Category(Guid id, string description)
        {
            Id = id;
            Description = description;
        }
        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}