using ContosoCrafts.Persistence.FluentMappings;
using ContosoCrafts.Persistence.Records;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Options;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ContosoCrafts.Persistence
{
    public class PostgresConnectionManager : IDisposable
    {
       

        public NHibernate.Cfg.Configuration cfg { get; set; }

        public ISessionFactory SessionFactory { get; set; }

        public PostgresConnectionManager(DatabaseConfig databaseConfig)
        {

            cfg = new NHibernate.Cfg.Configuration();

            cfg = Fluently.Configure()
    .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(databaseConfig.ConnectionString))
    .Mappings(m =>
    {

        m.FluentMappings
          .AddFromAssemblyOf<ProductRecordMap>();
    }).BuildConfiguration();

            SessionFactory = cfg.BuildSessionFactory();
        }

        public void Dispose(bool disposing)
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            if (!SessionFactory.IsClosed)
            {
                SessionFactory.Close();
            }

            SessionFactory.Dispose();
        }
    }

}
