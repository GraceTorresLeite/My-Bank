using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDb
{
    public class Client
    {
        private int Id;
        private string Nome;
        private string Email;
        private DateTime Nascimento;
        private string Genero;
        private string Estado_Civil;
        public IList<Client> _clients = new List<Client>();

        public Client(int id, string nome, string email, DateTime nascimento, string genero, string estado_Civil)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            Genero = genero;
            Estado_Civil = estado_Civil;
        }

        public Client()
        {

        }


        public Client ValidaClient(int id)
        {
            var newClient = new Client();
            if (id == this.Id)
            {
                throw new InvalidOperationException("This ID already contain in database");
            }
            else
            {
                return newClient;
            }            
        }
    }
}
