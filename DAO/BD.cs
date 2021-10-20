using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class BD
    {
        //Data Source=D:\Documentos\Faculdade 2021.2\Metodologia e Construção de Projetos de TI\Projetos\AppAula20212\bd.sdf;Password=123
        public static void AbrirConexao()
        { }

        public static void FecharConexao()
        { }

        public static DataTableReader ExecutarSelect(String _SQL)
        { }

        public static int ExecutarIDU(String _SQL)
        { }

        public static int ExecutarIDU(String _SQL, List<SqlCeParameter> parameters)
        { }

        public static Object ExecutarInsertComRetornoDeValor(String _SQL, List<SqlCeParameter> parameters)
        { }
    }
}
