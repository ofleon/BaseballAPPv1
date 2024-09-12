using BasebalApp.Service.Common;

namespace BasebalApp.Service.Entities;

public partial class Team : BaseEntity
{
    public string Name { get; set; } = null!;

    //public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
