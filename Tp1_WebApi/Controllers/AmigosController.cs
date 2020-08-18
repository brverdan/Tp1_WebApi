using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Repository.Context;
using Services;

namespace Tp1_WebApi.Controllers
{

    public class AmigosController : Controller
    {
        private List<Amigos> amigosSelecionados = new List<Amigos>();

        private readonly AmigosService _amigoService;

        public AmigosController(AmigosService service)
        {
            _amigoService = service;
        }

        public ActionResult Index(string ids)
        {

            MantendoSessão(ids);
            var list = _amigoService.FindAll();
            return View(list);

        }

        public ActionResult AmigosEmail(string ids)
        {
            MantendoSessão(ids);

            var list = _amigoService.FindAll();
            return View(list);
        }


        private void MantendoSessão(string ids)
        {
            if (!String.IsNullOrWhiteSpace(ids))
            {
                foreach (var item in ids.Split(","))
                {
                    amigosSelecionados.Add(_amigoService.FindAllById(int.Parse(item)));
                }
            }

            this.HttpContext.Session.SetString("AmigosSelecionados", JsonConvert.SerializeObject(amigosSelecionados));

            if (this.HttpContext.Session.GetString("AmigosSelecionados") != null)
            {
                var idsSelecionados = JsonConvert.DeserializeObject<List<Amigos>>(this.HttpContext.Session.GetString("AmigosSelecionados"));
                ViewBag.IdsSelecionados = idsSelecionados.Select(x => x.Id.ToString());
            }
        }
    }
}