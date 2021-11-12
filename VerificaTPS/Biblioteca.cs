using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTPS
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _oraDiApertura;
        private string _oraDiChiusura;
        private List<Libro> _listaLibri;
        
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(string.IsNullOrEmpty(value)==false)
                {
                    _nome = value;
                }
            }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _indirizzo = value;
                }
            }
        }
        public string OraApertura
        {
            get { return _oraDiApertura; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _oraDiApertura = value;
                }
            }
        }
        public string OraChiusura
        {
            get { return _oraDiChiusura; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _oraDiChiusura = value;
                }
            }
        }
        
    }
}
