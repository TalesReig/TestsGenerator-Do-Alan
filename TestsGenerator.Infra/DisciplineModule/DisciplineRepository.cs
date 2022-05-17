using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.DisciplineModule
{
    public class DisciplineRepository : BaseRepository<Discipline>
    {
        public DisciplineRepository(DataContext dataContext) : base(dataContext) 
        {
            if (dataContext.Disciplines.Count > 0)
            {
                this.counter = dataContext.Disciplines.Max(x => x.Id);
            }
        }

        public override List<Discipline> GetRegisters()
        {
            return _dataContext.Disciplines;
        }

        public override AbstractValidator<Discipline> GetValidator()
        {
            return new DisciplineValidator();
        }
        public override ValidationResult Insert(Discipline t)
        {
            bool nomeJaCadastrado = _dataContext.Disciplines.Any(x => x.Name.ToUpper() == t.Name.ToUpper());

            if (nomeJaCadastrado)
            {
                ValidationResult validadorNome = new ValidationResult();

                validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, disciplina já cadastrada."));

                return validadorNome;
            }

            return base.Insert(t);
        }

        public override ValidationResult Update(Discipline t)
        {

            AbstractValidator<Discipline> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid)
            {
                List<Discipline> registers = GetRegisters();

                bool existsName = _dataContext.Disciplines.Any(x => x.Name.ToUpper() == t.Name.ToUpper());
                //bool existsName = registers.Select(x => x.Name).Contains(t.Name, StringComparer.OrdinalIgnoreCase);

                if (existsName)
                    validationResult.Errors.Add(new ValidationFailure("", "Nome já está cadastrado"));

                if (validationResult.IsValid)
                {
                    foreach(Discipline discipline in registers)
                    {
                        if(discipline.Id == t.Id)
                        {
                            discipline.Update(t);
                            break;
                        }
                    }
                }
            }

            return validationResult;
        }
    }
}