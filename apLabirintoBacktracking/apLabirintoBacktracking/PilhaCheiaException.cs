using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apLabirintoBacktracking
{
  class PilhaCheiaException : Exception
  {
    public PilhaCheiaException(string mensagem) : base(mensagem)
    {
    }
  }
}
