﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pidev.web.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
          this IEnumerable<string> genres)
        {
            return
                genres.OrderBy(genre => genre)
                      .Select(genre =>
                          new SelectListItem
                          {

                              Text = genre,
                              Value = genre
                          });
        }
    }
}

namespace Pidev.web.Helpers
{
    class CssRewriteUrlTransformAbsolute
    {
        public CssRewriteUrlTransformAbsolute()
        {
        }
    }
}