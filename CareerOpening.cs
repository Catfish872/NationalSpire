namespace NationalSpire;

/// <summary>个人开局字段在单人生涯或当前联机队员的视图中应用一次。空字段保留生涯原值。</summary>
public sealed class CareerOpeningPlayer
{
    public string Name { get; set; } = "";
    public string Biography { get; set; } = "";
    public string Country { get; set; } = "";
    public string Gender { get; set; } = "";
    public PlayerAvatar? Avatar { get; set; }
    public decimal? Credits { get; set; }
    public int? Wins { get; set; }
    public int? Draws { get; set; }
    public int? Losses { get; set; }
    public string Sponsor { get; set; } = "";

    public void Apply(CareerData data)
    {
        if (Name.Trim().Length > 0) data.PlayerAlias = Name.Trim();
        if (IdentityGender.Choices.Contains(Gender)) data.PlayerGender = Gender;
        if (Credits is >= 0) data.Credits = Credits.Value / 10m;
        if (Wins is >= 0) data.Wins = Wins.Value;
        if (Draws is >= 0) data.Draws = Draws.Value;
        if (Losses is >= 0) data.Losses = Losses.Value;
        if (Avatar != null) { Avatar.Validate(); data.SelectedAvatar = Avatar; }
        if (Biography.Trim().Length > 0 || EsportsWorld.Countries.Contains(Country))
        {
            var card = CharacterCards.Read(data, "player");
            if (Biography.Trim().Length > 0) card.Biography = Biography.Trim();
            if (EsportsWorld.Countries.Contains(Country)) card.Country = Country;
            data.PlayerCard = card;
        }
        if (Sponsor.Length > 0)
        {
            var option = RegionalOrganizations.SponsorCatalog().FirstOrDefault(x => x.Brand == Sponsor);
            if (option.Brand == null) throw new ArgumentException("请选择已有的赞助品牌。");
            var offer = CareerCommerce.BuildPersonalOffer(data, option.Sector, option.Brand, data.Season, SponsorIncome.PersonalTier(data));
            SponsorIncome.Initialize(data, offer);
            offer.Accepted = true; offer.SignedDay = data.Day; offer.PaidSeason = data.Season;
            data.Esports.Sponsors.Add(offer);
        }
    }
}
