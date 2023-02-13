using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Application.Exceptions
{
    internal class ValidationException : Exception
    {
        public List<string> Errors { get; }
        public ValidationException() : base("Se han producide uno o más errores de validación")
        {
            Errors = new List<string>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }

        }
    }
}
