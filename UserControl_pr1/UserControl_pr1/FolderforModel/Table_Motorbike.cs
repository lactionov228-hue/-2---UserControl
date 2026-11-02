namespace UserControl_pr1.FolderforModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Table_Motorbike")]
    public partial class Table_Motorbike
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Model { get; set; }

        public int Price { get; set; }

        public int Horsepower { get; set; }

        public int Mileage { get; set; }

        [Required]
        [StringLength(50)]
        public string Picture { get; set; }
    }
}
