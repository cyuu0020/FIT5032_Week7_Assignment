namespace W7_Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hall")]
    public partial class Hall
    {
        public int Id { get; set; }

        [Required]
        public string Hall_No { get; set; }

        [Required]
        public string Hall_Name { get; set; }

        [Required]
        public string Fee { get; set; }

        [Required]
        public string Open_Hour { get; set; }

        [Required]
        public string Capacity { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
