using System.Collections.Generic;
using System.Web.Http;
using Rhythm.Event.Dto;
using Rhythm.Event.Repository.Interfaces;

namespace Rhythm.Event.WebAPI.Controllers
{
    [RoutePrefix("api")]
    public class EventController : ApiController
    {
        private readonly IRhythmEventRepository eventRepository;

        public EventController(IRhythmEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        [HttpGet]
        public IEnumerable<RhythmEventDto> GetEvents()
        {
            var rhythmEventDtos = eventRepository.GetEntities<RhythmEventDto>();
            return rhythmEventDtos;
        }

        [HttpPost]
        public IHttpActionResult PostEvent(RhythmEventDto eventEntity)
        {
            return Created($"{Request.RequestUri}{eventEntity.EventID}", eventEntity);
        }
    }
}
