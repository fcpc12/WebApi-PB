using System;
using System.Collections.Generic;
using ArquivoBaseBootcamp.Model;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ArquivoBaseBootcamp.Services
{
    public class InteresseService : IInteresseService
    {
        
        public Interessada ConsultarPorEmail(string email)
        {
            for (var contador = 1; length(listaDasInteressadas); contador++)) // o comando que conta os elementos da lista retorna esse valor em length
            {
                if (listaDasInteressadas.Email[contador] == email) // vendo o dado de email na posição "contador" e comparando com o email passado por referência
                {
                    return (listaDasInteressadas[contador]); // retorna a interessada na posição "contador" se for igual
                }
            }
            return (); 
        }

        public List<Interessada> ConsultarTodos()
        {
            // retornar lista DadosDasInteressadas.txt
            return (listaDasInteressadas);
        }

        // Obrigatorio nome E email
        // Validar email
        // Nao permitir email duplicado
        public Interessada Incluir(Interessada novaInteressada)
        {
            if (interessada.Email != null && interessada.Nome != null ) // vê se os dados estão completos
            {
                if (ConsultarPorEmail(novaInteressada.Email) == novaInteressada) // verifica se a interessada a ser incluída já está na lista
                {
                     return (novaInteressada); // retorna uma interessada que já existia, então não inclui novamente
                }
                else 
                {
                    listaDeInteressadas.Add(new interessada); // não encontrou na lista então adiciona 
                    return();
                }
               
            }
            else
            {
                return (null); // não retorna nada pois os dados estão incompletos
            }

        }

        public Interessada AtualizarEmail(int novoEmail, Interessada interessada)
        {
           if (ConsultarPorEmail(interessada.Email) == interessada) // consulta através do email para ver se a interessada está cadastrada
           {
                interessada.Email = novoEmail;
                return (interessada); // se está, retorna a interessada com dados atualizados
           }
           else
           {
               return();
           }
                   
        }

        public bool ExcluirPorEmail(string email)
        {
            if (ConsultarPorEmail(email).Email == email) // verificando se o email está na lista
            {
               //se estiver, remove-o da lista (creio que usando o método remove da classe list)
                return(true);
            }
            else 
            {
                return(false);
            }
            
        }
    }
}
