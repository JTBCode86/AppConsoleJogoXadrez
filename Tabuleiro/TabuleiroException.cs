using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        #region Construtor

        public TabuleiroException(string msg) 
            : base(msg) 
        {

        }

        #endregion
    }
}
