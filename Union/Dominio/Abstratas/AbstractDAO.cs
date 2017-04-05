using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Abstratas
{
    public abstract class AbstractDAO<T>
    {
        private MySqlCommand mySqlCommand;
        private MySqlDataReader mySqlDataReader;

        public AbstractDAO(MySqlCommand mySqlCommand)
        {
            SetMySqlCommand(mySqlCommand);
        }

        private void SetMySqlCommand(MySqlCommand mySqlCommand)
        {
            this.mySqlCommand = mySqlCommand;
        }

        protected MySqlCommand GetMySqlCommand()
        {
            if (mySqlCommand == null) mySqlCommand = new MySqlCommand();

            return mySqlCommand;
        }

        private void SetMySqlDataReader(MySqlDataReader mySqlDataReader)
        {
            this.mySqlDataReader = mySqlDataReader;
        }

        protected MySqlDataReader GetMySqlDataReader()
        {
            if (mySqlDataReader == null) mySqlDataReader = GetMySqlCommand().ExecuteReader();

            return mySqlDataReader;
        }

        protected void Close()
        {
            try
            {
                if (GetMySqlDataReader() != null)
                    GetMySqlDataReader().Close();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                SetMySqlDataReader(null);
            }
        }

        public abstract void Inserir(T obj);
        public abstract int Alterar(T obj);
        public abstract void Deletar(T obj);
        protected abstract string GetSQLConsulta(T obj);
        protected abstract void CarregarParametro(T obj);
        protected abstract void CarregarObjetoConsulta(T obj);
        public abstract void Consultar(T obj);
        public abstract List<T> GetLista(T obj);

        public object GetValueOrNull(object value)
        {
            if (value != null)
                return value;

            return DBNull.Value;
        }

        public object GetValueOrNull(long value)
        {
            if (value > 0)
                return value;

            return DBNull.Value;
        }
    }
}
