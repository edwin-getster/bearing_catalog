    using bearing_catalog.Getbiz_DbContext;
using bearing_catalog.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Repository
{
    public class BearingCatalogRepository : IBearingCatalogRepository
    {

        public readonly Bearing_CatalogDB_DbContext _DbContext;
        public BearingCatalogRepository(Bearing_CatalogDB_DbContext DbContext)
        {
            _DbContext = DbContext;
        }


        public Response GetAdapterassembliesshperical()
            {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.adapterassembliesshperical.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Adapter Assemblies Spherical";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            
            return response;
        }

        public Response GetAdapterassemlies()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.adapterassemlies.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Adapter Assemblies";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetCombinedneedlemetricseries()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.combinedneedlemetricseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Combined Needle Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetCombinedneedlemetricseries2()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.combinedneedlemetricseries2.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Combined Needle Metric Series 2";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetDoubledirectionthrust()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.doubledirectionthrust.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Double Direction Thrust";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetDoublerowcontactball()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.doublerowcontactball.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Double Row Contact Ball";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetDoublerowcylidrical()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.doublerowcylidrical.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Double Row Cylindrical";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetDoublerowdeepgroove()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.doublerowdeepgroove.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Double Row Deep Groove";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetDrawcupneedleinchseries()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.drawcupneedleinchseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Draw Cup needle Inch Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        public Response GetDrawcupneedlemetricseries()
        {

            Response response = new Response();
            try
            {
                response.Data = _DbContext.drawcupneedlemetricseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Draw Cup Needle Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        // 10 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public Response GetExtendedinnerringtype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.extendedinnerringtype.ToList();
                response.Message = "Data Fetch successfully !!";
                response.Message = "Extended Inner Ring Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetExtrasmallminiatureballbearings()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.extrasmallminiatureballbearings.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Extra Small Miniature Ball Bearings";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetFlangedtype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.flangedtype.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Flanged Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }




        public Response GetHeavydutyneedleinchseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.heavydutyneedleinchseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Heavy Duty Needle Inch Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetHeavydutyneedleinnerrings()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.heavydutyneedleinnerrings.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Heavy Duty Needle Inner Rings";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }




        public Response GetHeavydutyneedlemetricseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.heavydutyneedlemetricseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Heavy Duty Needle Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetMatchedpair()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.matchedpair.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Matched Pair";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }




        public Response GetMiniatureonewayclutches()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.miniatureonewayclutches.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Miniature One Way Clutches";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetNeedlerollermetricseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.needlerollermetricseries.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Needle Roller Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetNeedlerollermetricseries2()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.needlerollermetricseries2.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Needle Roller Metric Series 2";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        // 20/////////////////////////////////////////////////////////////////////////////////////////////////




        public Response GetNeedlerollerthrustinchseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.needlerollerthrustinchseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Needle Roller Thrust Inch Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }




        public Response GetNeedlerollerthrustmetricseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.needlerollerthrustmetricseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Needle Roller Thrust Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetNeedlerollerthrustmetricseries2()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.needlerollerthrustmetricseries2.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Needle Roller Thrust Metric Series 2";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetRadialneedleinchseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.radialneedleinchseries.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Radial Needle Inch Series";
                response.Status = true;  
            }
            catch (Exception ex)
            {  
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetRadialneedlemetricseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.radialneedlemetricseries.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Radial Needle Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetSelfaligningopentype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.selfaligningopentype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Self Aligning Open Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSelfaligningsealedtype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.selfaligningsealedtype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Self Aligning Sealed Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetSerialnoindex()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.serialnoindex.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Serial No Index";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSingledirctionthrust()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singledirctionthrust.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Direction Thrust";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetSinglerowcontactball()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowcontactball.ToList();

                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Contact Ball";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }

        // 30/////////////////////////////////////////////////////////////////////////////////////////////////


        public Response GetSinglerowcylindrical()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowcylindrical.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Cylindrical";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response Getsinglerowinchseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowinchseries.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Inch Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSinglerowmetricseries()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowmetricseries.ToList();
                response.Message = "Data Fetch successfully !!";
                response.TableName = "Single Row Metric Series";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetSinglerowopentype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowopentype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Open Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSinglerowsealedtype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowsealedtype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Sealed Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSinglerowsnapringgroovetype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.singlerowsnapringgroovetype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Single Row Snap Ring Groove Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetSphericalrollerbearings()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.sphericalrollerbearings.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Spherical Roller Bearings";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetTditype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.tditype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Tdi Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        public Response GetTdotype()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.tdotype.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Tdo Type";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response GetThrustcollars()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.thrustcollars.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Thrust Collars";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }


        // 40/////////////////////////////////////////////////////////////////////////////////////////////////


        public Response GetWithdrawalsleeves()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.withdrawalsleeves.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Withdrawal Sleeves";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }



        public Response Getsphericalthrustroller()
        {
            Response response = new Response();
            try
            {
                response.Data = _DbContext.sphericalthrustroller.ToList();
                response.Message = "Data Fetch Successfully !!";
                response.TableName = "Spherical Thrust Roller";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Message = "Error, while fetching the data !!";
                response.Status = false;
            }
            return response;
        }






















    }




}
