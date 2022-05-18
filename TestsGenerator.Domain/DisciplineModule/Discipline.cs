using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.DisciplineModule
{
    public class Discipline : BaseEntity<Discipline>
    {
        public string Name { get; set; }

        public override void Update(Discipline t)
        {
            Name = t.Name;
        }

        public Discipline? Clone()
        {
            return MemberwiseClone() as Discipline;
        }
    }
}