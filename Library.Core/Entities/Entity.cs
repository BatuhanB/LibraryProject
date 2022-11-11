using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Core.Entities
{
    public abstract class Entity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Entity()
        {
            Id = new Guid();
        }
    }
}
