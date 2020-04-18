﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace QuantityMeasurement_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IManager manager;

        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }


        // GET api/values
        [Route("FeettoInch")]
        [HttpPost]
        public IActionResult FeettoInch(Conversion value)
        {
            var result = this.manager.FeettoInch(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }


        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(Conversion value)
        {
            var result = this.manager.InchToFeet(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MetertoCentimeter")]
        [HttpPost]
        public IActionResult MetertoCentimeter(Conversion value)
        {
            var result = this.manager.MetertoCentimeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("CentimetertoMeter")]
        [HttpPost]
        public IActionResult CentimetertoMeter(Conversion value)
        {
            var result = this.manager.CentimetertoMeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("KgtoGm")]
        [HttpPost]
        public IActionResult KgtoGm(Conversion value)
        {
            var result = this.manager.KgtoGm(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("GmtoKg")]
        [HttpPost]
        public IActionResult GmtoKg(Conversion value)
        {
            var result = this.manager.GmtoKg(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}