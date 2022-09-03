using AspBeginner_Tutorial.Models.Domain;
using AspBeginner_Tutorial.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspBeginner_Tutorial.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRespository _repo;
        private readonly IMapper _mapper;
        public RegionsController(IRegionRespository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            #region
            //var REGIONS = new List<Region>()
            //{var region = _repo.GetAll();

            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Auckland",
            //        Code = "ACD",
            //        Area = 643223,
            //        Lat = 23.5

            //    }
            //}


            //var regionsdto = new list<models.dto.region>();
            //region.tolist().foreach (reg =>
            //{
            //    var regiondto = new models.dto.region()
            //    {
            //        name = reg.name,
            //        area = reg.area,
            //        lat = reg.lat,
            //        long = reg.long,
            //        population = reg.population
            //    };
            //    regionsdto.add(regiondto);
            //}) ;
            //return ok(regionsdto);
            #endregion
            var regions = _repo.GetAll();
            var regionsDTO = _mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(regionsDTO);


        }
    }
}



