﻿//-----------------------------------------------------------------------
// <copyright file="ThunderstormWeather.cs" company="Sully">
//     Copyright (c) Johnathon Sullinger. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MudDesigner.MudEngine.Environment
{
    /// <summary>
    /// Represents Thunderstorms
    /// </summary>
    public sealed class ThunderstormWeather : IWeatherState
    {
        /// <summary>
        /// Gets the occurrence probability of this weather state occurring in an environment.
        /// The higher the probability relative to other weather states, the more likely it is going to occur.
        /// </summary>
        public double OccurrenceProbability
        {
            get
            {
                return 15;
            }
        }

        /// <summary>
        /// Gets the name of the weather state.
        /// </summary>
        public string Name
        {
            get
            {
                return "Thunderstorm";
            }
        }
    }
}