using lab21.Model;
using lab21.Model.TariffPlans;
using lab21.Utils;
using lab21.Utils.Factories;
using lab21.View;
using System.Collections.Generic;
using System.Diagnostics;

// TODO
// parallel


namespace lab21
{
    class Program
    {
        static void Main()
        {
            Operator A1 = new Operator();

            TariffsBase tariffs = new TariffsBase();

            tariffs.AddTariff(A1.MakeTariff("Comfort", 12.1));
            tariffs.AddTariff(A1.MakeTariff("Lite", 1));

            UsersBase usersBase = new UsersBase();

            for (int i = 0; i < 50_000_000; i++)
            {
                usersBase.AddUser(A1.MakeUser($"{i}", tariffs.Tariffs["Lite"]));
            }

            var st = new Stopwatch();
            //usersBase.AddUser(A1.MakeUser("Kostya", tariffs.Tariffs["Lite"]));

            NonParallelManager nonParallelManager = new NonParallelManager();
            ParallelManager parallelManager = new ParallelManager();

            st.Start();
            Printer.Print($"{nonParallelManager.MonthlyIncome(usersBase.Base)}\n");
            st.Stop();

            Printer.Print($"NonParllel - {st.ElapsedMilliseconds}\n");

            st.Reset();

            st.Start();
            Printer.Print($"{parallelManager.MonthlyIncome(usersBase.Base)}\n");
            st.Stop();

            Printer.Print($"Parallel - {st.ElapsedMilliseconds}\n");
        }
    }
}
