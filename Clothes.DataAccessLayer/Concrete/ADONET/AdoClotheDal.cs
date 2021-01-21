using Clothes.DataAccessLayer.Abstract;
using Clothes.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace Clothes.DataAccessLayer.Concrete.ADONET
{
    public class AdoClotheDal : IClotheDal
    {
        public void Add(Clothe entity)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Clothes (UnitPrice, Name) VALUES (@UnitPrice, @Name)"))
            {
                command.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                command.Parameters.AddWithValue("Name", entity.Name);
                DBMS.ExecuteNonQuery(command);
            }
        }

        public void Delete(Clothe entity)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Clothes WHERE ClotheId = @ClotheId"))
            {
                command.Parameters.AddWithValue("ClotheId", entity.ClotheId);
                DBMS.ExecuteNonQuery(command);
            }
        }

        public Clothe Get(Expression<Func<Clothe, bool>> filter)
        {
            var clotheList = new List<Clothe>();
            SqlConnection connection = new SqlConnection(DBMS.Connection);
            SqlCommand command = new SqlCommand("SELECT * FROM Clothes", connection);
            command.Connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var clothe = new Clothe();
                clothe.ClotheId = Convert.ToInt32(reader[0]);
                clothe.UnitPrice = Convert.ToDecimal(reader[1].ToString());
                clothe.Name = reader[2].ToString();
                clotheList.Add(clothe);
            }

            var list = clotheList.Where(filter.Compile()).ToList();
            command.Connection.Close();
            return list[0];
        }

        public List<Clothe> GetAll(Expression<Func<Clothe, bool>> filter = null)
        {
            var clotheList = new List<Clothe>();
            SqlConnection connection = new SqlConnection(DBMS.Connection);
            SqlCommand command = new SqlCommand("SELECT * FROM Clothes", connection);
            command.Connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var clothe = new Clothe();
                clothe.ClotheId = Convert.ToInt32(reader[0]);
                clothe.UnitPrice = Convert.ToDecimal(reader[1].ToString());
                clothe.Name = reader[2].ToString();
                clotheList.Add(clothe);
            }
            command.Connection.Close();
            return filter == null ? clotheList : clotheList.Where(filter.Compile()).ToList();
        }

        public void Update(Clothe entity)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Clothes SET Name = @Name, UnitPrice = @UnitPrice WHERE ClotheId = @ClotheId"))
            {
                command.Parameters.AddWithValue("ClotheId", entity.ClotheId);
                command.Parameters.AddWithValue("Name", entity.Name);
                command.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
                DBMS.ExecuteNonQuery(command);
            }
        }
    }
}
