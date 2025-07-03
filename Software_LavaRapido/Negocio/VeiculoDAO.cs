using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Software_LavaRapido.Mapeamento;

namespace Software_LavaRapido.Negocio
{
    public class VeiculoDAO: Conexao
    {
        public List<Veiculo>Listar(string placa) 
        {
            if (placa == "") 
            {
               return banco.Query<Veiculo>("select * from veiculos").ToList();
            }
            else
            {
                return banco.Query<Veiculo>($@"Select * from veiculos where Placa like'%{placa}%'").ToList();
            }
        }
        //Retorna somente um veiculo na hora de alterar vir exatamente o que eu pedir
        public Veiculo Buscar(int ID)
        {
            return banco.Query<Veiculo>("Select * from veiculos where ID = @ID", new {ID}).SingleOrDefault();
        }

        public List<Veiculo> ListarVeiculoParaCombo()
        {
            return banco.Query<Veiculo>("Select * from Veiculos").ToList();
        }

        //Salva ou Altera o veiculo selecionado
        public bool Salvar(Veiculo veiculo)
        {
            if (veiculo.ID == 0)
            {
                return banco.Execute("Insert into Veiculos values(@Placa, @Modelo_Carro)",veiculo) == 1;
            }
            else 
            {
                return banco.Execute("Update Veiculos SET Placa = @Placa, Modelo_Carro = @Modelo_Carro where ID = @ID", veiculo) == 1;
            }
        }
        //Exclui o veiculo selecionado
        public bool Excluir(string placa) 
        {
           return banco.Execute("Delete From veiculos where Placa = @Placa", new {placa}) == 1;
        }

    }
}
