using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11900156projetofinal.Code.DTO
{
    class DadosDTO
    {
        private int _id;
        private string _gpm;
        private string _g12;
        private string _m13;


        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Gpm { get => _gpm; set => _gpm = value; }
        public string G12 { get => _g12; set => _g12 = value; }
        public string M13 { get => _m13; set => _m13 = value; }

        

    }
}
