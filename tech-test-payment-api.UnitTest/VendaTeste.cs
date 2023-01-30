using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tech_test_payment_api.Enum;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.UnitTest {
    [TestClass]
    public class VendaTeste {
        [TestMethod]
        public void AtualizarStatusDeAguardandoPagamentoParaPagamentoAprovado() {
            Venda v = new Venda();
            v.Status = EStatusVendas.AguardandoPagamento;
            v.AtualizarStatus(EStatusVendas.PagamentoAprovado);
            Assert.IsTrue(v.Status == EStatusVendas.PagamentoAprovado);
        }

        [TestMethod]
        public void AtualizarStatusDeAguardandoPagamentoParaCancelada() {
            Venda v = new Venda();
            v.Status = EStatusVendas.AguardandoPagamento;
            v.AtualizarStatus(EStatusVendas.Cancelada);
            Assert.IsTrue(v.Status == EStatusVendas.Cancelada);
        }

        [TestMethod]
        public void AtualizarStatusDePagamentoAprovadoParaEnviadoParaTransportadora() {
            Venda v = new Venda();
            v.Status = EStatusVendas.PagamentoAprovado;
            v.AtualizarStatus(EStatusVendas.EnviadoParaTransportadora);
            Assert.IsTrue(v.Status == EStatusVendas.EnviadoParaTransportadora);
        }

        [TestMethod]
        public void AtualizarStatusDePagamentoAprovadoParaCancelada() {
            Venda v = new Venda();
            v.Status = EStatusVendas.PagamentoAprovado;
            v.AtualizarStatus(EStatusVendas.Cancelada);
            Assert.IsTrue(v.Status == EStatusVendas.Cancelada);
        }

        [TestMethod]
        public void AtualizarStatusDeEnviadoParaTransportadoraParaEntregue() {
            Venda v = new Venda();
            v.Status = EStatusVendas.EnviadoParaTransportadora;
            v.AtualizarStatus(EStatusVendas.Entregue);
            Assert.IsTrue(v.Status == EStatusVendas.Entregue);
        }

        [TestMethod]
        public void AtualizarStatusDeAguardandoPagamentoParaEnviadoParaTransportadora() {
            Venda v = new Venda();
            v.Status = EStatusVendas.AguardandoPagamento;
            v.AtualizarStatus(EStatusVendas.EnviadoParaTransportadora);
            Assert.IsTrue(v.Status == EStatusVendas.AguardandoPagamento);
        }

        [TestMethod]
        public void AtualizarStatusDePagamentoAprovadoParaEntregue() {
            Venda v = new Venda();
            v.Status = EStatusVendas.PagamentoAprovado;
            v.AtualizarStatus(EStatusVendas.Entregue);
            Assert.IsTrue(v.Status == EStatusVendas.PagamentoAprovado);
        }

        [TestMethod]
        public void AtualizarStatusDeEnviadoParaCancelada() {
            Venda v = new Venda();
            v.Status = EStatusVendas.EnviadoParaTransportadora;
            v.AtualizarStatus(EStatusVendas.Cancelada);
            Assert.IsTrue(v.Status == EStatusVendas.EnviadoParaTransportadora);
        }

        [TestMethod]
        public void AtualizarStatusDeCanceladoParaEntregue() {
            Venda v = new Venda();
            v.Status = EStatusVendas.Cancelada;
            v.AtualizarStatus(EStatusVendas.Entregue);
            Assert.IsTrue(v.Status == EStatusVendas.Cancelada);
        }

        [TestMethod]
        public void AtualizarStatusDeEntregueParaCancelada() {
            Venda v = new Venda();
            v.Status = EStatusVendas.Entregue;
            v.AtualizarStatus(EStatusVendas.Cancelada);
            Assert.IsTrue(v.Status == EStatusVendas.Entregue);
        }
    }
}
