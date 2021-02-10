using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.APIAsyncRestFul.Manager.Entity.Entities
{
    public class Department : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        [Required]
        public int Level { get; set; }
        /// <summary>
        /// Gets or sets the bedrooms.
        /// </summary>
        /// <value>
        /// The bedrooms.
        /// </value>
        [Required]
        public int Bedrooms { get; set; }
    }
}
