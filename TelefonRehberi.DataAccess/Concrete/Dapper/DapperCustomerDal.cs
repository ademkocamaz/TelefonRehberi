using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using System.Collections.Generic;
using TelefonRehberi.DataAccess.Abstract;
using TelefonRehberi.Entities.Concrete;
using Dapper;

namespace TelefonRehberi.DataAccess.Concrete.Dapper
{
    public class DapperCustomerDal : ICustomerDal
    {
        private FbConnection connection;
        public DapperCustomerDal()
        {
            connection = new FbConnection(Database.connectionString);
        }

        public void Add(Customer entity)
        {
            connection.Open();
            connection.Execute("INSERT INTO CUSTOMERS (TITLE,NAME,LASTNAME,PHONE1,PHONE2) VALUES (@title,@name,@lastname,@phone1,@phone2)",
                new { entity.Title, entity.Name, entity.LastName, entity.Phone1, entity.Phone2 });
            connection.Close();
        }

        public void Delete(Customer entity)
        {
            connection.Open();
            connection.Execute("DELETE FROM CUSTOMERS WHERE ID=@id", new { entity.ID });
            connection.Close();
        }

        public Customer Get(int id)
        {
            connection.Open();
            var customer = connection.Query<Customer>("SELECT * FROM CUSTOMERS WHERE ID=@id", new { id }).FirstOrDefault();
            connection.Close();
            return customer;
        }

        public List<Customer> GetAll()
        {
            connection.Open();

            var list = connection.Query<Customer>("SELECT * FROM CUSTOMERS").ToList();

            connection.Close();
            return list;
        }

        public void Update(Customer entity)
        {
            connection.Open();
            connection.Execute("UPDATE CUSTOMERS SET TITLE=@title, NAME=@name, LASTNAME=@lastname, PHONE1=@phone1, PHONE2=@phone2 WHERE ID=@id",
                new { entity.Title, entity.Name, entity.LastName, entity.Phone1, entity.Phone2, entity.ID });
            connection.Close();
        }
    }
}
