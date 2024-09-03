/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Epigene-Syrup */
using EpigeneticSyrup.Builtin;
using EpigeneticSyrup.Interfaces;
using System.Numerics;
using System.Reflection;

namespace EpigeneticSyrup
{
    /// <summary>
    /// This is my usual pattern to provide a generic a extensible library. I'm very consistent
    /// with it.
    /// </summary>
    public static class InstanceLoader
    {
        /// <summary>
        /// Just create a genetic builder with built-in functionality
        /// </summary>
        public static IGeneticBuilder<float> DefaultBuilder()
        {
            return BuilderFromAssemblies<float>([GetBuiltInAssembly()]);
        }

        /// <summary>
        /// Just create a genetic builder with built-in functionality
        /// </summary>
        public static IGeneticBuilder<double> DefaultBuilder_Precise()
        {
            return BuilderFromAssemblies<double>([GetBuiltInAssembly()]);
        }

        /// <summary>
        /// Make it available in case someone wants to load it besides other stuff
        /// </summary>
        /// <returns></returns>
        public static Assembly GetBuiltInAssembly()
        {
            // make sure the entry point is the same also for built-in library even though we could 
            // initialize it in other ways. keep it DRY (don't repeat yourself)
            return Assembly.GetAssembly(typeof(ReferenceMe))!;
        }

        /// <summary>
        /// Creates a genetic builder. The entry point for your application. You don't need to locate
        /// DLL or stuff. Just reference a type from your library, and call Assembly.GetAssembly(yourtype)
        /// on it. Like I did :)
        /// </summary>
        /// <typeparam name="T">Allows to select between float or double. For some rare applications 
        /// "double" is just better: https://arxiv.org/abs/2209.07219 And anyway we leverage INumber interfaces
        /// allowing also for other number types eventually</typeparam>
        /// <param name="assembliesToLoad">Assemblies where to search for implemented interfaces</param>
        /// <returns></returns>
        public static IGeneticBuilder<T> BuilderFromAssemblies<T>(params Assembly[] assembliesToLoad) where T : INumber<T>, IFloatingPointIeee754<T>
        {
            throw new System.NotImplementedException();
        }
    }
}
