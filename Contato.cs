using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class Contato
    {
        private int ID;
        private string Nome;
        private List<Telefones> Telefone;
        private string Email;
        private int idade;

        public Contato()
        {
            this.Telefone = new List<Telefones>();
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return this.ID;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public void SetTelefone(Telefones Telefone)
        {
            this.Telefone.Add(Telefone);
        }
        public List<Telefones> GetTelefones()
        {
            return this.Telefone;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetIdade()
        {
            return this.idade;
        }
    }
        #region Telefone
        class Telefones
        {
            private string numero;
            private Operadora operadora;

        public void SetNumero(string numero)
        {
            if(numero.Length == 10)
            {
                this.numero = numero;
            }
            else if(numero.Length == 11)
            {
                this.numero = numero;
            }
        }

        public string GetNumero()
        {
            return this.numero;
        }
         
        public void SetOperadora(Operadora operadora)
        {
            this.operadora = operadora;
        }

        public Operadora GetOperadora()
        {
            return this.operadora;
        }
        }
        #region Operadora
        abstract class Operadora
        {
            protected string operadora;

            public string GetOperadora()
            {
                return this.operadora;
            }
            class Claro : Operadora
            {
                public Claro()
                {
                    this.operadora = "Claro";
                }
            }
            class Vivo : Operadora
            {
                public Vivo()
                {
                    this.operadora = "Vivo";
                }
            }
            class Oi : Operadora
            {
                public Oi()
                {
                    this.operadora = "Oi";
                }
            }
            class Tim : Operadora
            {
                public Tim()
                {
                    this.operadora = "Tim";
                }
            }

            #endregion
#endregion
        }


    }
