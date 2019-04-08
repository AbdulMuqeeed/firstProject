namespace CRUDwithMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        public int? salary { get; set; }
    }
}
