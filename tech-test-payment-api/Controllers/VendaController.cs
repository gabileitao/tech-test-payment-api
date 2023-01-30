using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tech_test_payment_api.Enum;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers {
    public class VendaController : ApiController {

        public static List<Venda> Vendas = new List<Venda>();

        [HttpGet, Route("venda")]
        public IHttpActionResult GetVenda() {
            return Ok(Vendas);
        }

        [HttpGet, Route("venda/{id}")]
        public IHttpActionResult GetVenda([FromUri] int id) {
            Venda venda = Vendas.FirstOrDefault(v => v.Id == id);

            if(venda == null) {
                return NotFound();
            }

            return Ok(venda);
        }

        [HttpPost, Route("venda")]
        public IHttpActionResult PostVenda([FromBody] Venda venda) {

            venda.Status = EStatusVendas.AguardandoPagamento;
            Vendas.Add(venda);

            return Ok(venda);
        }

        [HttpPut, Route("venda")]
        public IHttpActionResult PutVenda([FromBody] Venda vendaInput) {
            Venda venda = Vendas.FirstOrDefault(v => v.Id == vendaInput.Id);

            if (venda == null) {
                return NotFound();
            }

            venda.AtualizarStatus(vendaInput.Status);

            return Ok(venda);
        }
    }
}
