using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repositories.InsertClass(1);
           // Repositories.Insert_Address("39A", "Alwarthoppu", "Palakarai", "Trichy", "Tamil Nadu", "620008", "9999988888", "rahamath@1234");
           // Repositories.InsertStaffDetails("Rahu",1,"Bsc","2024","5");
           // Repositories.InsertClassDetails(1, "A", 1);
           // Repositories.InsertStudDetails(1, "A", "2024", "Nisha", "22/10/2004", "o+", "1");
           // Repositories.InsertSubjectDetails(1, "Tamil");
           // Repositories.InsertSubAndStaffRealation(1, 1, "A", "2024", 1);
            //Repositories.InsertExamType("Quaterly");
            Repositories.InsertStudentMarks(1, 1, "A", "2024", 1, 1, "Nisha",97);
        }
    }
}
