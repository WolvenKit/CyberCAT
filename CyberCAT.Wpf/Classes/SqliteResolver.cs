using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CyberCAT.Wpf.Classes
{
    public class SqliteResolver : DbContext, ITweakDbResolver
    {
        private readonly string _fileName;
        private readonly HashSet<TweakDbEntry> _cache;

        public SqliteResolver(string fileName)
        {
            _fileName = fileName;
            _cache = new HashSet<TweakDbEntry>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={_fileName}");
        
        [Table("tweakdb")]
        public class TweakDbEntry
        {
            [Column("hash"), Required, Key]
            public ulong Hash { get; set; }

            [Column("name"), Required]
            public string Name { get; set; }

            [Column("gameName")]
            public string GameName { get; set; }

            [Column("gameDescription")]
            public string GameDescription { get; set; }
        }

        public DbSet<TweakDbEntry> TweakDbEntries { get; set; }


        public string GetName(TweakDbId tdbid)
        {
            var entry = _cache.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
            if (entry == null)
            {
                entry = TweakDbEntries.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
                _cache.Add(entry);
            }
            return entry?.Name ?? $"Unknown_{tdbid}";
        }

        public string GetGameName(TweakDbId tdbid)
        {
            var entry = _cache.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
            if (entry == null)
            {
                entry = TweakDbEntries.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
                _cache.Add(entry);
            }
            return entry?.GameName ?? "";
        }

        public string GetGameDescription(TweakDbId tdbid)
        {
            var entry = _cache.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
            if (entry == null)
            {
                entry = TweakDbEntries.FirstOrDefault(_ => _.Hash == tdbid.Raw64);
                _cache.Add(entry);
            }
            return entry?.GameDescription ?? "";
        }

        public ulong GetHash(string itemName)
        {
            return TweakDbEntries.FirstOrDefault(_ => _.Name.Equals(itemName))?.Hash ?? 0;
        }
    }
}
