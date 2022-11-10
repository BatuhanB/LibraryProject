using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Model.BaseEntity
{
    public abstract class IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public IEntity()
        {
            Id = new Guid();
        }
    }
}
