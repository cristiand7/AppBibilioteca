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
    public class CategoriaController : ControllerBase
    {
        private readonly BusinessRulesCategoria _business;

        public CategoriaController(IRepositoryCategoria repository)
        {
            _business=new BusinessRulesCategoria(repository);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria()
        {
            return await _business.List();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Categoria>> GetCategoria(string id)
        {
            return await _business.CategoriaById(id);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseBase>> CreateCategoria([FromBody] Categoria categoria) {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
            try
            {
                var result=await _business.Create(categoria);
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
        public async Task<ActionResult<ResponseBase>> UpdateCategoria([FromBody] Categoria categoria)
        {
            var code = (int)HttpStatusCode.OK;
            var response = new ResponseBase();
            try
            {
                var result = await _business.Update(categoria);
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
        public async Task<ActionResult> DeleteCategoria(string id)
        {
            var code = (int)HttpStatusCode.OK;
            string response;
            try
            {
                var result = await _business.Delete(id);
                if (result) response = "Proceso exitoso";
                response = "Ah ocurrido un error";
            }
            catch (Exception e)
            {
                code = (int)HttpStatusCode.InternalServerError;
                response = e.Message;
            }
            var res = new ResponseBase
            {
                data = response
            };
            return StatusCode(code, res);
        }
        
    }
}