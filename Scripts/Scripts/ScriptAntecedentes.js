let idTipoAntecedente = document.getElementById('idTipoAntecedente');
idTipoAntecedente.addEventListener('change', actualizarTabla);
actualizarTabla();

$(document).ready(function () {
	$('.alert').fadeIn();
	setTimeout(function () {
		$(".alert").fadeOut();
	}, 5000);	
});

function actualizarTabla() {
	let codHist = document.getElementById('codHist');
	if (idTipoAntecedente.value.trim() != '') {
		$('#tabla').DataTable({
			"destroy": true,
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
			},
			"ajax": {
				url: "/Antecedentes/ListaAntecedentes?idTipoAntecedente=" + idTipoAntecedente.value + '&idHistoria=' + codHist.value,
				type: "GET",
				dataType: "json",
			},
			"columns": [
				{ "data": 'LSACODIGOI' },
				{ "data": 'LSADESCRIPCION' },
				{
					"data": "check", render: function (data) {						
						if (data.split(';')[2] === 'true') {
							return `<input onchange="opcion(${data.split(';')[1]})" checked type="radio" required value="1" name="opcion${data.split(';')[1]}" id="opcionSi${data.split(';')[1]}" class="form-control-sm" />`
						} else if (data.split(';')[2] === 'false') {
							return `<input onchange="opcion(${data.split(';')[1]})" type="radio" required value="1" name="opcion${data.split(';')[1]}" id="opcionSi${data.split(';')[1]}" class="form-control-sm" />`
						} else {
							return `<input onchange="opcion(${data.split(';')[1]})" type="radio" required value="1" name="opcion${data.split(';')[1]}" id="opcionSi${data.split(';')[1]}" class="form-control-sm" />`
						}
							
						
					}
				},
				{
					"data": "check", render: function (data) {
						if (data.split(';')[2] === 'true') {
							return `<input onchange="opcion(${data.split(';')[1]})" type="radio" required value="0" name="opcion${data.split(';')[1]}" id="opcionNo${data.split(';')[1]}" class="form-control-sm" />`
						} else if (data.split(';')[2] === 'false') {
							return `<input onchange="opcion(${data.split(';')[1]})" type="radio" checked required value="0" name="opcion${data.split(';')[1]}" id="opcionNo${data.split(';')[1]}" class="form-control-sm" />`
						} else {
							return `<input onchange="opcion(${data.split(';')[1]})" type="radio" required value="0" name="opcion${data.split(';')[1]}" id="opcionNo${data.split(';')[1]}" class="form-control-sm" />`
						}
						
					}
				},
				{
					"data": "Comentario", render: function (data) {
						return `<input type="text" class="form-control" name="comentario${data.split(';')[1]}" value = '${data.split(';')[0]}' required id="comentario${data.split(';')[1]}" />`
					}
				}
			]
		})
	} 
	
}


function opcion(id) {
	let opcionSi = document.getElementById('opcionSi' + id);
	let comentario = document.getElementById('comentario' + id);
	if (opcionSi.checked) {
		comentario.disabled = false;
		comentario.value = '';
	} else {
		comentario.disabled = true;
		comentario.value = 'No Refiere';
	}

}