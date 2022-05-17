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
            bool nomeJaCadastrado = _dataContext.Materias.Any(x => x.Name.ToUpper() == t.Name.ToUpper());

            if (nomeJaCadastrado)
            {
                ValidationResult validadorNome = new ValidationResult();

                validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, disciplina já cadastrada."));

                return validadorNome;
            }

            return base.Insert(t);
        }

        public override ValidationResult Update(Materia t)
        {
            bool nomeJaCadastrado = _dataContext.Materias.Any(x => x.Name.ToUpper() == t.Name.ToUpper());

            if (nomeJaCadastrado)
            {
                ValidationResult validadorNome = new ValidationResult();

                validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, disciplina já cadastrada."));

                return validadorNome;
            }

            return base.Update(t);
            //AbstractValidator<Materia> validator = GetValidator();
            //
            //ValidationResult validationResult = validator.Validate(t);
            //
            //if (validationResult.IsValid == false)
            //    return validationResult;
            //
            //List<Materia> registers = GetRegisters();
            //
            //bool existsName = registers.Select(x => x.Name).Contains(t.Name, StringComparer.OrdinalIgnoreCase);
            //
            //if (existsName && t.Id == 0)
            //    validationResult.Errors.Add(new ValidationFailure("", "Nome já está cadastrado"));
            //
            //if (validationResult.IsValid)
            //{
            //    registers.ForEach(x =>
            //    {
            //        if (x.Id == t.Id)
            //            x.Update(t);
            //    });
            //}
            //
            //return validationResult;
        }
    }
}