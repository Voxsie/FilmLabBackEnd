using System;
using LinqToDB.Mapping;

namespace DateBase
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(IsPrimaryKey = true)]
        public int user_id { get; set; }
        [Column(Name = "Name")]
        public string firstname { get; set; }
        [Column(Name = "nickname")]
        public string nickname { get; set; }
        [Column(Name = "email")]
        public string email { get; set; }
        [Column(Name = "password")]
        public string password { get; set; }
        [Column(Name = "birth_date")]
        public DateTime birth_date { get; set; }
        [Column(Name = "joined_date")]
        public DateTime joined_date { get; set; }
    }
}