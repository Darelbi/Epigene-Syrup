/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */

using System.Linq.Expressions;

namespace EpigeneticSyrup.Interfaces.AST
{
    public interface IBinaryBoolean : ISupportedMode
    {
        bool Binary(IBooleanResult left, IBooleanResult right);

        BinaryExpression BinaryExpression(Expression left, Expression right);
    }
}
