// PARTE DE LISTAGEM DE CLIENTE E MESA
$('#cadastroClientePedido').select2({
    ajax: {
        url: '/cliente/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});

$('#cadastroMesaPedido').select2({
    ajax: {
        url: '/mesa/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});