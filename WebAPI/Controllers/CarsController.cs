﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetAllByColorId(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("GetCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("GetAllByBrandId")]
        public IActionResult GetAllByBrandId(int id)
        {
            var result = _carService.GetAllByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


    }
}
