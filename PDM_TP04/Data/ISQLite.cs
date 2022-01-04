using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDM_TP04
{
    public interface ISQLite
    {
        SQLiteConnection GetConexao();
    }
}
