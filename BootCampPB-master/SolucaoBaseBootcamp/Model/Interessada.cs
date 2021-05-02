

namespace ArquivoBaseBootcamp.Model
{
    public class Interessada
    {
        private string nome;
        private string email; // atributos

        public string Nome {  get; private set; }
        public string Email { get; private set; } //propriedades

        public Interessada(string nome, string email)
        {
            AdicionarEmail(email);
            AdicionarNome(nome);
        }

        public void AdicionarEmail(string email) // comportamentos
        {
            if (email (...)) // (...) tem "@" e não tem " " (possui @ e não tem espaço) 
            {
                Email = email;
            }
        }

        public void AdicionarNome(string nome) // comportamentos
        {
            if(nome (...)) // (...) tem " " (espaço) que significa nome e sobrenome (nome completo)
            {
                Nome = nome;
            }
        }


        public static List<Interessada> listaDasInteressadas = new List<Interessada>();

      /*   public List<Interessada> Todos()
        {
            return (listaDasInteressadas);
        } */

        /* public void Salvar()
        {
            IlistaDasInteressadas.Add(this);
        } */ 
    }

}