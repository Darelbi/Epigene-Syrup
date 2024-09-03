/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using System.Runtime.Serialization;

namespace EpigeneticSyrup.Builtin.Exceptions
{
    public class ExpressionException : System.InvalidOperationException
    {
        public ExpressionException()
        {
        }

        public ExpressionException(System.Type type, string? message) : base(message)
        {
        }

        public ExpressionException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
