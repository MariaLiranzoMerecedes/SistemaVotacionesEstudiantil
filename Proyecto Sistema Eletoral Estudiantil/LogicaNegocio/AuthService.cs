using System;
using System.Security.Cryptography;
using System.Text;
using AccesoDatos;
using Entidades;
using LogicaNegocio;

namespace LogicaNegocio
{
    public class AuthService
    {
        private UsuarioRepository repo =
            new UsuarioRepository();

        public string HashPassword(string pass)
        {
            using (SHA256 sha =
                SHA256.Create())
            {
                byte[] bytes =
                    sha.ComputeHash(
                        Encoding.UTF8.GetBytes(pass));

                return BitConverter
                    .ToString(bytes)
                    .Replace("-", "")
                    .ToLower();
            }
        }

        public Usuario Login(
            string matricula,
            string password)
        {
            string hash =
                HashPassword(password);

            return repo.Login(
                matricula,
                hash
            );
        }
    }
}
