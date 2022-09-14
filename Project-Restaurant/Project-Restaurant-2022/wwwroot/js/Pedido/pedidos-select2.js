$('#cadastroCliente').select2({
    ajax: {
        url: '/Cliente/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});

$('#cadastroMesa').select2({
    ajax: {
        url: '/Mesa/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});