using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstrukcjeJezyka
{
    class SzkieletProgramu
    {
        //Szkielet programu składa się z elementów:

        #region Klasa
        /// <summary>
        /// Opis mojej klasy
        /// </summary>
        class MojaKlasa
        {
             //kod
        }
        #endregion Klasa

        #region Struktura
        /// <summary>
        /// Opis mojej struktury.
        /// </summary>
        struct MojaStruktura
        {
             //kod
        }
        #endregion Struktura

        #region Interfejs
        /// <summary>
        /// Opis interfejsu
        /// </summary>
        interface IMójInterfejs
        {
             //kod
        }
        #endregion Interfejs

        #region delegata

        /// <summary>
        /// Opis delegaty.
        /// </summary>
        /// <returns>Co dokładnie zwraca delegata?</returns>
        delegate int MojaDelegata();
        #endregion delegata

        #region TypWyliczeniowyEnum
        /// <summary>
        /// Opis typu wyliczeniowego.
        /// </summary>
        enum MójTypWyliczeniowy
        {
            //kod
        }
        #endregion TypWyliczeniowyEnum

        

    }
    #region PrzestrzenNazw

    namespace ZagniezdzonaPrzestrzenNazw
    {
        //jakieś struktury.   
    }
    #endregion PrzestrzenNazw
}
