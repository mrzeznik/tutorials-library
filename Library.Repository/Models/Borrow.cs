using System;

namespace Library.Repository
{
    /// <summary>Representation of single book borrow.</summary>
    public class Borrow
    {
        public string User { get; set; }
        public string Book { get; set; }
        public DateTime? Since { get; set; }
        public DateTime? Till { get; set; }
    }
}