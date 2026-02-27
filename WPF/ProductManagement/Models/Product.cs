using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class Product
{
    public string PId { get; set; } = null!;

    public string PName { get; set; } = null!;

    public string? Unit { get; set; }

    public int? Qty { get; set; }

    public int? Price { get; set; }

    public string? CatId { get; set; }

    public virtual Category? Cat { get; set; }
}
