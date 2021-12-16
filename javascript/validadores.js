function validarCajaNoVacia(idcaja)
{
var eCaja = document.getElementById(idcaja);

        if (eCaja.value != "")
         { return true; }
        else { return false; }
}