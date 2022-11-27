using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayBeforeYouDie.Infrastructure.Data.Models;
using System.Diagnostics;

namespace PlayBeforeYouDie.Infrastructure.Data.Configuration;

public class SystemRequirementConfiguration : IEntityTypeConfiguration<SystemRequirement>
{
    public void Configure(EntityTypeBuilder<SystemRequirement> builder)
    {
        builder.HasData(CreateSystemRequirements());
    }

    private List<SystemRequirement> CreateSystemRequirements()
    {
        var systemRequirements = new List<SystemRequirement>()
        {
            new SystemRequirement()
            {
                Id = 1,
                Os = "Nintendo 65",
                Processor = "(Nintendo 65) Processor",
                Memory = "(Nintendo 65) Memory",
                Graphics = "(Nintendo 65) Graphics",
                Network = "N/A",
                Storage = "32 MB",
                AdditionalNotes = "Can be played in PC with required porting or PC Ports"

            },

            new SystemRequirement()
            {
                Id = 2,
                Os = "Windows 7 (plus Service Pack 1) / PS3 / PS4",
                Processor = "Intel Core 2 Duo 1.8GHz, AMD Athlon X2 64 2.4GHz",
                Memory = " 1.5GB XP / 1.5GB Vista",
                Graphics = "256MB Nvidia 7900 / 256MB ATI X1900",
                Network = "N/A",
                Storage = "32GB of Hard Disc Space",
                AdditionalNotes = "Initial activation requires internet connection; Online play requires log-in to Games For Windows - Live and Rockstar Games Social Club ("

            },

            new SystemRequirement()
            {
                Id = 3,
                Os = "Windows 7 64-Bit / PS2/ PS3",
                Processor = "Intel CPU: Pentium 4 1.8GHz",
                Memory = " 1 GB RAM",
                Graphics = "GeForce 210 or Radeon X600 Series",
                Network = "N/A",
                Storage = "1 GB"
                
            },

            new SystemRequirement()
            {
                Id = 4,
                Os = "Windows 10 - April 2018 Update (v1803) / PS3 / PS4",
                Processor = "Intel® Core™ i7-4770K / AMD Ryzen 5 1500X",
                Memory = "12 GB RAM",
                Graphics = "Nvidia GeForce GTX 1060 6GB / AMD Radeon RX 480 4GB",
                Network = "Broadband Internet connection",
                Storage = "150 GB available space",
                
            },

            new SystemRequirement()
            {
                Id = 5,
                Os = "64-bit Windows 7, 64-bit Windows 8 (8.1) or 64-bit Windows 10 / PS3 / PS4",
                Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                Memory = " 6 GB RAM",
                Graphics = "Nvidia GPU GeForce GTX 660 / AMD GPU Radeon HD 7870",
                Network = "N/A",
                Storage = "35 GB available space",
                
            }


        };

        return systemRequirements;
    }
}