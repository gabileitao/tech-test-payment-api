using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tech_test_payment_api.Enum {
    public enum EStatusVendas {

        AguardandoPagamento,
        PagamentoAprovado,
        EnviadoParaTransportadora,
        Entregue,
        Cancelada

    }
}