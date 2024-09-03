/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */using EpigeneticSyrup.Builtin.AST;
using EpigeneticSyrup.Interfaces.AST;
using EpigeneticSyrup.Interfaces.Factories;
using System.Numerics;

namespace EpigeneticSyrup.Builtin.Factories
{
    public class GreaterThanFactory<T> : IBinaryConditionFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public string Name => SyntaxNames.GreaterThan;

        public IBinaryCondition<T> Create()
        {
            return new GreaterThan<T>();
        }
    }
}
