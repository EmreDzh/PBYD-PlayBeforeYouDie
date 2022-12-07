using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

public class HowLongToBeatConfiguration : IEntityTypeConfiguration<HowLongToBeat>
{
    public void Configure(EntityTypeBuilder<HowLongToBeat> builder)
    {
        builder.HasData(CreateHowLongToBeat());
    }

    private List<HowLongToBeat> CreateHowLongToBeat()
    {
        var howLongToBeat = new List<HowLongToBeat>()
        {
            new HowLongToBeat()
            {
                Id = 1,
                MainStory = "26h 13m",
                MainPlusSides = "30h 36m",
                HundredPercentComplete = "37h 48m",
                SpeedRunAny = "2h 57m 36s",
                SpeedRunOneHundredPercent = "5h 30m 31s",
                GameId = 1
                //ReviewId = 1
            },
            new HowLongToBeat()
            {
                Id = 2,
                MainStory = "27h 35m",
                MainPlusSides = "41h 27m",
                HundredPercentComplete = "77h 11m",
                SpeedRunAny = "10h 40m 40s",
                SpeedRunOneHundredPercent = "15h 54m 44s",
                GameId = 3
                //ReviewId = 1
            },
            new HowLongToBeat()
            {
                Id = 3,
                MainStory = "13h 41m",
                MainPlusSides = "22h 14m",
                HundredPercentComplete = "36h 53m",
                SpeedRunAny = "3h 52m 24s",
                SpeedRunOneHundredPercent = "8h 33m 50s",
                GameId = 4
                //ReviewId = 1
            },
            new HowLongToBeat()
            {
                Id = 4,
                MainStory = "49h 44m",
                MainPlusSides = "84h 27m",
                HundredPercentComplete = "184h 12m",
                SpeedRunAny = "14h 4m 32s",
                SpeedRunOneHundredPercent = "35h 13m 26s",
                GameId = 5
                //ReviewId = 1
            },
            new HowLongToBeat()
            {
                Id = 5,
                MainStory = "52h 33m",
                MainPlusSides = "106h 16m",
                HundredPercentComplete = "179h 56m",
                SpeedRunAny = "16h 48m 48s",
                SpeedRunOneHundredPercent = "63h 20m",
                GameId = 6
                //ReviewId = 1
            }
        };

        return howLongToBeat;
    }
}