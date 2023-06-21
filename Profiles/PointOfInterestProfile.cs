using AutoMapper;
using CityInfo.API.Models;
using CityInfo.API.Entities;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile: Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<PointOfInterest, PointOfInterestDto>();
            CreateMap<PointOfInterestForCreationDto, PointOfInterest>();
            CreateMap<PointOfInterestForUpdateDto, PointOfInterest>();
            CreateMap<PointOfInterest, PointOfInterestForUpdateDto>();
        }
    }
}
