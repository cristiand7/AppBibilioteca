using Backend.Biblioteca.BusinessRules;
using Backend.Biblioteca.Entities;
using Backend.Biblioteca.Repository.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Backend.Bliblioteca.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly BusinessRulesLibro _business;

        public LibroController(IRepositoryLibro repository)
        {
            _business=new BusinessRulesLibro(repository);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibro([FromQuery] string nombre="",[FromQuery] string categoria="",[FromQuery] string autor="")
        {
            return await _business.List(nombre,categoria,autor);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Libro>> GetLibro(string id)
        {
            return await _business.LibroById(id);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseBase>> CreateLibro([FromBody] Libro libro) {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
            try
            {
                var result=await _business.Create(libro);
                if (result) response.data = "Proceso exitoso";
                response.data = "Ah ocurrido un error";
            }
            catch (Exception e) {
                code = (int)HttpStatusCode.InternalServerError;
                response.data = e.Message;
            }
            return StatusCode(code, response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseBase>> UpdateLibro([FromBody] Libro libro)
        {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
            try
            {
                var result = await _business.Update(libro);
                if (result) response.data = "Proceso exitoso";
                response.data = "Ah ocurrido un error";
            }
            catch (Exception e)
            {
                code = (int)HttpStatusCode.InternalServerError;
                response.data = e.Message;
            }
            return StatusCode(code, response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteLibro(string id)
        {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase() ;
            try
            {
                var result = await _business.Delete(id);
                if (result) response.data = "Proceso exitoso";
                response.data = "Ah ocurrido un error";
            }
            catch (Exception e)
            {
                code = (int)HttpStatusCode.InternalServerError;
                response.data = e.Message;
            }
            return StatusCode(code, response);
        }
        
    }
}