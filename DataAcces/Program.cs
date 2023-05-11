using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAcces
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ;

        }
        public interface IProduct
        {
            List<Product> GetAllProducts();
            List<Product> Find();
            void GetSqlConnection();
            void Create(Product p);
            void GetAllProduct();
            void GetListProduct();
            Product GetProductById(int id);
            void UpdaterProduct(Product p);
            void Delete(Product p);
        }

        class MysqlConnection : IProduct
        {

            public void Create(Product p)
            {
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "INSERT INTO products (Name,Id,Price)VALUES(@productName,@productId,@productPrice);";
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@productName", p.Name);
                        command.Parameters.AddWithValue("@productId", p.Id);
                        command.Parameters.AddWithValue("@productPrice", p.Price);

                        int result = command.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
            }

            public void Delete(Product p)
            {
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "delete from products WHERE Id=@productId;";
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@productId", p.Id);


                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
            }

            public List<Product> Find()
            {
                throw new NotImplementedException();
            }

            public void GetAllProduct()
            {
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "select * from products";
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"İd:{reader[0]} Name:{reader[1]}");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
            }

            public List<Product> GetAllProducts()
            {
                List<Product> products = null;
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "select * from products";
                        products = new List<Product>();
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                Name = reader["Name"].ToString(),
                                Id = int.Parse(reader["Id"].ToString()),
                            });


                        }
                        reader.Close();

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                    return products;
                }
            }

            public void GetListProduct()
            {

                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "select * from products";
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"İd:{reader[0]} Name:{reader[1]}");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
            }

            public Product GetProductById(int id)
            {
                Product product = null;
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "select * from products where id=@productid";
                        product = new Product();
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        command.Parameters.Add("@productid", MySqlDbType.Int32).Value = id;
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            product = new Product
                            {
                                Name = reader["Name"].ToString(),
                                Id = int.Parse(reader["Id"].ToString()),
                            };
                        }
                        reader.Close();





                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                    return product;
                }


            }

            public void GetSqlConnection()
            {
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        Console.WriteLine("Baglanti Kuruldu");

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
            }

            public void UpdaterProduct(Product p)
            {
                var connection = @"server=localhost;port=3306;database=shopapp;user=root;password=mysql1234;";
                using (var connect = new MySqlConnection(connection))
                {
                    try
                    {
                        connect.Open();
                        var sql = "update products set Name=@productName where Id=@productId";
                        MySqlCommand command = new MySqlCommand(sql, connect);
                        command.Parameters.AddWithValue("@productName", p.Name);
                        command.Parameters.AddWithValue("@productId", p.Id);
                        command.Parameters.AddWithValue("@productPrice", p.Price);

                        int result = command.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    finally
                    {
                        connect.Close();
                        Console.ReadLine();
                    }
                }
                
            }

          
        }
    }
}
