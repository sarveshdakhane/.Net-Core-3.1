using System;
using System.Collections.Generic;

#nullable disable

namespace DotNet_Core_with_Entity_Framework_Core_With_MySql.DBModels
{
    public partial class Employee
    {
        public int Idemployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
    }
}
