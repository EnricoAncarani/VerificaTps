using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTPS
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private string _dataPublicazione;
        private string _editor;
        private int _numeroPagine;

        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _autore = value;
                }
            }
        }
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _titolo = value;
                }
            }
        }
        public string DataPublicazione
        {
            get
            {
                return _dataPublicazione;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _dataPublicazione = value;
                }
            }
        }
        public string Editor
        {
            get
            {
                return _editor;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _editor = value;
                }
            }
        }
        public int NumeroPagine
        {
            get
            {
                return _numeroPagine;
            }
            set
            {
                try
                {
                    _numeroPagine = value;
                }catch
                {

                }
            }
        }
    }
}
