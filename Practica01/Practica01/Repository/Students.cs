using Practica01.Data;
using Practica01.Services;

namespace Practica01.Repository
{
    public class Students: IEstudents
    {
        private AplicationDBContext app;

        public Students(AplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudent(Models.Estudiantes es)
        {
            app.Estudiantes.Add(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteStudent(Models.Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();

            // throw new NotImplementedException();
        }

        public List<Models.Estudiantes> GetAll()
        {
           return app.Estudiantes.ToList();
            return new List<Models.Estudiantes>();
            //throw new NotImplementedException();
        }

        public void UpdateStudent(Models.Estudiantes es)
        {
            app.Estudiantes.Update(es);
            app.SaveChanges();
            // throw new NotImplementedException();
        }
    }
}
