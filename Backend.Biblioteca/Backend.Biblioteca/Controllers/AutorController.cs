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
    public class AutorController : ControllerBase
    {
        private readonly BusinessRulesAutor _business;

        public AutorController(IRepositoryAutor repository)
        {
            _business=new BusinessRulesAutor(repository);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutor()
        {
            return await _business.List();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Autor>> GetAutorById(string id)
        {
            return await _business.AutorById(id);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseBase>> CreateAutor([FromBody] Autor autor) {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase() ;
            try
            {
                var result=await _business.Create(autor);
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
        public async Task<ActionResult<ResponseBase>> UpdateAutor([FromBody]  Autor autor)
        {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
            try
            {
                var result = await _business.Update(autor);
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
        public async Task<ActionResult<ResponseBase>> DeleteAutor(string id)
        {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
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