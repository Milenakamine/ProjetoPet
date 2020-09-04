using ProjetoPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPet.Interfaces
{
    interface ITipoPet
    {
        //utilizando crud

        //create
        TipoPet Cadastrar(TipoPet p);

        //listando as racas
        List<TipoPet> LerTodos();

        //busca por id
        TipoPet BuscarPorId(int id);

        //alterar
        TipoPet Alterar(TipoPet p);

        //delete
        void Excluir(int id);

    }
}
