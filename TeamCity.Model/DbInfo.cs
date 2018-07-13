namespace TeamCity.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DbInfo")]
    public partial class DbInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Version { get; set; }
    }
}
