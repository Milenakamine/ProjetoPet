using ProjetoPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPet.Interfaces
{
    interface IRaca
    {
        //utilizando crud

        //create
        Raca Cadastrar(Raca r);

        //listando as racas
        List<Raca> LerTodos();

        //busca por id
        Raca BuscarPorId(int id);

        //alterar
        Raca Alterar(Raca r);

        //delete
        void Excluir(int id);




    }
}
