using BasebalApp.Service.Common;

namespace BasebalApp.Service.Entities;

public partial class Player : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int? TeamId { get; set; }


    //public virtual Team? Team { get; set; }
}
