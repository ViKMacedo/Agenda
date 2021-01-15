using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    static class Agenda
    {
        public static List<Contato> contatos = new List<Contato>();

        public static void CriarContato(int ID, string Nome, List<Telefones> telefone, string email, int idade)
        {
            Contato contato = new Contato();
            contato.SetID(Agenda.contatos.Count);
            contato.SetNome(Nome);

            foreach (Telefones telefones in telefone)
                contato.SetTelefone(telefones);
            Agenda.contatos.Add(contato);

        }
    }

}
