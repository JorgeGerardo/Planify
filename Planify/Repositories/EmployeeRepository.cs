using Planify.Data;
using Planify.Models;

namespace Planify.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        //TODO: Hazle esto a todos los repositorios, deben apuntar a su variable
        // propiedad de navegación, no al modelo al que pertenece su propiedad de nav

        //TODO: 2
        //Quiza deberías hacer un segundo repositorio que si obtenga los proyectos y las tareas
        //O simplemente un controlador que te devuelva todas las tareas de un usuario

        //TODO: 3 O agrega algun endpoint en Employee que devuelva el empleado con los projects y projectTasks
        private string[] NavProperties = [nameof(Employee.Person), nameof(Employee.User)];
        public override string[] _NavigationProperties { get => NavProperties; }

        public EmployeeRepository(ProjectContext context) : base(context) { }
    }
}
