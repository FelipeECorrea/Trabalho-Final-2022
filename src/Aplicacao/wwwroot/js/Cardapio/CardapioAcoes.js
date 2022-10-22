// Ações nos botões + e - da janela modal
const mais = document.querySelector(".mais"),
    menos = document.querySelector(".menos"),
    qtd = document.querySelector(".qtd");

let quantidade = 1;

mais.addEventListener("click", () => {
    quantidade++;
    quantidade = (quantidade < 10) ? "0" + quantidade : quantidade;
    qtd.innerText = quantidade;
});

menos.addEventListener("click", () => {
    if (quantidade > 1) {
        quantidade--;
        quantidade = (quantidade < 10) ? "0" + quantidade : quantidade;
        qtd.innerText = quantidade;
    }
});

$('body').on('click', 'button.carrinho-adicionar-produto', (event) => {
    let element = event.target.tagName === 'I'
        ? event.target.parentElement
        : event.target;
    let id = element.getAttribute("data-id");
    PreencherModal(id);
});

document.getElementById("pedido-carrinho").addEventListener("click", () => {
    PreencherModalCarrinho();
})

let PreencherModal = (id) => {
    fetch('/client/produto/obterPorId?id=' + id, {
        method: 'GET',
    })
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            console.log(data);

            document.getElementById("produto-escolhido-id").value = data.id
            document.getElementById("produto-escolhido-nome").innerText = data.nome
            document.getElementById("produto-escolhido-valor").innerText = data.valor
            document.getElementById("produto-escolhido-imagem").src = "/uploads/produtos/" + data.imagem;
            $("#produtoPedidoModal").modal('show');
        })
        .catch((error) => {
            toastr.error("Não foi possível carregar as informações do produto")
            console.log(error);
        });

}

// PARTE DO CARRINHO

let PreencherModalCarrinho = () => {
    fetch('/client/pedido/atual', {
        method: 'GET',
    })
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            data.forEach(function (item, index) {
                var itemHtml = `<div class="row">
                    <div class="col">
                        <div class="modal-body">
                            <img id="produto-escolhido-imagem" class="img-center img-fluid menu-img rounded-circle" alt="" src="/uploads/produtos/X-Burguer.png">
                        </div>
                    </div>
                    <div class="col">
                        <input type="hidden" id="produto-escolhido-id">
                        <b><span id="pedido-id-nome">${item.nome}</span></b>
                    </div>
                    <div class="col">
                        <b>Valor:</b>
                        <b>R$ <span id="produto-escolhido-valor"></span></b>
                    </div>
                </div>`
                document.getElementById("carrinho-produtos").innerHTML += itemHtml;
            });
            //document.getElementById("pedido-id").value = data.id
            //document.getElementById("produto-escolhido-nome").innerText = data.nome
            //document.getElementById("produto-escolhido-valor").innerText = data.valor
            //document.getElementById("produto-escolhido-imagem").src = "/uploads/produtos/" + data.imagem;
            $("#PedidoModal").modal('show');
        })
        .catch((error) => {
            toastr.error("Não foi possível carregar as informações os produto")
            console.log(error);
        });

}

// PARTE DO CARRINHO

let produtoAdicionarNoPedido = () => {
    let produtoId = document.getElementById("produto-escolhido-id").value;
    //let quantidade = document.getElementById("quantidade").value;
    let quantidade = document.getElementById("quantidade").innerText;
    let dados = new FormData();
    dados.append("produtoId", produtoId);
    dados.append("quantidade", quantidade);
    console.log(dados);

    fetch('/client/cardapio/adicionarProduto', {
        method: 'POST',
        body: dados
    })
    .then((data) => {
            console.log(data);

            $("#produtoPedidoModal").modal('hide');

            toastr.success("Produto adicionado");

    })
    .catch((error) => {
            console.log(error);
            toastr.error("Não foi possível finalizar seu pedido")
    });
}
let gerarPedido = () => {
    let produtoId = document.getElementById("listar-produtos-escolhidos").value;


}

document.getElementById("botao-finalizar-pedido")
    .addEventListener("click", produtoAdicionarNoPedido);


