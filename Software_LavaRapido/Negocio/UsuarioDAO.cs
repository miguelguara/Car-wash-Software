using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Software_LavaRapido.Mapeamento;

namespace Software_LavaRapido.Negocio
{
    public class UsuarioDAO : Conexao
    {
        //Vai efetuar a verificação na tabela se há alguem parecido
       public bool Verificacao(string UserName, string senha) 
        {
            var igual = banco.Query<Usuario>("Select * from usuario where UserName = @Username AND senha = @senha", new {UserName,senha}).SingleOrDefault();
            if (igual == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Usuario> listar() 
        {
            return banco.Query<Usuario>("Select * from usuario").ToList();
        }

        public Usuario buscar(int ID) 
        {
            return banco.Query<Usuario>("Select * from usuario where ID = @ID",new {ID}).SingleOrDefault(); 
        }

        public bool Salvar(Usuario usuario)
        {
           if(usuario.ID == 0)
            {
                return banco.Execute("Insert into usuario values(@Username,@senha)",usuario) == 1;
            }
           else
            {
                return banco.Execute("update Usuario set Username = @Username, senha = @senha where ID = @ID", usuario) ==1;
            }
        }

        public bool Excluir(int ID) 
        {
            return banco.Execute("Delete From Usuario where ID = @ID", new {ID}) == 1;
        }
    }
}
