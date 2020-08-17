using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Services;

namespace Tp1_WebApi.Controllers
{
    public class AmigosController : Controller
    {
        private readonly AmigosService _amigoService;

        public AmigosController(AmigosService service)
        {
            _amigoService = service;
        }

        public async Task<ActionResult> Index()
        {
            var list = await _amigoService.FindAllAsync();
            return View(list);

        }

        public async Task<ActionResult> AmigosEmail()
        {
            var list = await _amigoService.FindAllAsync();
            return View(list);
        }
    }
}