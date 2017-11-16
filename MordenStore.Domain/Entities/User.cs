﻿using FluentValidator;
using ModernStore.Share.Entities;
using System;
using System.Text;

namespace MordenStore.Domain.Entities
{
    public class User : Entity
    {
        protected User()
        {

        }
        public User(string userName, string password, string confirmPassword )
        {
            //Id = Guid.NewGuid();
            UserName = userName;
            Password = EncryptPassword(password);
            Active = true;

            new ValidationContract<User>(this)
                .AreEquals(x => x.Password, EncryptPassword(confirmPassword), "As senhas não coincidem");
        }

        //public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }

        public void Activate() => Active = true;

        public void Deactivate() => Active = false;

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";
            var password = (pass += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
