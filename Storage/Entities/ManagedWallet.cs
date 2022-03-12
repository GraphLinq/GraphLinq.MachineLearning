using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NodeBlock.Plugin.Avalanche.Storage.Entities
{
    [Table("managed_wallet")]
    public class ManagedWallet
    {
        [Key]
        [Column("id_managed_wallet")]
        public int Id { get; set; }

        [Column("wallet_id")]
        public int WalletId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("public_key")]
        public string PublicKey { get; set; }

        [Column("private_key")]
        public string PrivateKey { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
