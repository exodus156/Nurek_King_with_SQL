using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MichalDzialek_Lab5_ZadDom.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Globalization;

namespace MichalDzialek_Lab5_ZadDom.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// String łączący z bazą danych
        /// </summary>
        readonly string connectionString = @"Data Source=DESKTOP-8C9PSO3\SQLEXPRESS; database=MichalDzialekLab5_ZadDom; Trusted_Connection=yes;";

        /// <summary>
        /// Listy dla poszczególnych kategorii sprzętowych
        /// </summary>
        List<ObjectTemplateModel> automaty()
        {
            List<ObjectTemplateModel> Automaty = new List<ObjectTemplateModel>();
            string query = @"SELECT * FROM AutomatyView";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Automaty.Add(new ObjectTemplateModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString()));
                    reader.Close();
                }
                connection.Close();
            }
            return Automaty;
        }

        List<ObjectTemplateModel> boje()
        {
            List<ObjectTemplateModel> Boje = new List<ObjectTemplateModel>();
            string query = @"SELECT * FROM BojeView";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Boje.Add(new ObjectTemplateModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString()));
                    reader.Close();
                }
                connection.Close();
            }
            return Boje;
        }

        List<ObjectTemplateModel> butle()
        {
            List<ObjectTemplateModel> Butle = new List<ObjectTemplateModel>();
            string query = @"SELECT * FROM ButleView";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Butle.Add(new ObjectTemplateModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString()));
                    reader.Close();
                }
                connection.Close();
            }
            return Butle;
        }

        List<ObjectTemplateModel> kamizelki()
        {
            List<ObjectTemplateModel> Kamizelki = new List<ObjectTemplateModel>();
            string query = @"SELECT * FROM KamizelkiView";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Kamizelki.Add(new ObjectTemplateModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString()));
                    reader.Close();
                }
                connection.Close();
            }
            return Kamizelki;
        }

        List<ObjectTemplateModel> skafandry()
        {
            List<ObjectTemplateModel> Skafandry = new List<ObjectTemplateModel>();
            string query = @"SELECT * FROM SkafandryView";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Skafandry.Add(new ObjectTemplateModel(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString()));
                    reader.Close();
                }
                connection.Close();
            }
            return Skafandry;
        }

        /// <summary>
        /// Liczy ilość rzędów w tabeli z automatami
        /// </summary>
        /// <returns></returns>
        public int AutomatyCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.AutomatyOddechowe";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Liczy ilość rzędów w tabeli z bojami
        /// </summary>
        /// <returns></returns>
        public int BojeCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Boje";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Liczy ilość rzędów w tabeli z butlami
        /// </summary>
        /// <returns></returns>
        public int ButleCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Butle";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Liczy ilość rzędów w tabeli z kamizelkami
        /// </summary>
        /// <returns></returns>
        public int KamizelkiCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Kamizelki";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Liczy ilość rzędów w tabeli ze skafandrami
        /// </summary>
        /// <returns></returns>
        public int SkafandryCount()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.Skafandry";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    thisConnection.Close();
                }
            }
            return count;
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Automaty oddechowe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Automaty()
        {
            return View(automaty());
        }

        /// <summary>
        /// POST/DELETE/UPDATE request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Automaty(NewObjectModel ObjectModel)
        {
            NewObjectModel model = new NewObjectModel
            {
                UniqueID = ObjectModel.UniqueID,
                RequestType = ObjectModel.RequestType
            };
            if (model.RequestType == "POST")
            {
                if (model.UniqueID == "1")
                {
                    return View("Automaty_1ViewModel");
                }
                else if (model.UniqueID == "2")
                {
                    return View("Automaty_2ViewModel");
                }
                else if (model.UniqueID == "3")
                {
                    return View("Automaty_3ViewModel");
                }
                else
                {
                    return View("Index");
                }
            }
            else if (model.RequestType == "DELETE")
            {
                //HANDLE DELETE PART
                string DelID = model.UniqueID;
                //Funkcja usuwająca zamknięta w stringu
                string delfunc = "DELETE FROM dbo.AutomatyOddechowe WHERE UniqueID = @UniqueID";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    //Usuwanko
                    using (SqlCommand cmdDelete = new SqlCommand(delfunc, thisConnection))
                    {
                        thisConnection.Open();
                        cmdDelete.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = DelID;
                        cmdDelete.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }

                //Tworzenie lokalnej listy z ID dla danej tabeli w celu aktualizacji po usunięciu
                List<int> columnData = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID FROM dbo.AutomatyOddechowe";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(Int32.Parse(reader[0].ToString()));
                            }
                        }
                    }
                    connection.Close();
                }

                //HANDLE UPDATE PART
                int specialCounter = 1;
                int indexCounter = 0;
                int Ilosc = AutomatyCount();
                //Funkcja akrualizująca dane
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string upfunc = "UPDATE dbo.AutomatyOddechowe SET UniqueID = @uniqueID WHERE ID = @ID";
                    using(SqlCommand command = new SqlCommand(upfunc, connection))
                    {
                        while (specialCounter <= Ilosc)
                        {
                            connection.Open();
                            command.Parameters.Clear();
                            command.Parameters.Add("@uniqueID", SqlDbType.NVarChar).Value = specialCounter;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = columnData[indexCounter];
                            command.ExecuteNonQuery();
                            connection.Close();

                            specialCounter++;
                            indexCounter++;
                        }
                    }
                }

                return Content("Refresh");
            }
            else
            {
                return Content("Błąd po stronie servera, zawołaj DevOpsa");
            }
        }

        /// <summary>
        /// Boje znacznikowe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Boje()
        {
            return View(boje());
        }

        /// <summary>
        /// POST/DELETE/UPDATE request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Boje(NewObjectModel ObjectModel)
        {
            NewObjectModel model = new NewObjectModel
            {
                UniqueID = ObjectModel.UniqueID,
                RequestType = ObjectModel.RequestType
            };
            if (model.RequestType == "POST")
            {
                if (model.UniqueID == "1")
                {
                    return View("Boje_1ViewModel");
                }
                else if (model.UniqueID == "2")
                {
                    return View("Boje_2ViewModel");
                }
                else
                {
                    return View("Index");
                }
            }
            else if (model.RequestType == "DELETE")
            {
                //HANDLE DELETE PART
                string DelID = model.UniqueID;
                //Funkcja usuwająca zamknięta w stringu
                string delfunc = "DELETE FROM dbo.Boje WHERE UniqueID = @UniqueID";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    //Usuwanko
                    using (SqlCommand cmdDelete = new SqlCommand(delfunc, thisConnection))
                    {
                        thisConnection.Open();
                        cmdDelete.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = DelID;
                        cmdDelete.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }

                //Tworzenie lokalnej listy z ID dla danej tabeli w celu aktualizacji po usunięciu
                List<int> columnData = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID FROM dbo.Boje";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(Int32.Parse(reader[0].ToString()));
                            }
                        }
                    }
                    connection.Close();
                }

                //HANDLE UPDATE PART
                int specialCounter = 1;
                int indexCounter = 0;
                int Ilosc = BojeCount();
                //Funkcja akrualizująca dane
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string upfunc = "UPDATE dbo.Boje SET UniqueID = @uniqueID WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(upfunc, connection))
                    {
                        while (specialCounter <= Ilosc)
                        {
                            connection.Open();
                            command.Parameters.Clear();
                            command.Parameters.Add("@uniqueID", SqlDbType.NVarChar).Value = specialCounter;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = columnData[indexCounter];
                            command.ExecuteNonQuery();
                            connection.Close();

                            indexCounter++;
                            specialCounter++;
                        }
                    }
                }

                return Content("Refresh");
            }
            else
            {
                return Content("Błąd po stronie servera, zawołaj DevOpsa");
            }
        }

        /// <summary>
        /// Butle z powietrzem
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Butle()
        {
            return View(butle());
        }

        /// <summary>
        /// POST/DELETE/UPDATE request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Butle(NewObjectModel ObjectModel)
        {
            NewObjectModel model = new NewObjectModel
            {
                UniqueID = ObjectModel.UniqueID,
                RequestType = ObjectModel.RequestType
            };
            if (model.RequestType == "POST")
            {
                if (model.UniqueID == "1")
                {
                    return View("Butle_1ViewModel");
                }
                else if (model.UniqueID == "2")
                {
                    return View("Butle_2ViewModel");
                }
                else if (model.UniqueID == "3")
                {
                    return View("Butle_3ViewModel");
                }
                else if (model.UniqueID == "4")
                {
                    return View("Butle_4ViewModel");
                }
                else
                {
                    return View("Index");
                }
            }
            else if (model.RequestType == "DELETE")
            {
                //HANDLE DELETE PART
                string DelID = model.UniqueID;
                //Funkcja usuwająca zamknięta w stringu
                string delfunc = "DELETE FROM dbo.Butle WHERE UniqueID = @UniqueID";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    //Usuwanko
                    using (SqlCommand cmdDelete = new SqlCommand(delfunc, thisConnection))
                    {
                        thisConnection.Open();
                        cmdDelete.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = DelID;
                        cmdDelete.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }

                //Tworzenie lokalnej listy z ID dla danej tabeli w celu aktualizacji po usunięciu
                List<int> columnData = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID FROM dbo.Butle";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(Int32.Parse(reader[0].ToString()));
                            }
                        }
                    }
                    connection.Close();
                }

                //HANDLE UPDATE PART
                int specialCounter = 1;
                int indexCounter = 0;
                int Ilosc = ButleCount();
                //Funkcja akrualizująca dane
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string upfunc = "UPDATE dbo.Butle SET UniqueID = @uniqueID WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(upfunc, connection))
                    {
                        while (specialCounter <= Ilosc)
                        {
                            connection.Open();
                            command.Parameters.Clear();
                            command.Parameters.Add("@uniqueID", SqlDbType.NVarChar).Value = specialCounter;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = columnData[indexCounter];
                            command.ExecuteNonQuery();
                            connection.Close();

                            specialCounter++;
                            indexCounter++;
                        }
                    }
                }

                return Content("Refresh");
            }
            else
            {
                return Content("Błąd po stronie servera, zawołaj DevOpsa");
            }
        }

        /// <summary>
        /// Kamizelki do nurkowania
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Kamizelki()
        {
            return View(kamizelki());
        }

        /// <summary>
        /// POST/DELETE/UPDATE request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Kamizelki(NewObjectModel ObjectModel)
        {
            NewObjectModel model = new NewObjectModel
            {
                UniqueID = ObjectModel.UniqueID,
                RequestType = ObjectModel.RequestType
            };
            if (model.RequestType == "POST")
            {
                if (model.UniqueID == "1")
                {
                    return View("Kamizelki_1ViewModel");
                }
                else if (model.UniqueID == "2")
                {
                    return View("Kamizelki_2ViewModel");
                }
                else if (model.UniqueID == "3")
                {
                    return View("Kamizelki_3ViewModel");
                }
                else
                {
                    return View("Index");
                }
            }
            else if (model.RequestType == "DELETE")
            {
                //HANDLE DELETE PART
                string DelID = model.UniqueID;
                //Funkcja usuwająca zamknięta w stringu
                string delfunc = "DELETE FROM dbo.Kamizelki WHERE UniqueID = @UniqueID";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    //Usuwanko
                    using (SqlCommand cmdDelete = new SqlCommand(delfunc, thisConnection))
                    {
                        thisConnection.Open();
                        cmdDelete.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = DelID;
                        cmdDelete.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }

                //Tworzenie lokalnej listy z ID dla danej tabeli w celu aktualizacji po usunięciu
                List<int> columnData = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID FROM dbo.Kamizelki";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(Int32.Parse(reader[0].ToString()));
                            }
                        }
                    }
                    connection.Close();
                }

                //HANDLE UPDATE PART
                int specialCounter = 1;
                int indexCounter = 0;
                int Ilosc = KamizelkiCount();
                //Funkcja akrualizująca dane
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string upfunc = "UPDATE dbo.Kamizelki SET UniqueID = @uniqueID WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(upfunc, connection))
                    {
                        while (specialCounter <= Ilosc)
                        {
                            connection.Open();
                            command.Parameters.Clear();
                            command.Parameters.Add("@uniqueID", SqlDbType.NVarChar).Value = specialCounter;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = columnData[indexCounter];
                            command.ExecuteNonQuery();
                            connection.Close();

                            specialCounter++;
                            indexCounter++;
                        }
                    }
                }

                return Content("Refresh");
            }
            else
            {
                return Content("Błąd po stronie servera, zawołaj DevOpsa");
            }
        }

        /// <summary>
        /// Skafandry do nurkowania
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Skafandry()
        {
            return View(skafandry());
        }

        /// <summary>
        /// POST/DELETE/UPDATE request dla strony
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Skafandry(NewObjectModel ObjectModel)
        {
            NewObjectModel model = new NewObjectModel
            {
                UniqueID = ObjectModel.UniqueID,
                RequestType = ObjectModel.RequestType
            };
            if (model.RequestType == "POST")
            {
                if (model.UniqueID == "1")
                {
                    return View("Skafandry_1ViewModel");
                }
                else if (model.UniqueID == "2")
                {
                    return View("Skafandry_2ViewModel");
                }
                else if (model.UniqueID == "3")
                {
                    return View("Skafandry_3ViewModel");
                }
                else
                {
                    return View("Index");
                }
            }
            else if (model.RequestType == "DELETE")
            {
                //HANDLE DELETE PART
                string DelID = model.UniqueID;
                //Funkcja usuwająca zamknięta w stringu
                string delfunc = "DELETE FROM dbo.Skafandry WHERE UniqueID = @UniqueID";
                using (SqlConnection thisConnection = new SqlConnection(connectionString))
                {
                    //Usuwanko
                    using (SqlCommand cmdDelete = new SqlCommand(delfunc, thisConnection))
                    {
                        thisConnection.Open();
                        cmdDelete.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = DelID;
                        cmdDelete.ExecuteNonQuery();
                        thisConnection.Close();
                    }
                }

                //Tworzenie lokalnej listy z ID dla danej tabeli w celu aktualizacji po usunięciu
                List<int> columnData = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID FROM dbo.Skafandry";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(Int32.Parse(reader[0].ToString()));
                            }
                        }
                    }
                    connection.Close();
                }

                //HANDLE UPDATE PART
                int specialCounter = 1;
                int indexCounter = 0;
                int Ilosc = SkafandryCount();
                //Funkcja akrualizująca dane
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string upfunc = "UPDATE dbo.Skafandry SET UniqueID = @uniqueID WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(upfunc, connection))
                    {
                        while (specialCounter <= Ilosc)
                        {
                            connection.Open();
                            command.Parameters.Clear();
                            command.Parameters.Add("@uniqueID", SqlDbType.NVarChar).Value = specialCounter;
                            command.Parameters.Add("@ID", SqlDbType.Int).Value = columnData[indexCounter];
                            command.ExecuteNonQuery();
                            connection.Close();

                            specialCounter++;
                            indexCounter++;
                        }
                    }
                }

                return Content("Refresh");
            }
            else
            {
                return Content("Błąd po stronie servera, zawołaj DevOpsa");
            }
        }

        /// <summary>
        /// Stworzenie formy do utworzenia nowego przedmiotu przez użytkownika
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Nowy()
        {
            return View();
        }

        /// <summary>
        /// Długość stringa
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Wysłanie nowego obiektu do bazy danych
        /// </summary>
        /// <param name="NewObject"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Nowy(NewObjectModel NewObject)
        {
            //Sprawdzamy czy Cena jest wartością liczbową, jak nie to wyrzuci odpowiedni widok
            string cena = NewObject.Price.ToString();
            decimal value;
            Decimal.TryParse(cena, out value);
            if (value != 0 && value >= 1 && cena.Length <= 17)
            {
                //Sprawdzamy rodzaj dodawanego przedmiotu i wybieramy odpowiednią tabelę w bazie danych dla niego
                if (NewObject.Type == "Automat oddechowy")
                {
                    //Tworzymy wartość uniqueid, gdyż użytkownikowi nie można ufać pod tym względem
                    int uniqueid = AutomatyCount() + 1;
                    NewObject.UniqueID = uniqueid.ToString();
                    using (var connection = new SqlConnection(connectionString))
                    using (var command = connection.CreateCommand())
                    {
                        //Otwieramy połączenie
                        connection.Open();
                        //Wybieramy cel
                        command.CommandText = @"INSERT INTO AutomatyOddechowe(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID);
                        INSERT INTO UserActivity(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID)";
                        //Dodadjemy dane
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NewObject.Name;
                        command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = NewObject.Type;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = NewObject.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = value;
                        command.Parameters.Add("@Photo", SqlDbType.NVarChar).Value = NewObject.Photo;
                        command.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = NewObject.UniqueID;
                        //"Odpalamy"
                        command.ExecuteNonQuery();
                        //Zamykamy połączenie
                        connection.Close();
                        return View("NewObjectSuccess");
                    }
                }
                //Sprawdzamy rodzaj dodawanego przedmiotu i wybieramy odpowiednią tabelę w bazie danych dla niego
                else if (NewObject.Type == "Boja")
                {
                    //Tworzymy wartość uniqueid, gdyż użytkownikowi nie można ufać pod tym względem
                    int uniqueid = BojeCount() + 1;
                    NewObject.UniqueID = uniqueid.ToString();
                    using (var connection = new SqlConnection(connectionString))
                    using (var command = connection.CreateCommand())
                    {
                        //Otwieramy połączenie
                        connection.Open();
                        //Wybieramy cel
                        command.CommandText = @"INSERT INTO Boje(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID);
                        INSERT INTO UserActivity(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID)";
                        //Dodadjemy dane
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NewObject.Name;
                        command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = NewObject.Type;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = NewObject.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = value;
                        command.Parameters.Add("@Photo", SqlDbType.NVarChar).Value = NewObject.Photo;
                        command.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = NewObject.UniqueID;
                        //"Odpalamy"
                        command.ExecuteNonQuery();
                        //Zamykamy połączenie
                        connection.Close();
                        return View("NewObjectSuccess");
                    }
                }
                //Sprawdzamy rodzaj dodawanego przedmiotu i wybieramy odpowiednią tabelę w bazie danych dla niego
                else if (NewObject.Type == "Butla")
                {
                    //Tworzymy wartość uniqueid, gdyż użytkownikowi nie można ufać pod tym względem
                    int uniqueid = ButleCount() + 1;
                    NewObject.UniqueID = uniqueid.ToString();
                    using (var connection = new SqlConnection(connectionString))
                    using (var command = connection.CreateCommand())
                    {
                        //Otwieramy połączenie
                        connection.Open();
                        //Wybieramy cel
                        command.CommandText = @"INSERT INTO Butle(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID);
                        INSERT INTO UserActivity(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID)";
                        //Dodadjemy dane
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NewObject.Name;
                        command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = NewObject.Type;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = NewObject.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = value;
                        command.Parameters.Add("@Photo", SqlDbType.NVarChar).Value = NewObject.Photo;
                        command.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = NewObject.UniqueID;
                        //"Odpalamy"
                        command.ExecuteNonQuery();
                        //Zamykamy połączenie
                        connection.Close();
                        return View("NewObjectSuccess");
                    }
                }
                //Sprawdzamy rodzaj dodawanego przedmiotu i wybieramy odpowiednią tabelę w bazie danych dla niego
                else if (NewObject.Type == "Jacket")
                {
                    //Tworzymy wartość uniqueid, gdyż użytkownikowi nie można ufać pod tym względem
                    int uniqueid = KamizelkiCount() + 1;
                    NewObject.UniqueID = uniqueid.ToString();
                    using (var connection = new SqlConnection(connectionString))
                    using (var command = connection.CreateCommand())
                    {
                        //Otwieramy połączenie
                        connection.Open();
                        //Wybieramy cel
                        command.CommandText = @"INSERT INTO Kamizelki(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID);
                        INSERT INTO UserActivity(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID)";
                        //Dodadjemy dane
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NewObject.Name;
                        command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = NewObject.Type;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = NewObject.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = value;
                        command.Parameters.Add("@Photo", SqlDbType.NVarChar).Value = NewObject.Photo;
                        command.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = NewObject.UniqueID;
                        //"Odpalamy"
                        command.ExecuteNonQuery();
                        //Zamykamy połączenie
                        connection.Close();
                        return View("NewObjectSuccess");
                    }
                }
                //Sprawdzamy rodzaj dodawanego przedmiotu i wybieramy odpowiednią tabelę w bazie danych dla niego
                else if (NewObject.Type == "Skafander")
                {
                    //Tworzymy wartość uniqueid, gdyż użytkownikowi nie można ufać pod tym względem
                    int uniqueid = SkafandryCount() + 1;
                    NewObject.UniqueID = uniqueid.ToString();
                    using (var connection = new SqlConnection(connectionString))
                    using (var command = connection.CreateCommand())
                    {
                        //Otwieramy połączenie
                        connection.Open();
                        //Wybieramy cel
                        command.CommandText = @"INSERT INTO Skafandry(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID);
                        INSERT INTO UserActivity(Name, Type, Description, Price, Photo, UniqueID) values (@Name, @Type, @Description, @Price, @Photo, @UniqueID)";
                        //Dodadjemy dane
                        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NewObject.Name;
                        command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = NewObject.Type;
                        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = NewObject.Description;
                        command.Parameters.Add("@Price", SqlDbType.Decimal).Value = value;
                        command.Parameters.Add("@Photo", SqlDbType.NVarChar).Value = NewObject.Photo;
                        command.Parameters.Add("@UniqueID", SqlDbType.NVarChar).Value = NewObject.UniqueID;
                        //"Odpalamy"
                        command.ExecuteNonQuery();
                        //Zamykamy połączenie
                        connection.Close();
                        return View("NewObjectSuccess");
                    }
                }
                else
                {
                    return View("NewObjectFailed");
                }
            }
            else
            {
                return View("NewObjectFailed");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });            
        }
    }
}
