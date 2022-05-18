﻿using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator.Domain.TestModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.TestModule
{
    public class TestRepository : BaseRepository<Test>
    {
        public TestRepository(DataContext dataContext) : base(dataContext) 
        {
            if (dataContext.Tests.Count > 0)
            {
                this.counter = dataContext.Tests.Max(x => x.Id);
            }
        }

        public override List<Test> GetRegisters()
        {
            return _dataContext.Tests;
        }

        public override AbstractValidator<Test> GetValidator()
        {
            return new TestValidator();
        }

        public override ValidationResult Insert(Test t)
        {
            List<Test> registros = GetRegisters();
            bool testJaCadastrado = registros.Any(x => x.Title.ToUpper() == t.Title.ToUpper());

            if (testJaCadastrado)
            {
                ValidationResult validadorNome = new ValidationResult();

                validadorNome.Errors.Add(new ValidationFailure("", "Registro não inserido, teste já cadastrada."));

                return validadorNome;
            }

            return base.Insert(t);
        }

        public override ValidationResult Update(Test t)
        {
            AbstractValidator<Test> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid == false)
                return validationResult;

            List<Test> registers = GetRegisters();

            bool existsName = registers.Select(x => x.Title).Contains(t.Title, StringComparer.OrdinalIgnoreCase);

            if (existsName && t.Id == 0)
                validationResult.Errors.Add(new ValidationFailure("", "Um teste com este título já está cadastrado."));

            if (validationResult.IsValid)
            {
                registers.ForEach(x =>
                {
                    if (x.Id == t.Id)
                        x.Update(t);
                });
            }

            return validationResult;
        }
    }
}