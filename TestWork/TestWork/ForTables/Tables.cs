using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables
{
    public class Police
    {
        [Key]
        public int PersonID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string DateOfBirth { get; set; }
        public string CrimeAction { get; set; }

       
    }
    public class Workman
    {
        [Key]
        public int PersonID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string DateOfBirth { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Expirience { get; set; }
        public string DateOfStart { get; set; }
    }

    public class Temp
    {
        [Key]
        public string NameV { get; set; }
        public string Value { get; set; }
    }
    public class TablesContext : DbContext
    {
        public DbSet<Temp> Temp { get; set; }
        public DbSet<Police> Police { get; set; }
        public DbSet<Workman> Workman { get; set; }
    }
}
