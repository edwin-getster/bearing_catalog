using bearing_catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Repository
{
    public interface IBearingCatalogRepository
    {

        Response GetAdapterassembliesshperical();
        Response GetAdapterassemlies();
        Response GetCombinedneedlemetricseries();
        Response GetCombinedneedlemetricseries2();
        Response GetDoubledirectionthrust();
        Response GetDoublerowcontactball();
        Response GetDoublerowcylidrical();
        Response GetDoublerowdeepgroove();
        Response GetDrawcupneedleinchseries();
        Response GetDrawcupneedlemetricseries();


        // 10/////////////////////////////////////////////////////////////////////////////////////
        Response GetExtendedinnerringtype();
        Response GetExtrasmallminiatureballbearings();
        Response GetFlangedtype();
        Response GetHeavydutyneedleinchseries();
        Response GetHeavydutyneedleinnerrings();
        Response GetHeavydutyneedlemetricseries();
        Response GetMatchedpair();
        Response GetMiniatureonewayclutches();
        Response GetNeedlerollermetricseries();
        Response GetNeedlerollermetricseries2();



        // 20/////////////////////////////////////////////////////////////////////////////////////////////////

        Response GetNeedlerollerthrustinchseries();
        Response GetNeedlerollerthrustmetricseries();
        Response GetNeedlerollerthrustmetricseries2();
        Response GetRadialneedleinchseries();
        Response GetRadialneedlemetricseries();
        Response GetSelfaligningopentype();
        Response GetSelfaligningsealedtype();
        Response GetSerialnoindex();
        Response GetSingledirctionthrust();
        Response GetSinglerowcontactball();

        // 30/////////////////////////////////////////////////////////////////////////////////////////////////


        Response GetSinglerowcylindrical();
        Response Getsinglerowinchseries();
        Response GetSinglerowmetricseries();
        Response GetSinglerowopentype();
        Response GetSinglerowsealedtype();
        Response GetSinglerowsnapringgroovetype();
        Response GetSphericalrollerbearings();
        Response GetTditype();
        Response GetTdotype();
        Response GetThrustcollars();
        // 40/////////////////////////////////////////////////////////////////////////////////////////////////
        Response GetWithdrawalsleeves();
        Response Getsphericalthrustroller();



    }
}
