using MassTransit.KafkaIntegration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ITopicProducer<VedioDeletedEvent> _topicProducer;
        public HomeController(ITopicProducer<VedioDeletedEvent> topicProducer)
        {
            _topicProducer = topicProducer;
        }

        [HttpPost()]
        public async Task<IActionResult> PostAsync([FromBody]string title)
        {
            await _topicProducer.Produce(new VedioDeletedEvent { Title=title});
            return Ok(title);
        }
    }
}
