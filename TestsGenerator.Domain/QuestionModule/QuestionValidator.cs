using FluentValidation;

namespace TestsGenerator.Domain.QuestionModule
{
    public class QuestionValidator : AbstractValidator<Question>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.Discipline)
                .NotNull()
                .WithMessage("Campo 'Disciplina' é obrigatório.");

            RuleFor(x => x.Grade)
                .NotEmpty()
                .WithMessage("Campo 'Série' é obrigatório.");

            RuleFor(x => x.Bimester)
                .NotEmpty()
                .WithMessage("Campo 'Bimestre' é obrigatório.");

            RuleFor(x => x.Materia)
                .NotEmpty()
                .WithMessage("Campo 'Matéria' é obrigatório.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Campo 'Enunciado' é obrigatório.");

            RuleFor(x => x.Alternatives)
                .Must(l => l.Count >= 2)
                .WithMessage("É necessário ter ao menos duas alternativas adicionadas.");

            RuleFor(x => x.Alternatives.Any(y => y.IsCorrect))
                .NotEmpty()
                .WithMessage("Ao menos uma alternativa deve ser definida como correta.");
        }
    }

    public class AlternativeValidator : AbstractValidator<Alternative>
    {
        public AlternativeValidator()
        {

            RuleFor(x => x.Letter)
                .NotEmpty()
                .WithMessage("Campo 'Letra' é obrigatório.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Campo 'Descrição' é obrigatório.");
        }
    }
}