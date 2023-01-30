using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tech_test_payment_api.Enum;

namespace tech_test_payment_api.Models {
    public class Venda {

        public int Id;
        public DateTime Data;
        public Vendedor Vendedor;
        public Item[] Itens;
        public EStatusVendas Status;

        public void AtualizarStatus(EStatusVendas status) {
            switch (status) {
                case EStatusVendas.AguardandoPagamento: { 
                    // ignorar
                    break;
                }
                case EStatusVendas.PagamentoAprovado: {
                    if(Status == EStatusVendas.AguardandoPagamento) {
                        Status = status;
                    }
                    break;
                }
                case EStatusVendas.EnviadoParaTransportadora: {
                    if (Status == EStatusVendas.PagamentoAprovado) {
                        Status = status;
                    }
                    break;
                }
                case EStatusVendas.Entregue: {
                    if (Status == EStatusVendas.EnviadoParaTransportadora) {
                        Status = status;
                    }
                    break;
                }
                case EStatusVendas.Cancelada: {
                    if (Status == EStatusVendas.AguardandoPagamento || Status == EStatusVendas.PagamentoAprovado) {
                        Status = status;
                    }
                    break;
                }
            }
        }

    }
}