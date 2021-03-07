using System;
using System.Collections.Generic;
using System.Linq;

namespace Masp.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Armas = new List<Arma>();
            Capacitacoes = new List<Capacitacao>();
        }

        public Guid Id { get; set; }
        public string Masp { get; set; }
        public string Nome { get; set; }
        public string Lotacao { get; set; }
        public string CaminhoFoto { get; set; }


        public string Escolaridade { get; set; }
        public List<Capacitacao> Capacitacoes { get; set; }
        public List<Arma> Armas { get; set; }


        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario() 
            { 
                Masp = "M1",
                CaminhoFoto = "Foto1.png",
                Escolaridade = "3º Grau",
                Id = Guid.Parse("4170DA7F-5B39-489F-A8F0-6E4508DEF0F8"),
                Lotacao = "Lotacao 1",
                Nome = "Fulano",
                Armas = new List<Arma>() 
                { 
                    new Arma()
                    {
                        CaminhoFoto = "bereta.png",
                        Nome = "Bereta"
                    },
                    new Arma()
                    {
                        CaminhoFoto = "fuzil.png",
                        Nome = "Fuzil"
                    },
                },
                Capacitacoes = new List<Capacitacao>() 
                {
                    new Capacitacao()
                    {
                        Id = Guid.Parse("4170DA7F-5B39-489F-A8F0-6E4508DEF0F8"),
                        CaminhoEscudo = "escudo1.png",
                        Nome = "Capacitacao1",
                        Particular = false,
                        UF = "MG"
                    }
                }

            });

            usuarios.Add(new Usuario()
            {
                Masp = "M2",
                CaminhoFoto = "Foto2.png",
                Escolaridade = "3º Grau",
                Id = Guid.Parse("3EED7DF2-EDE7-48BA-BF5E-452FD7EAE2A6"),
                Lotacao = "Lotacao 1",
                Nome = "Fulano",
                Armas = new List<Arma>()
                {
                    new Arma()
                    {
                        CaminhoFoto = "bereta.png",
                        Nome = "Bereta"
                    },
                    new Arma()
                    {
                        CaminhoFoto = "fuzil.png",
                        Nome = "Fuzil"
                    },
                },
                Capacitacoes = new List<Capacitacao>()
                {
                    new Capacitacao()
                    {
                        Id = Guid.Parse("3EED7DF2-EDE7-48BA-BF5E-452FD7EAE2A6"),
                        CaminhoEscudo = "escudo1.png",
                        Nome = "Capacitacao1",
                        Particular = false,
                        UF = "MG"
                    }
                }

            });

            return usuarios;
        }

        public Usuario Obter(string masp)
        {
            return Listar().FirstOrDefault(x => x.Masp.ToLower().Trim() == masp.ToLower().Trim());
        }

    }
}
