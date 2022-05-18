﻿using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.QuestionModule
{
    public class Question : BaseEntity<Question>
    {
        public string Grade { get; set; }
        public string Description { get; set; }
        public Discipline Discipline { get; set; }
        public Bimester? Bimester { get; set; }
        public Materia Materia { get; set; }
        public List<Alternative> Alternatives { get; set; } = new();

        public override void Update(Question t)
        {
            Grade = t.Grade;
            Description = t.Description;
            Discipline = t.Discipline;
            Bimester = t.Bimester;
            Materia = t.Materia;
            Alternatives = t.Alternatives;
        }

        public override string ToString()
        {
            return $"{Description}";
        }

        public Question Clone()
        {
            return MemberwiseClone() as Question;
        }
    }

    public class Alternative
    {
        public string Letter { get; set; }
        public bool IsCorrect { get; set; }
        public string Description { get; set; }

        public Alternative(string letter, bool isCorrect, string description)
        {
            Letter = letter;
            IsCorrect = isCorrect;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Letter}) {Description}";
        }
    }
}