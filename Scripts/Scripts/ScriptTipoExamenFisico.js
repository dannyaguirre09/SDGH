modalCrear = document.getElementById('modalCrear');
modalEliminar = document.getElementById('modalEliminar');
$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
	$('#tabla').DataTable({
		"ordering": false,
		"bInfo": false,
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
});

function abrirModal(id) {
	var url = '/TipoExamenFisico/CrearTipoExamenFisico?id=' + id;
	$.get(url, function (url) {
		$("#modalCrear").html(url);
		modalCrear.style.display = 'block';
		var tituloModal = document.getElementById('tituloModalCrear');
		var btnFormulario = document.getElementById('btnFormulario');
		if (id == 0) {
			tituloModal.textContent = "Crear Tipo Examen Físico";
			btnFormulario.value = "Crear Tipo Examen Físico";
		}
		else {
			tituloModal.textContent = "Editar Tipo Examen Físico"
			btnFormulario.value = "Editar Tipo Examen Físico";
		}
		bloquearBarraDesplazamiento();
	});
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

function validar() {
	var descripcion = $('#txtDescripcion').val();
	if (descripcion.trim() == "") {
		var elemento = document.getElementById("descripcion");
		elemento.hidden = false;
		return false;
	}
}

function abrirModalEliminar(id) {
	var url = '/TipoExamenFisico/Confirmacion?id=' + id;
	$.get(url, function (url) {
		$("#modalEliminar").html(url);
		modalEliminar.style.display = 'block'
		bloquearBarraDesplazamiento();
	});
}