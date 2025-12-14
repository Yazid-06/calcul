namespace CalculPourcentage.Components.Pages
{
    public partial class Counter
    {
        public decimal Resultat { get; set; } = 0;
        public decimal ResultatTransport { get; set; } = 0;
        public decimal Commission { get; set; } = 1;
        public decimal PrixChariot { get; set; } = 0;
        public decimal FraisGestion { get; set; } = 1;
        public decimal NbElt { get; set; } = 0;
        public decimal PrixAchat { get; set; } = 0;

        public void CalculerTransport()
        {
            if (NbElt == 0) ResultatTransport = PrixChariot;
            else ResultatTransport = Math.Round(PrixChariot / NbElt, 2);
        }
        public void Calculer()
        {
            CalculerTransport();
            if (FraisGestion == 0) Resultat = Math.Round(PrixAchat * Commission + ResultatTransport, 2);
            else Resultat = Math.Round(PrixAchat * Commission * FraisGestion + ResultatTransport, 2);
        }
        public void Reinitialiser()
        {
            Commission = 1;
            PrixChariot = 0;
            PrixAchat = 0;
            NbElt = 0;
            FraisGestion = 1;
            Calculer();
        }
    }
}
