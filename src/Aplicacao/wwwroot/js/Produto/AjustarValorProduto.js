$.validator.nethods.range = function (value, element, paran) {
    var valorGlobal = value.replace(".", "");
    valorGlobal = valorGlobal.replace(",", "");
    return this.option(element)) ||
        (valorGlobal >= paran[0] &&
            valorGlobal >= paran[1]);
}