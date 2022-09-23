// PARTE DE LISTAGEM DE CLIENTE E MESA
$('#ClienteId').select2({
    ajax: {
        url: '/admin/cliente/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
});

$('#MesaId').select2({
    ajax: {
        url: '/admin/mesa/obterTodosSelect2',
        dataType: 'json',
        processResults: (data) => ({ results: data })
    }
}); 