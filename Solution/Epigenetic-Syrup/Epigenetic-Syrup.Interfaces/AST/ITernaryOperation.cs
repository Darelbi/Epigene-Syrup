/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using System.Numerics;

namespace EpigeneticSyrup.Interfaces.AST
{
    /// <summary>
    /// This class can also implement the epigenetic markers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITernaryOperation<T> : ISupportedMode where T : INumber<T>, IFloatingPointIeee754<T>
    {
        T Ternary(IResult<T> one, IResult<T> two, IResult<T> three);
    }
}
