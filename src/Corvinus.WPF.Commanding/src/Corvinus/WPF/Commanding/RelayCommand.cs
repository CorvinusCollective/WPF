﻿// <copyright file="RelayCommand.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Jacob.Modular.UI.WPF.Common.Commanding
{
    using System;
    using System.Diagnostics;
    using System.Windows.Input;

    /// <summary>
    /// Relay Command.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">Action typeof object.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">Action typeof object.</param>
        /// <param name="canExecute">Predicate typeof object.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException("execute");
            this.canExecute = canExecute;
        }

        /// <summary>
        /// EventHandler for CanExecuteChanged
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Returns Boolean of canExecute.
        /// </summary>
        /// <param name="parameter">object.</param>
        /// <returns>True/False.</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        /// <summary>
        /// Executes parameter.
        /// </summary>
        /// <param name="parameter">object.</param>
        [DebuggerStepThrough]
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
