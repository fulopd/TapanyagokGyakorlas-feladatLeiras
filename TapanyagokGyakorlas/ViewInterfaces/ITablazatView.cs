using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapanyagokGyakorlas.Models;

namespace TapanyagokGyakorlas.ViewInterfaces
{
    interface ITablazatView
    {
        BindingList<tapanyag> BindingList { get; set; }
        int page { get; set; }
        int itemPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { set; }
    }
}
