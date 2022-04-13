using bearing_catalog.Getbiz_DbContext;
using bearing_catalog.Models;
using bearing_catalog.Repository;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Controllers
{
    [Authorize]
    //[Route("api/[controller]")]
    [ApiController]
  
    public class BearingCatalogController : ControllerBase
    {
        private readonly IBearingCatalogRepository _bearingCatalogRepository;
     
        public readonly Bearing_CatalogDB_DbContext _DbContext;
        public BearingCatalogController(IBearingCatalogRepository bearingCatalogRepository, Bearing_CatalogDB_DbContext dbContext)
        {
            _bearingCatalogRepository = bearingCatalogRepository;
            _DbContext = dbContext;
        }



        
        [HttpGet]
        [Route("api/GetAdapterassembliesshperical")]
        public IActionResult GetAdapterassembliesshperical()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetAdapterassembliesshperical();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }




        [HttpGet]  
        [Route("api/GetAdapterassemlies")]
        public IActionResult GetAdapterassemlies()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetAdapterassemlies();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/GetCombinedneedlemetricseries")]
        public IActionResult GetCombinedneedlemetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetCombinedneedlemetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetCombinedneedlemetricseries2")]
        public IActionResult GetCombinedneedlemetricseries2()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetCombinedneedlemetricseries2();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetDoubledirectionthrust")]
        public IActionResult GetDoubledirectionthrust()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDoubledirectionthrust();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetDoublerowcontactball")]
        public IActionResult GetDoublerowcontactball()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDoublerowcontactball();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

      
        [HttpGet]
        [Route("api/GetDoublerowcylidrical")]
        public IActionResult GetDoublerowcylidrical()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDoublerowcylidrical();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


  
        [HttpGet]
        [Route("api/GetDoublerowdeepgroove")]
        public IActionResult GetDoublerowdeepgroove()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDoublerowdeepgroove();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



       
        [HttpGet]
        [Route("api/GetDrawcupneedleinchseries")]
        public IActionResult GetDrawcupneedleinchseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDrawcupneedleinchseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetDrawcupneedlemetricseries")]
        public IActionResult GetDrawcupneedlemetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetDrawcupneedlemetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        [HttpGet]
        [Route("api/GetExtendedinnerringtype")]
        public IActionResult GetExtendedinnerringtype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetExtendedinnerringtype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


      
        [HttpGet]
        [Route("api/GetExtrasmallminiatureballbearings")]
        public IActionResult GetExtrasmallminiatureballbearings()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetExtrasmallminiatureballbearings();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetFlangedtype")]
        public IActionResult GetFlangedtype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetFlangedtype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/GetHeavydutyneedleinchseries")]
        public IActionResult GetHeavydutyneedleinchseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetHeavydutyneedleinchseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetHeavydutyneedleinnerrings")]
        public IActionResult GetHeavydutyneedleinnerrings()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetHeavydutyneedleinnerrings();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetHeavydutyneedlemetricseries")]
        public IActionResult GetHeavydutyneedlemetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetHeavydutyneedlemetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetMatchedpair")]
        public IActionResult GetMatchedpair()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetMatchedpair();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


      
        [HttpGet]
        [Route("api/GetMiniatureonewayclutches")]
        public IActionResult GetMiniatureonewayclutches()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetMiniatureonewayclutches();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetNeedlerollermetricseries")]
        public IActionResult GetNeedlerollermetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetNeedlerollermetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetNeedlerollermetricseries2")]
        public IActionResult GetNeedlerollermetricseries2()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetNeedlerollermetricseries2();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        //20 /////////////////////////////////////////////////////////////////////////////////////////////////



        [HttpGet]
        [Route("api/GetNeedlerollerthrustinchseries")]
        public IActionResult GetNeedlerollerthrustinchseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetNeedlerollerthrustinchseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }






        [HttpGet]
        [Route("api/GetNeedlerollerthrustmetricseries")]
        public IActionResult GetNeedlerollerthrustmetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetNeedlerollerthrustmetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }




        [HttpGet]
        [Route("api/GetNeedlerollerthrustmetricseries2")]
        public IActionResult GetNeedlerollerthrustmetricseries2()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetNeedlerollerthrustmetricseries2();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetRadialneedleinchseries")]
        public IActionResult GetRadialneedleinchseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetRadialneedleinchseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetRadialneedlemetricseries")]
        public IActionResult GetRadialneedlemetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetRadialneedlemetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetSelfaligningopentype")]
        public IActionResult GetSelfaligningopentype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSelfaligningopentype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetSelfaligningsealedtype")]
        public IActionResult GetSelfaligningsealedtype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSelfaligningsealedtype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [AllowAnonymous]
        [HttpGet]
        [Route("api/GetSerialnoindex")]
        public IActionResult GetSerialnoindex()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSerialnoindex();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }





        [HttpGet]
        [Route("api/GetSingledirctionthrust")]
        public IActionResult GetSingledirctionthrust()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSingledirctionthrust();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetSinglerowcontactball")]
        public IActionResult GetSinglerowcontactball()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowcontactball();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        // 30/////////////////////////////////////////////////////////////////////////////////////////////////


        [HttpGet]
        [Route("api/GetSinglerowcylindrical")]
        public IActionResult GetSinglerowcylindrical()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowcylindrical();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Getsinglerowinchseries")]
        public IActionResult Getsinglerowinchseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.Getsinglerowinchseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


 
        [HttpGet]
        [Route("api/GetSinglerowmetricseries")]
        public IActionResult GetSinglerowmetricseries()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowmetricseries();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetSinglerowopentype")]
        public IActionResult GetSinglerowopentype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowopentype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


      
        [HttpGet]
        [Route("api/GetSinglerowsealedtype")]
        public IActionResult GetSinglerowsealedtype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowsealedtype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetSinglerowsnapringgroovetype")]
        public IActionResult GetSinglerowsnapringgroovetype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSinglerowsnapringgroovetype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        
        [HttpGet]
        [Route("api/GetSphericalrollerbearings")]
        public IActionResult GetSphericalrollerbearings()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetSphericalrollerbearings();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetTditype")]
        public IActionResult GetTditype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetTditype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        [Route("api/GetTdotype")]
        public IActionResult GetTdotype()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetTdotype();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetThrustcollars")]
        public IActionResult GetThrustcollars()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetThrustcollars();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // 40 /////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        [Route("api/GetWithdrawalsleeves")]
        public IActionResult GetWithdrawalsleeves()
        {
            try
            {
                var messages = _bearingCatalogRepository.GetWithdrawalsleeves();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/GetGetsphericalthrustroller")]
        public IActionResult Getsphericalthrustroller()
        {
            try
            {
                var messages = _bearingCatalogRepository.Getsphericalthrustroller();
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
