﻿//-----------------------------------------------------------------------
// <copyright file="InputArgs.cs" company="Sully">
//     Copyright (c) Johnathon Sullinger. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MudDesigner.MudEngine.Core
{
    using System;

    /// <summary>
    /// Input Arguments provided when an event is fired requiring messaging support.
    /// </summary>
    public class InputArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputArgs"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public InputArgs(string message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message { get; private set; }
    }
}
