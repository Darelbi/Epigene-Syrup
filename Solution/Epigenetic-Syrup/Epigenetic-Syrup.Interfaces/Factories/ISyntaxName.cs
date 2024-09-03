/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */namespace EpigeneticSyrup.Interfaces.Factories
{
    /// <summary>
    /// To save syntax trees, we need a different name for every existing operation/operator
    /// </summary>
    public interface ISyntaxName
    {
        public string Name { get; }
    }
}
