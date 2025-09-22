using System;

namespace Banko
{
    public class BankoPlade
    {
        public string Id { get; set; }
        public int[,] Tal { get; set; }
        public bool[,] MarkeredeTal { get; set; }

        public BankoPlade(string id)
        {
            Id = id;
            Tal = new int[3, 9];          // 3 rækker x 9 kolonner
            MarkeredeTal = new bool[3, 9];
        }

        public void GenererPlade()
        {
            // TODO: Lav algoritme der genererer en plade ud fra reglerne
        }

        public void PrintPlade()
        {
            // TODO: Udskriv pladen i konsollen
        }

        public void MarkerTal(int nummer)
        {
            // TODO: Marker et trukket tal
        }

        public bool CheckRække(int rækkeNr)
        {
            // TODO: Returnér true/false hvis rækken er fuld
            return false;
        }

        public string CheckBanko()
        {
            // TODO: Returnér status (Ingen banko, 1 række, 2 rækker, fuld plade)
            return "";
        }
    }
}
