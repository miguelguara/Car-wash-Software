using Dapper;
using Software_LavaRapido.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_LavaRapido.Negocio
{
    public class ClienteDAO: Conexao
    {
        //Lista todos os clientes na hora de pesquisar
        public List<Cliente> Listar(string nome)
        {
            //Checa se o textbox está vazio
            if(nome == "") 
            {
                return banco.Query<Cliente>("SELECT * from Clientes").ToList();
            }
            else
            {
                return banco.Query<Cliente>($@"select * from clientes where Nome like'%{nome}%'").ToList();
            }
            
        }
        //Busca um unico cliente
        public Cliente Buscar(int id) 
        {
            return banco.Query<Cliente>("SELECT * from Clientes where ID = @ID", new {id}).SingleOrDefault();
        }

        public List<Cliente> ListarParaCombo() 
        {
            return  banco.Query<Cliente>("Select * from Clientes").ToList();
        }

        //Salva o cliente novo ou a alteração
        public bool Salvar(Cliente cliente)
        {
            if (cliente.ID == 0)
            {
                return banco.Execute(@"insert into Clientes (Nome, CPF, Endereco) 
                             values ( @Nome, @CPF, @Endereco)", cliente) == 1;

            }
            else
            {
                //Vai checar a quantidade de alterações somente necessário uma
                var quantidade = banco.Execute("UPDATE Clientes SET " +
                                "Nome = @Nome, CPF = @CPF, " +
                                "Endereco = @Endereco " +
                                "WHERE  " +
                                "ID = @ID",
                                cliente);

                if (quantidade == 0)
                {
                    return false;
                }
                else if (quantidade == 1)
                {
                    return true;
                }
                else
                    throw new Exception("ERROOOOOOOOO");
                
            }

        }

        public bool excluir(int id) 
        {
           return banco.Execute("delete from clientes where ID = @ID",new {id}) == 1;
        }
    }
}
