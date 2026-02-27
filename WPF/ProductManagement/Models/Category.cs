using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class Category
{
    public string CatId { get; set; } = null!;

    public string CatName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
