/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using System.Numerics;

namespace EpigeneticSyrup.Interfaces
{
    public interface IGeneticBuilder<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
    }
}
