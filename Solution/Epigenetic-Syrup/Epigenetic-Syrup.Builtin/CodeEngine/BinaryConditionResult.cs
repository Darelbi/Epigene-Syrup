/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */using EpigeneticSyrup.Builtin.Exceptions;
using EpigeneticSyrup.Interfaces.AST;
using EpigeneticSyrup.Interfaces.Factories;
using System.Linq.Expressions;
using System.Numerics;

namespace EpigeneticSyrup.Builtin.CodeEngine
{
    public class BinaryConditionResult<T> : IBooleanResult where T : INumber<T>, IFloatingPointIeee754<T>
    {
        private readonly IBinaryConditionFactory<T> factory;
        private readonly IBinaryCondition<T> binaryCondition;

        public IResult<T> Left { get; set; }
        public IResult<T> Right { get; set; }

        public Func<bool> HybridCachedLambda { get; set; }

        public BinaryConditionResult(IBinaryConditionFactory<T> inputFactory)
        {
            factory = inputFactory;
            binaryCondition = factory.Create();

            // not obvious, since parameters are emitted, we don't need to pass the parameters
            Expression<Func<bool>> lambda = Expression.Lambda<Func<bool>>(Body());
            HybridCachedLambda = lambda.Compile();
        }

        public bool GetResult()
        {
            if(binaryCondition.Mode != Interfaces.Enums.SupportedMode.Expression)
                return binaryCondition.Binary(Left, Right);

            return HybridCachedLambda();
        }

        public Expression Body()
        {
            return binaryCondition.BinaryExpression(Left.GetExpression(), Right.GetExpression());
        }

        public Expression GetExpression()
        {
            if (binaryCondition.Mode == Interfaces.Enums.SupportedMode.Code)
            {
                return () => binaryCondition.Binary(Left, Right);
            }

            var finalExpression = Body();

            if (finalExpression.Type != typeof(bool))
                throw new ExpressionException(binaryCondition.GetType(), ExceptionMessages.ExpectedBooleanExpression);

            return finalExpression;
        }
    }
}
