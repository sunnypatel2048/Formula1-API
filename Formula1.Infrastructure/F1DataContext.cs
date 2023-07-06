using Formula1.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Infrastructure
{
    /// <summary>The F1DataContextClass</summary>
    public class F1DataContext : DbContext
    {
        /// <summary>Initializes a new instance of the <see cref="F1DataContext" /> class.</summary>
        /// <param name="options">The options.</param>
        public F1DataContext(DbContextOptions<F1DataContext> options) : base(options) { }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1">DbSet</see> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.
        /// </param>
        /// <remarks>
        ///   <para>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)">UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)</see>)
        /// then this method will not be run. However, it will still run when creating a compiled model.
        /// </para>
        ///   <para>
        /// See <a href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</a> for more information and
        /// examples.
        /// </para>
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        /// <summary>Gets or sets the drivers.</summary>
        /// <value>The drivers.</value>
        public DbSet<Driver> Drivers { get; set; }

        /// <summary>Gets or sets the teams.</summary>
        /// <value>The teams.</value>
        public DbSet<Team> Teams { get; set; }

        /// <summary>Gets or sets the engine providers.</summary>
        /// <value>The engine providers.</value>
        public DbSet<EngineProvider> EngineProviders { get; set; }

        /// <summary>Gets or sets the team principals.</summary>
        /// <value>The team principals.</value>
        public DbSet<TeamPrincipal> TeamPrincipals { get; set; }
    }
}
