$.validator.nethods.range = function (value, element, paran) {
    var valorGlobal = value.replace(".", "");
    valorGlobal = valorGlobal.replace(",", "");
    return this.option(element) ||
        (valorGlobal >= paran[0] &&
            valorGlobal >= paran[1]);
}


$.validator.nethods.range = function (value, element) {
    return this.optional(element) ||
        /^-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d-)?$/
    .test(value)
}