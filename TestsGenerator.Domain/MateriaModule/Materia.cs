using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.MateriaModule
{
    public class Materia : BaseEntity<Materia>
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public Bimester? Bimester { get; set; }
        public Discipline Discipline { get; set; }

        public override void Update(Materia t)
        {
            Name = t.Name;
            Grade = t.Grade;
            Bimester = t.Bimester;
            Discipline = t.Discipline;
        }
    }
}