namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.DoiBongDBContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.DoiBongDBContex context)
        {
            context.eTeams.Add(new Entity.eTeam()
            {
                maDoiBong = "d1",
                tenDoiBong = "Hoang Anh Gia Lai"
            }
            );
            context.eTeams.Add(new Entity.eTeam()
            {
                maDoiBong = "d2",
                tenDoiBong = "Song Lam Nghe An"
            }
            );
            context.eTeams.Add(new Entity.eTeam()
            {
                maDoiBong = "d3",
                tenDoiBong = "CLB Ha Noi"
            }
            );

            context.ePlayers.Add(new Entity.ePlayer()
            {
                maCauThu = "so1",
                tenCauThu = "Duy Tan",
                email = "khong co",
                soDT = "khong cho",
                maDoiBong = "d1"
            });
            context.ePlayers.Add(new Entity.ePlayer()
            {
                maCauThu = "so2",
                tenCauThu = "Duy Tien",
                email = "khong co",
                soDT = "khong cho",
                maDoiBong = "d2"
            });
            context.ePlayers.Add(new Entity.ePlayer()
            {
                maCauThu = "so3",
                tenCauThu = "Duy Tan A",
                email = "khong co",
                soDT = "khong cho",
                maDoiBong = "d3"
            });
            context.ePlayers.Add(new Entity.ePlayer()
            {
                maCauThu = "so4",
                tenCauThu = "Duy Tan B",
                email = "khong co",
                soDT = "khong cho",
                maDoiBong = "d1"
            });
        }
    }
}
