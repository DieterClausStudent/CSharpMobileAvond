using Microsoft.AspNetCore.Mvc;
using PieShop.API.Services;
using AutoMapper;
using PieShop.API.Models;
using PieShop.API.Entitites;

namespace PieShop.API.Controllers
{
    [ApiController]
    [Route("api/pies")]
    public class PiesController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly IMapper _mapper;

        public PiesController(IPieRepository pieRepository, IMapper mapper)
        {
            _pieRepository = pieRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PieDto>>> GetPies()
        {
            var pies = await _pieRepository.GetPiesAsync();
            return Ok(_mapper.Map<IEnumerable<PieDto>>(pies));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPie(Guid id)
        {
            var pie = await _pieRepository.GetPieAsync(id);

            if (pie == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PieDto>(pie));
        }

        [HttpPost]
        public async Task<ActionResult<PieDto>> AddPie(PieDto pieDto)
        {
     
            var pie = await _pieRepository.AddPieAsync(_mapper.Map<Pie>(pieDto));

            await _pieRepository.SaveChangesAsync();

            return _mapper.Map<PieDto>(pie);
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePie(PieDto pieDto)
        {
            var pie = await _pieRepository.GetPieAsync(pieDto.Id);

            if(pie == null)
            {
                return NotFound();
            }

            _pieRepository.UpdatePie((_mapper.Map<Pie>(pieDto)));


            await _pieRepository.SaveChangesAsync();

            return Ok();

        }

      [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePie(Guid id)
        {
            var pie = await _pieRepository.GetPieAsync(id);
            if (pie == null)
            {
                return NotFound();
            }
           _pieRepository.DeletePie(pie);

            await _pieRepository.SaveChangesAsync();

            return Ok();
        }

    }
}
