using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Quiz_Assets
    {
        private string _kategorie;
        private string _frage;
        private string _antwort1;
        private string _antwort2;
        private string _antwort3;
        private string _antwort4;
        private int _loesung;
        public static int anzahl;

        public Quiz_Assets(string[] Array)
        {
            _kategorie = Array[0];
            _frage = Array[1];
            _antwort1 = Array[2];
            _antwort2 = Array[3];
            _antwort3 = Array[4];
            _antwort4 = Array[5];
            _loesung = Convert.ToInt32(Array[6]);
            anzahl++;

        }

        #region 'Eigenschaften'

        public string Kategorie { get { return _kategorie; } }

        public string Frage { get { return _frage; } }

        public string Antwort1 { get { return _antwort1; } }

        public string Antwort2 { get { return _antwort2; } }

        public string Antwort3 { get { return _antwort3; } }

        public string Antwort4 { get { return _antwort4; } }

        public int Loesung { get { return _loesung; } }

        #endregion

        #region AlteGetMethoden

        //public string getKategorie()
        //{
        //    return _kategorie;
        //}

        //public string getFrage()
        //{
        //    return _frage;
        //}

        //public string getAntwort1()
        //{
        //    return _antwort1;
        //}

        //public string getAntwort2()
        //{
        //    return _antwort2;
        //}

        //public string getAntwort3()
        //{
        //    return _antwort3;
        //}

        //public string getAntwort4()
        //{
        //    return _antwort4;
        //}

        //public int getLoesung()
        //{
        //    return _loesung;
        //}

        #endregion

    }
}
