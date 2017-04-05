using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Union.Repositorio.Excecao;

namespace Dominio.Abstratas
{
    public abstract class AbstractBE<T>
    {
        private MySqlConnection mySqlConnection;
        private MySqlTransaction mySqlTransaction;
        private MySqlCommand mySqlCommand;

        private void SetMySqlCommand(MySqlCommand mySqlCommand)
        {
            this.mySqlCommand = mySqlCommand;
        }

        protected MySqlCommand GetMySqlCommand()
        {
            return mySqlCommand;
        }

        private void SetMySqlConnection(MySqlConnection mySqlConnection)
        {
            this.mySqlConnection = mySqlConnection;
        }

        private MySqlConnection GetMySqlConnection()
        {
            return mySqlConnection;
        }

        private void SetMySqlTransaction(MySqlTransaction mySqlTransaction)
        {
            this.mySqlTransaction = mySqlTransaction;
        }

        private MySqlTransaction GetMySqlTransaction()
        {
            return mySqlTransaction;
        }

        protected AbstractBE()
        {
            try
            {
                AbrirConexao();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        protected AbstractBE(MySqlCommand mySqlCommand)
        {
            try
            {
                if (!mySqlCommand.Connection.State.Equals(ConnectionState.Open))
                    throw new Exception("A conexão com o banco de dados não esta aberta!");

                SetMySqlCommand(mySqlCommand);
            }
            catch (Exception e)
            {
                throw new Exception("A conexão com o banco de dados não esta aberta!", e);
            }
        }

        private void AbrirConexao()
        {
            MySqlConnection connection = null;
            MySqlCommand command = null;
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection("Server=localhost;Port=3306;Database=UnionPlus;Uid=root;Pwd=@pec2016;Pooling=false;IntegratedSecurity=no");
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        SetMySqlConnection(connection);
                        command = GetMySqlConnection().CreateCommand();
                        command.Connection = GetMySqlConnection();
                        command.CommandType = CommandType.Text;
                        command.CommandTimeout = 500;
                        command.Parameters.Clear();
                        SetMySqlCommand(command);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel abrir conexão com o banco de dados!", e);
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (GetMySqlConnection() != null && GetMySqlCommand() != null)
                {


                    GetMySqlConnection().Close();
                    MySqlConnection.ClearPool(GetMySqlConnection());
                    GetMySqlConnection().Dispose();
                    SetMySqlConnection(null);
                    GetMySqlCommand().Dispose();
                    SetMySqlCommand(null);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possivel fechar conexão com o banco de dados!", e);
            }
        }
        protected void BeginTransaction()
        {
            MySqlTransaction transaction = null;
            try
            {
                transaction = GetMySqlConnection().BeginTransaction();
                SetMySqlTransaction(transaction);
                GetMySqlCommand().Transaction = GetMySqlTransaction();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível abrir a transação com o banco de dados!", e);
            }
        }

        protected void Commit()
        {
            try
            {
                GetMySqlTransaction().Commit();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        protected void Rollback()
        {
            try
            {
                GetMySqlTransaction().Rollback();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        protected void ValidarAtributosObjeto(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            StringBuilder sb = new StringBuilder();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            if (resultadoValidacao.Any())
                throw new CampoObrigatorioException("Há campos que deverão ser preenchidos de forma correta.");
        }

        public abstract void Inserir(T obj);
        public abstract int Alterar(T obj);
        public abstract void Deletar(T obj);
        public abstract void Consultar(T obj);
        public abstract List<T> GetLista(T obj);
    }
}