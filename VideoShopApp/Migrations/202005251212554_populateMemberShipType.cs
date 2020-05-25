namespace VideoShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class populateMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MemberShipTypes ON");
            Sql("INSERT into MemberShipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT into MemberShipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (2,30,1,10)");
            Sql("INSERT into MemberShipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (3,90,3,15)");
            Sql("INSERT into MemberShipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
