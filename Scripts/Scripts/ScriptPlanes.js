modalCrear = document.getElementById('modalCrear');
modalEliminar = document.getElementById('modalEliminar');

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);	
});

function abrirModal(id) {
	let codHist = document.getElementById('codHist');
	let numEmp = document.getElementById('numEmp');
	var url = '/Planes/CrearPrescripcion?codHist=' + codHist.value + '&numEmp= ' + numEmp.value + '&id=' + id;
	$.get(url, function (url) {
		$("#modalCrear").html(url);
		modalCrear.style.display = 'block';
		var tituloModal = document.getElementById('tituloModalCrear');
		var btnFormulario = document.getElementById('btnFormulario');
		if (id == 0) {
			tituloModal.textContent = "Crear Prescripción";
			btnFormulario.value = "Crear Prescripción";
		}
		else {
			tituloModal.textContent = "Editar Prescripción"
			btnFormulario.value = "Editar Prescripción";
		}
		bloquearBarraDesplazamiento();
	});
}

function cerrarModal() {
	modalCrear.style.display = 'none';
	activarBarraDesplazamiento();
}

function bloquearBarraDesplazamiento() {
	$('body').css({ 'overflow': 'hidden' });
	$(document).bind('scroll', function () {
		window.scrollTo(0, 0);
	});
}

function activarBarraDesplazamiento() {
	$(document).unbind('scroll');
	$('body').css({ 'overflow': 'visible' });
}

function abrirModalEliminar(id) {
	var numEmp = document.getElementById('numEmp');
	var codHist = document.getElementById('codHist');
	var url = '/Planes/Confirmacion?numEmp=' + numEmp.value + '&codHist=' + codHist.value + '&id=' + id;
	$.get(url, function (url) {
		$("#modalEliminar").html(url);
		modalEliminar.style.display = 'block'
		bloquearBarraDesplazamiento();
	});
}

function cerrarModalConfirmacion() {
	modalEliminar.style.display = 'none';
	activarBarraDesplazamiento();
}


function validar() {
	var descripcion = $('#txtDescripcion').val();
	if (descripcion.trim() == "") {
		var elemento = document.getElementById("descripcion");
		elemento.hidden = false;
		return false;
	}
}