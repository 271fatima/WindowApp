using Data_Excess_Layer;
using System.Data;

namespace Business_Logic_Layer
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();

        public DataTable GetStudents()
        {
            return dal.GetStudents();
        }
    }
}
