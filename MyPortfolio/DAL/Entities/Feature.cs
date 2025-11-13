using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.DAL.Entities
{
    [Table("Features")]
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
