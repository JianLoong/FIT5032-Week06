namespace Week06.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        public int ImageId { get; set; }

        
        [StringLength(50)]
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        [DisplayName("Book Name")]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
