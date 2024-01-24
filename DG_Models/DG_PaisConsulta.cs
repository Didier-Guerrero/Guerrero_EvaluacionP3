using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Guerrero_EvaluacionP3.DG_Models
{
    [Table("DG_Pais")]
    internal class DG_PaisConsulta
    {
        [PrimaryKey,AutoIncrement]
        public int DG_PaisID { get; set; }
        public string Name { get; set; }
        public string DG_Language { get; set; }
        public string DG_Currency { get; set; }


    }
}
