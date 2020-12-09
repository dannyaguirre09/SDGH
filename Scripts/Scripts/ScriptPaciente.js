modalCargando = document.getElementById('modalCargando');

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);
	llenarTabla();
	modalCargando.style.display = 'none'
});

async function llenarTabla() {
	await $('#tabla').DataTable({
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
}