$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
});

function validar() {
	var HSCNUMERO = $('#HSCNUMERO').val();
	if (HSCNUMERO.trim() == "") {
		var elemento = document.getElementById("mensajeHistoria");
		elemento.hidden = false;
		return false;
	}
}