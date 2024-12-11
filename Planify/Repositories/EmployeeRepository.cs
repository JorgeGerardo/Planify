using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {

        //TODO: 2
        //Quiza deberías hacer un segundo repositorio que si obtenga los proyectos y las tareas
        //O simplemente un controlador que te devuelva todas las tareas de un usuario
        //______________________________________________________________________________________
        //[Correción]: Debería ser un controlador que utilice ambos repositorios.

        //TODO: 3 O agrega algun endpoint en Employee que devuelva el empleado con los projects y projectTasks
        private string[] NavProperties = [nameof(Employee.Person), nameof(Employee.User), nameof(Employee.Departments)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}
