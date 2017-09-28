namespace Week06.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Images = new HashSet<Image>();
        }

        public int BookId { get; set; }

        [Required]
        [DisplayName("Title")]
        public string BookTitle { get; set; }

        // You should always put references like that so that you know where you found it before.
        // https://stackoverflow.com/questions/28114874/html-displayfor-dateformat-mm-dd-yyyy
        // The ApplyFormatInEdit mode formats it correct for the EditorFor field
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Published Date")]
        public DateTime BookPublishedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
    }
}
