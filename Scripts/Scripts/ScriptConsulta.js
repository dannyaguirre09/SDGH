modalCrear = document.getElementById('modalCrear');
modalEliminar = document.getElementById('modalEliminar');

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
	llenarTablaConsulta();
	llenarTablaEnfermedades()
});

async function llenarTablaConsulta() {
	$('#tablaMotivos').DataTable({
		"ordering": false,
		"bInfo": false,
		"searching": false,
		"bPaginate": false,
		"language": {
			"lengthMenu": "Mostrar _MENU_ por página",
			"zeroRecords": "No hay registros",
			"infoEmpty": "No hay registros disponibles",
			"search": "Buscar:",
			"paginate": {
				"previous": "Anterior",
				"next": "Siguiente",
			}
		}
	});
}

async function llenarTablaEnfermedades() {
	$('#tablaEnfermedades').DataTable({
		"ordering": false,
		"bInfo": false,
		"bPaginate": false,
		"searching": false,
		"language": {
			"lengthMenu": "Mostrar _MENU_ por página",
			"zeroRecords": "No hay registros",
			"infoEmpty": "No hay registros disponibles",
			"search": "Buscar:",
			"paginate": {
				"previous": "Anterior",
				"next": "Siguiente",
			}
		}
	});
}

function abrirModal(id, identificador) {
	var numEmp = document.getElementById('numEmp');
	var codHist = document.getElementById('codHist');
	var url = '/Consulta/CrearMotivoConsulta?numEmp=' + numEmp.value + '&codHist=' + codHist.value + '&id=' + id + '&identificador=' + identificador;
	$.get(url, function (url) {
		$("#modalCrear").html(url);
		modalCrear.style.display = 'block';
		var tituloModal = document.getElementById('tituloModalCrear');
		var btnFormulario = document.getElementById('btnFormulario');
		if (id == 0) {
			tituloModal.textContent = "Crear Motivo";
			btnFormulario.value = "Crear Motivo";
		}
		else {
			tituloModal.textContent = "Editar Motivo"
			btnFormulario.value = "Editar Motivo";
		}
		bloquearBarraDesplazamiento();
	});
}

function validar() {
	/*var descripcion = $('#CNSMOTIVO').val();
	if (descripcion.trim() == "") {
		var elemento = document.getElementById("descripcion");
		elemento.hidden = false;
		return false;
	}*/
	

}

function cerrarModal() {
	modalCrear.style.display = 'none';
	activarBarraDesplazamiento();
}

function cerrarModalConfirmacion() {
	modalEliminar.style.display = 'none';
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
	var url = '/Consulta/Confirmacion?numEmp=' + numEmp.value + '&codHist=' + codHist.value + '&id=' + id;
	$.get(url, function (url) {
		$("#modalEliminar").html(url);
		modalEliminar.style.display = 'block'
		bloquearBarraDesplazamiento();
	});
}