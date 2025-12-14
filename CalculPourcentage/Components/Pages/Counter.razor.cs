namespace CalculPourcentage.Components.Pages
{
    public partial class Counter
    {
        public decimal Resultat { get; set; }
        public decimal ResultatTransport { get; set; }
        public decimal Commission { get; set; } = 1;
        public decimal PrixChariot { get; set; } = 1;
        public decimal FraisGestion { get; set; } = 1;
        public decimal NbElt { get; set; } = 1;
        public decimal PrixAchat { get; set; } = 1;

        public decimal Marge { get; set; } = 1;

        public decimal PrixFinal { get; set; }

        public void CalculerTransport()
        {
            CalculerMarge();
            if (NbElt == 0) ResultatTransport = PrixChariot;
            else ResultatTransport = Math.Round(PrixChariot / NbElt, 2);
           
        }
        public void Calculer()
        {
            CalculerTransport();
            CalculerMarge();
            if (FraisGestion == 0) Resultat = Math.Round(PrixAchat * Commission + ResultatTransport, 2);
            else Resultat = Math.Round(PrixAchat * Commission * FraisGestion + ResultatTransport, 2);

        }

        public void CalculerMarge()
        {
            PrixFinal = Math.Round(Resultat * Marge);

        }
        public void Reinitialiser()
        {
            Commission = 1;
            PrixChariot = 1;
            PrixAchat = 1;
            NbElt = 1;
            FraisGestion = 1;
            Marge = 1;
            Calculer();
        }
    }
}
