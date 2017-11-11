namespace Hosting_images.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string URL { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string FormatType { get; set; }

        [Required]
        [StringLength(45)]
        public string Value { get; set; }

        [Required]
        [StringLength(50)]
        public string LocalReference { get; set; }
    }
}
