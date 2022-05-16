using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Research_Gate.Models;

namespace Research_Gate.ViewModels
{
    public class AuthorPaperViewModel
    {
        public Author Author { get; set; }
        public Paper Paper { get; set; }
    }
}