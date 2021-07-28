// <copyright file="IUserRole.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Abstractions
{
    /// <summary>
    /// An interface for user roles.
    /// </summary>
    public interface IUserRole
    {
        /// <summary>
        /// Gets a RoleId for a User.
        /// </summary>
        int RoleId { get; }

        /// <summary>
        /// Gets a Friendly name for the User Role.
        /// </summary>
        string RoleName { get; }
    }
}
