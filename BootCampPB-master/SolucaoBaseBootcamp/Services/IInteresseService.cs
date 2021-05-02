using System.Collections.Generic;
using ArquivoBaseBootcamp.Model;

namespace ArquivoBaseBootcamp.Services
{
    public interface IInteresseService
    {
        public object ConsultarPorEmail(string email);
        public List<object> ConsultarTodos();
        public object Incluir(Interessada interessada);
        public object AtualizarEmail(int novoEmail, Interessada interessada);
        public bool ExcluirPorEmail(string email);
    }
}
