/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using EpigeneticSyrup.Interfaces.AST;
using System.Numerics;

namespace EpigeneticSyrup.Interfaces.Factories
{
    public interface IBinaryConditionFactory<T> : ISyntaxName where T : INumber<T>, IFloatingPointIeee754<T>
    {

        public IBinaryCondition<T> Create();
    }
}
