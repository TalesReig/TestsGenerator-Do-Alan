using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.MateriaModule
{
    public class MateriaRepository : BaseRepository<Materia>
    {
        public MateriaRepository(DataContext dataContext) : base(dataContext) 
        {
            if (dataContext.Materias.Count > 0)
            {
                this.counter = dataContext.Materias.Max(x => x.Id);
            }
        }

        public override List<Materia> GetRegisters()
        {
            return _dataContext.Materias;
        }

        public override AbstractValidator<Materia> GetValidator()
        {
            return new MateriaValidator();
        }

        public override ValidationResult Insert(Materia t)
        {
            List<Materia> registros = GetRegisters();
            bool nameJaCadastrado = registros.Any(x => x.Name.ToUpper() == t.Name.ToUpper());

            if (nameJaCadastrado)
            {
                bool gradeJaCadastrado = registros.Any(x => x.Grade.ToUpper() == t.Grade.ToUpper());
                bool bimesterJaCadastrado = registros.Any(x => x.Bimester == t.Bimester);

                if (gradeJaCadastrado && bimesterJaCadastrado)
                {
                    ValidationResult validadorNome = new ValidationResult();

                    validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, matéria já cadastrada."));

                    return validadorNome;
                }
            }

            return base.Insert(t);
        }

        public override ValidationResult Update(Materia t)
        {
            List<Materia> registros = GetRegisters();
            bool nameJaCadastrado = registros.Any(x => x.Name.ToUpper() == t.Name.ToUpper());

            if (nameJaCadastrado)
            {
                bool gradeJaCadastrado = registros.Any(x => x.Grade.ToUpper() == t.Grade.ToUpper());
                bool bimesterJaCadastrado = registros.Any(x => x.Bimester == t.Bimester);

                if (gradeJaCadastrado && bimesterJaCadastrado)
                {
                    ValidationResult validadorNome = new ValidationResult();

                    validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, matéria já cadastrada."));

                    return validadorNome;
                }
            }

            return base.Update(t);
        }
    }
}