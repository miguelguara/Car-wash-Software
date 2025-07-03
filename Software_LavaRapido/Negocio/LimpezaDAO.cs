using Dapper;
using Software_LavaRapido.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_LavaRapido.Negocio
{
    public class LimpezaDAO : Conexao
    {
        public List<Limpeza> Listar() 
        {
            return banco.Query<Limpeza>("Select * from limpezas").ToList();
        }

        public Limpeza Buscar(int ID) 
        {
            return banco.Query<Limpeza>("Select * from Limpezas where ID = @ID", new {ID}).SingleOrDefault();
        }
        
        public bool Salvar(Limpeza limpeza) 
        {
            if (limpeza.ID == 0) 
            {
                return banco.Execute("Insert into Limpezas values(@PlacaCarro,@IDCliente,@Valor_Limpeza,@HorarioAgendado,@DiaAgendado)", limpeza) == 1;
            }
            else 
            {
                return banco.Execute("Update Limpezas Set " +
                    "PlacaCarro = @PlacaCarro, IDCliente = @IDCliente, Valor_Limpeza = @Valor_Limpeza, " +
                    "HorarioAgendado = @HorarioAgendado, " +
                    "DiaAgendado = @DiaAgendado",limpeza) == 1;
            }
        }

        public bool EXCLUIR(int ID) 
        {
            return banco.Execute("Delete from Limpezas where ID = @ID", new { ID }) == 1;
        }
    }
}
