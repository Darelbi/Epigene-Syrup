/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using System.Numerics;

namespace EpigeneticSyrup.Interfaces.AST
{
    public interface ITernaryCondition<T> : ISupportedMode where T : INumber<T>, IFloatingPointIeee754<T>
    {
        T Ternary(IBooleanResult one, IResult<T> two, IResult<T> three);
    }
}
