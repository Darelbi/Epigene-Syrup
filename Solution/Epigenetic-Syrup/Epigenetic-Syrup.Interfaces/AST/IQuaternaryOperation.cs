/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */

using System.Numerics;

namespace EpigeneticSyrup.Interfaces.AST
{
    public interface IQuaternaryOperation<T> : ISupportedMode where T : INumber<T>, IFloatingPointIeee754<T>
    {
        T Quaternary(IResult<T> one, IResult<T> two, IResult<T> three, IResult<T> four);
    }
}
