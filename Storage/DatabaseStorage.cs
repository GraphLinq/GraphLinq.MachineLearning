using Microsoft.EntityFrameworkCore;
using NodeBlock.Engine.Storage.MariaDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NodeBlock.Plugin.Avalanche.Storage
{
    public class DatabaseStorage : DbContext
    {
        public DbSet<Entities.ManagedWallet> ManagedWallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseMySQL(Environment.GetEnvironmentVariable("mariadb_uri"));
            }
        }

        public DatabaseStorage(DbContextOptions<DatabaseStorage> options) : base(options) { }

        public Entities.ManagedWallet FetchManagedWalletByName(int walletId, string name)
        {
            var task = this.ManagedWallets.FirstOrDefaultAsync(x => x.WalletId == walletId && x.Name == name);
            task.Wait();
            return task.Result;
        }
    }
}
