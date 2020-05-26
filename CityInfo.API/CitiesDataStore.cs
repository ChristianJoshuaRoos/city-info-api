using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New Orleans",
                    Description = "The stinkiest city in America.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "New Orleans Museum of Art",
                            Description = "Paintings of stuff."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Audubon Zoo",
                            Description = "Monkeys doing weird monkey things."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Fayetteville",
                    Description = "A gem on the edge of the Ozarks.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Devil's Den State Park",
                            Description = "A pretty area where you can meet the Devil."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Tyson Chicken Plant",
                            Description = "The source of all chicken nuggets."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "San Cristobal",
                    Description = "The middle of nowhere.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "D.H. Lawrence Ranch",
                            Description = "Wher D.H. Lawrence wrote some books."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "San Cristobal Catholic Church",
                            Description = "Creepy ruins of a church with some ghosts."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "New York City",
                    Description = "The most annoying city in America.",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 7,
                            Name = "Central Park",
                            Description = "The giant park in the middle of Manhattan."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 8,
                            Name = "Statue of Liberty",
                            Description = "A giant statue of a giant lady."
                        }
                    }
                },
            };
        }
    }
}
