// PARTE DE LISTAGEM DE CLIENTE E MESA
$('#cadastroClientePedido').select2({
    ajax: {
        url: '/cliente/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});

$('#cadastroProdutoPedido').select2({
    ajax: {
        url: '/produto/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});


// PARTE DE QUANTIDADE DO PRODUTO
function totalClick(click) {
    const totalClicks = document.getElementById('totalClicks');
    const sumvalue = parseInt(totalClicks.innerText) + click;
    console.log(sumvalue + click);
    totalClicks.innerText = sumvalue;

    if (sumvalue < 0) {
        totalClicks.innerText = 0;
    }

    if (click === 0) {
        totalClicks.innerText = 0;
    }
}