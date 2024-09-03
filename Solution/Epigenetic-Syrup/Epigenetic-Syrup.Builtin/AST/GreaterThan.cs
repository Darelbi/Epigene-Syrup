/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using EpigeneticSyrup.Builtin.Exceptions;
using EpigeneticSyrup.Interfaces.AST;
using EpigeneticSyrup.Interfaces.Enums;
using System.Linq.Expressions;
using System.Numerics;

namespace EpigeneticSyrup.Builtin.AST
{
    /// <summary>
    /// Sample class to implement the AST
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GreaterThan<T> : IBinaryCondition<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public SupportedMode Mode => SupportedMode.Both;

        public bool Binary(IResult<T> left, IResult<T> right)
        {
            return left.GetResult() > right.GetResult();
        }

        public BinaryExpression BinaryExpression(Expression left, Expression right)
        {
            if (left.Type == typeof(T) && right.Type == typeof(T))
                return Expression.GreaterThan(left, right);

            // Ok this is excessive, but may help catching error for users implementing Expressions.
            // Ideally I need to catch this, and reconstruct the tree of classes to show it to the user
            throw new ExpressionException(typeof(GreaterThan<T>), ExceptionMessages.UnexpectedExpressionType);
        }
    }
}
