// <copyright file="UserRole.cs" company="Corvinus Collective">
// Copyright (c) Corvinus Collective. All rights reserved.
// </copyright>

namespace Corvinus.WPF.Common.Security
{
    using Corvinus.WPF.Abstractions;

    /// <summary>
    /// A class based on IUserRole.
    /// </summary>
    public sealed class UserRole : IUserRole
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRole"/> class.
        /// </summary>
        /// <param name="userName">The users username used to lookup role information.</param>
        public UserRole(string userName)
        {
            switch (userName)
            {
                case "Admin":
                    this.RoleId = 0;
                    this.RoleName = "Administrator";
                    break;
                case "User":
                default:
                    this.RoleId = 9;
                    this.RoleName = "User";
                    break;
            }
        }

        /// <inheritdoc/>
        public int RoleId { get; }

        /// <inheritdoc/>
        public string RoleName { get; }
    }
}
