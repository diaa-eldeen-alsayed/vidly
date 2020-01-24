using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.viewModel
{
    public class randomCustmorViewModel
    {
        public List<Customers> customers { get; set; }
        public Movie movie { get; set; }
    }
}