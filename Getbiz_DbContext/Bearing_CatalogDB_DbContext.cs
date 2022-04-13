using bearing_catalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bearing_catalog.Getbiz_DbContext
{
    public class Bearing_CatalogDB_DbContext : DbContext
    {
        public Bearing_CatalogDB_DbContext(DbContextOptions<Bearing_CatalogDB_DbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public virtual DbSet<adapterassembliesshperical> adapterassembliesshperical { set; get; }
        public virtual DbSet<adapterassemlies> adapterassemlies { set; get; }
        public virtual DbSet<combinedneedlemetricseries> combinedneedlemetricseries { set; get; }
        public virtual DbSet<combinedneedlemetricseries2> combinedneedlemetricseries2 { set; get; }
        public virtual DbSet<doubledirectionthrust> doubledirectionthrust { set; get; }
        public virtual DbSet<doublerowcontactball> doublerowcontactball { set; get; }
        public virtual DbSet<doublerowcylidrical> doublerowcylidrical { set; get; }
        public virtual DbSet<doublerowdeepgroove> doublerowdeepgroove { set; get; }
        public virtual DbSet<drawcupneedleinchseries> drawcupneedleinchseries { set; get; }
        public virtual DbSet<drawcupneedlemetricseries> drawcupneedlemetricseries { set; get; }


        // 10 /////////////////////////////////////////////////////////////////////////////////////////////////

        public virtual DbSet<extendedinnerringtype> extendedinnerringtype { set; get; }
        public virtual DbSet<extrasmallminiatureballbearings> extrasmallminiatureballbearings { set; get; }
        public virtual DbSet<flangedtype> flangedtype { set; get; }

        public virtual DbSet<heavydutyneedleinchseries> heavydutyneedleinchseries { set; get; }
        public virtual DbSet<heavydutyneedleinnerrings> heavydutyneedleinnerrings { set; get; }
        public virtual DbSet<heavydutyneedlemetricseries> heavydutyneedlemetricseries { set; get; }
        public virtual DbSet<matchedpair> matchedpair { set; get; }
        public virtual DbSet<miniatureonewayclutches> miniatureonewayclutches { set; get; }
        public virtual DbSet<needlerollermetricseries> needlerollermetricseries { set; get; }
        public virtual DbSet<needlerollermetricseries2> needlerollermetricseries2 { set; get; }



        // 20/////////////////////////////////////////////////////////////////////////////////////////////////


        public virtual DbSet<needlerollerthrustinchseries> needlerollerthrustinchseries { set; get; }
        public virtual DbSet<needlerollerthrustmetricseries> needlerollerthrustmetricseries { set; get; }
        public virtual DbSet<needlerollerthrustmetricseries2> needlerollerthrustmetricseries2 { set; get; }
        public virtual DbSet<radialneedleinchseries> radialneedleinchseries { set; get; }
        public virtual DbSet<radialneedlemetricseries> radialneedlemetricseries { set; get; }
        public virtual DbSet<selfaligningopentype> selfaligningopentype { set; get; }
        public virtual DbSet<selfaligningsealedtype> selfaligningsealedtype { set; get; }
        public virtual DbSet<serialnoindex> serialnoindex { set; get; }
        public virtual DbSet<singledirctionthrust> singledirctionthrust { set; get; }
        public virtual DbSet<singlerowcontactball> singlerowcontactball { set; get; }

        // 30/////////////////////////////////////////////////////////////////////////////////////////////////


        public virtual DbSet<singlerowcylindrical> singlerowcylindrical { set; get; }
        public virtual DbSet<singlerowinchseries> singlerowinchseries { set; get; }
        public virtual DbSet<singlerowmetricseries> singlerowmetricseries { set; get; }
        public virtual DbSet<singlerowopentype> singlerowopentype { set; get; }
        public virtual DbSet<singlerowsealedtype> singlerowsealedtype { set; get; }
        public virtual DbSet<singlerowsnapringgroovetype> singlerowsnapringgroovetype { set; get; }
        public virtual DbSet<sphericalrollerbearings> sphericalrollerbearings { set; get; }
        public virtual DbSet<tditype> tditype { set; get; }
        public virtual DbSet<tdotype> tdotype { set; get; }
        public virtual DbSet<thrustcollars> thrustcollars { set; get; }

        // 40/////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual DbSet<withdrawalsleeves> withdrawalsleeves { set; get; }
        public virtual DbSet<sphericalthrustroller> sphericalthrustroller { set; get; }
        public virtual DbSet<user_registeration> user_registeration { set; get; }

    }
}
