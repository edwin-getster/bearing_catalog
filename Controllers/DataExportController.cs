using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class DataExportController : ControllerBase
    {
        [HttpGet]
        [Route("api/DataExport")]
        public IActionResult DataExport(string TableName)

        {
            //string connection = "Server=localhost;User ID=root;Password=mysql;Database=chatbroadcastappdb; Allow User Variables=true";
            string connection = "Server=185.252.235.20;User ID=root;Password=GetBizMysqlDatabasePwd2021@;Database=bearingcatalogdb; Allow User Variables=true";

            try
            {

                using (XLWorkbook wb = new XLWorkbook())
                {
                    DataTable dt = GetDbData().Tables[0];
                    wb.Worksheets.Add(dt);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", TableName+" "+"Bearing Catalog.xlsx");
                    }
                }




                DataSet GetDbData()
                {
                    DataSet ds = new DataSet();

                    // get Adapter Assemblies Spherical
                    if (TableName == "Adapter Assemblies Spherical")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.adapterassembliesshperical;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }



                    }
                    // Adapter Assemblies

                    if (TableName == "Adapter Assemblies")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.adapterassemlies;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    // Combined Needle Metric Series

                    if (TableName == "Combined Needle Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.combinedneedlemetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    // Combined Needle Metric Series 2

                    if (TableName == "Combined Needle Metric Series 2")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.combinedneedlemetricseries2;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }



                    //Double Direction Thrust

                    if (TableName == "Double Direction Thrust")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.doubledirectionthrust;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }




                    //Double Row Contact Ball

                    if (TableName == "Double Row Contact Ball")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.doublerowcontactball;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Double Row Cylindrical

                    if (TableName == "Double Row Cylindrical")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.doublerowcylidrical;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Double Row Deep Groove

                    if (TableName == "Double Row Deep Groove")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.doublerowdeepgroove;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Draw Cup needle Inch Series
                    if (TableName == "Draw Cup needle Inch Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.drawcupneedleinchseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Draw Cup Needle Metric Series
                    if (TableName == "Draw Cup Needle Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.drawcupneedlemetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Extended Inner Ring Type
                    if (TableName == "Extended Inner Ring Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.extendedinnerringtype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    // Extra Small Miniature Ball Bearings
                    if (TableName == "Extended Inner Ring Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.extrasmallminiatureballbearings;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    // Flanged Type
                    if (TableName == "Flanged Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.flangedtype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    // Heavy Duty Needle Inch Series
                    if (TableName == "Heavy Duty Needle Inch Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.heavydutyneedleinchseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }



                    //Heavy Duty Needle Inner Rings
                    if (TableName == "Heavy Duty Needle Inner Rings")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.heavydutyneedleinnerrings;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Heavy Duty Needle Metric Series
                    if (TableName == "Heavy Duty Needle Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.heavydutyneedlemetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }


                    }


                    //Matched Pair
                    if (TableName == "Matched Pair")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.matchedpair;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Miniature One Way Clutches
                    if (TableName == "Miniature One Way Clutches")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.miniatureonewayclutches;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Needle Roller Metric Series
                    if (TableName == "Needle Roller Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.needlerollermetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Needle Roller Metric Series 2
                    if (TableName == "Needle Roller Metric Series 2")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.needlerollermetricseries2;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Needle Roller Thrust Inch Series
                    if (TableName == "Needle Roller Thrust Inch Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.needlerollerthrustinchseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Needle Roller Thrust Metric Series
                    if (TableName == "Needle Roller Thrust Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.needlerollerthrustmetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Needle Roller Thrust Metric Series 2
                    if (TableName == "Needle Roller Thrust Metric Series 2")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.needlerollerthrustmetricseries2;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Radial Needle Inch Series
                    if (TableName == "Radial Needle Inch Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.radialneedleinchseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Radial Needle Metric Series
                    if (TableName == "Radial Needle Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.radialneedlemetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Self Aligning Open Type
                    if (TableName == "Self Aligning Open Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.selfaligningopentype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Self Aligning Sealed Type
                    if (TableName == "Self Aligning Sealed Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.selfaligningsealedtype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Serial No Index
                    if (TableName == "Serial No Index")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.serialnoindex;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Single Direction Thrust
                    if (TableName == "Single Direction Thrust")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singledirctionthrust;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Single Row Contact Ball
                    if (TableName == "Single Row Contact Ball")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowcontactball;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Single Row Cylindrical
                    if (TableName == "Single Row Cylindrical")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowcylindrical;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Single Row Inch Series
                    if (TableName == "Single Row Inch Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowinchseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Single Row Metric Series
                    if (TableName == "Single Row Metric Series")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowmetricseries;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    //Single Row Open Type
                    if (TableName == "Single Row Open Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowopentype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Single Row Sealed Type
                    if (TableName == "Single Row Sealed Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowsealedtype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }




                    //Single Row Snap Ring Groove Type
                    if (TableName == "Single Row Snap Ring Groove Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.singlerowsnapringgroovetype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Spherical Roller Bearings
                    if (TableName == "Spherical Roller Bearings")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.sphericalrollerbearings;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Spherical Thrust Roller
                    if (TableName == "Spherical Thrust Roller")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.sphericalthrustroller;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Tdi Type
                    if (TableName == "Tdi Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.tditype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Tdo Type
                    if (TableName == "Tdo Type")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.tdotype;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Thrust Collars
                    if (TableName == "Thrust Collars")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.thrustcollars;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }


                    //Withdrawal Sleeves
                    if (TableName == "Withdrawal Sleeves")
                    {
                        using (MySqlConnection con = new MySqlConnection(connection))
                        {
                            string query = "SELECT * FROM bearingcatalogdb.withdrawalsleeves;";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                                {
                                    sda.Fill(ds);
                                }
                            }
                        }

                    }

                    return ds;
                }
           
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


    }
}
