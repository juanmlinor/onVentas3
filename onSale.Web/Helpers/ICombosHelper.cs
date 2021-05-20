﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace onSale.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();

    }
}
